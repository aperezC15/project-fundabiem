using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.ModelsDTO;
using fundabiemAPI.clssResponses;
using fundabiemAPI.Middleware;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fundabiemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroMedicoController : coreControllerFundabiem<RegistroMedicoController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;
        public RegistroMedicoController(ILogger<RegistroMedicoController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }
        //crer un registro medico
        [HttpPost("new")]
        public async Task<ActionResult> newRegistroMedico([FromBody] CreateRegistroMedicoDTO model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                logger.LogInformation("BeginTransaction  create registro medico");
                try
                {
                    getUser();
                    var persona = await fundabiem.searchPersonaByDPI(model.paciente.dpi);
                    if (persona.Count() > 0)
                        return BadRequest("El DPI ya existe");

                    logger.LogInformation("Creating a new Registro Medico");
                    var PersonaPaciente = await fundabiem.newPersona(model.paciente);
                    //crea la direccion del paciente
                    await fundabiem.newDirection(model.direccionPaciente, PersonaPaciente.idPersona);
                    //crea el paciente
                    var pacienteR = await fundabiem.newPatient(model.HistorialClinico, PersonaPaciente.idPersona);
                    //agrega el registro medico
                    await fundabiem.newRegistroMedico(pacienteR.idPaciente);
                    //creamos todos los familiares del paciente, hago un forEach para saber quien es el encargado
                    foreach (var familiar in model.familiaresPaciente)
                    {   //agrega la persona
                        var fm = mapper.Map<CreatePersonaDTO>(familiar);
                        var prsona = await fundabiem.newPersona(fm);
                        //agrega el familiar
                        await fundabiem.newFamiliar(prsona.idPersona, pacienteR.idPersona, familiar.parentezco);
                        //si es encargado, hacemos el registro
                        if (familiar.isManager)
                        {
                            //registramos la direccion del encargado
                            await fundabiem.newDirection(model.direccionEncargado, prsona.idPersona);
                            //agregamos el registro a la tabla de personas encargadas
                            await fundabiem.newPersonaEncargada(prsona.idPersona, pacienteR.idPaciente);
                        }
                    }
                    transaction.Commit();
                    logger.LogInformation("Commit transaction create registro medico");
                    return Ok();
                }
                catch (Exception ex)
                {
                    logger.LogInformation("RollBack transaction create registro medico");
                    logger.LogError(ex.ToString());
                    return BadRequest();
                }
            }
        }

        [HttpGet("searchById")]
        public ActionResult<IEnumerable<RegistroMedico>> searchRegistroMedico(int idRegistro)
        {
            getUser();
            var rgMedicos = fundabiem.searchRegistroMedicos(idRegistro);
            if (rgMedicos.Count() == 0)
                return NotFound();
            return Ok(rgMedicos);
        }

        //busca un diagnostico por el id del registro medico
        [HttpGet("diagnostico/search/")]
        public ActionResult<IEnumerable<RegistroMedicoDiagnostico>> getDiagnostico(int IdRegistroMedico) 
        {
            getUser();
            var diagnostico = fundabiem.getDianostico(IdRegistroMedico);
            if (diagnostico.Result.Count() == 0)
                return BadRequest("no se encontraron registros");
            return Ok(diagnostico.Result);
        }

        [HttpGet("getAll")]
        public async  Task<ActionResult<clsResponse<RegistroMedico>>> getRegistroMedico(int pagina, int rowsPerPage)
        {
            logger.LogInformation("Get all REgistros Medicos with user => {0}",getUser());
            var rgMedicos = await fundabiem.getAllRegistrosMedicos(pagina, rowsPerPage);
            return Ok(rgMedicos);
        }

        [HttpPost("completar")]
        public async Task<ActionResult> completarRegistroMedico([FromBody]RegistroMedicoDiagnosticoDTO model)
        {
            var user = getUser();
            var a =user.FirstOrDefault();
            logger.LogInformation("usuario => {0} ", a);
            string txt = "completa registro medico";
            using (var transaction = context.Database.BeginTransaction())
            {
                logger.LogInformation("BeginTransaction {0} ", txt);
                try
                {
                    var cp = await fundabiem.completRegistroMedico(model);
                    transaction.Commit();
                    logger.LogInformation("Commit transaction");
                    return Ok(cp);
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    logger.LogError("RoolBAck transaction {0} ", txt);
                    logger.LogError(ex.ToString());
                    return BadRequest("No se completo la operacion de completar registro medico");
                }
            }
        }
    }
}