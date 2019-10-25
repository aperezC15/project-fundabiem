using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.ModelsDTO;
using fundabiemAPI.Middleware;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fundabiemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class FundabiemController : coreControllerFundabiem<FundabiemController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;
        public FundabiemController(ILogger<FundabiemController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }
        //obtiene todos los paises
        [HttpGet("paises")]
        public ActionResult<IEnumerable<DTOPaises>> getAllPaises()
        {
            string user = getUser();
            logger.LogInformation("Searching all paises");
            var autor = fundabiem.getAllPaises();
            return autor;
        }
        //obtiene todos los paises segun idPais
        [HttpGet("departamentos/{id}")]
        public ActionResult<IEnumerable<departamentosDTO>> getDepartamentoByIdPais(double id)
        {
            string user = getUser();
            logger.LogInformation("Searching all departamentos idPais = {0}", id);
            var departamentos = fundabiem.getDepartamentosByIdPais(id);
            if (departamentos.Count() == 0) { return NotFound(); }
            return Ok(departamentos);
        }
        //optine todos los municipios segun idDepartaento
        [HttpGet("municipios/{idDepartamento}")]
        public ActionResult<IEnumerable<municipiosDTO>> getMunicipiosByIdDepartamento(double idDepartamento)
        {
            string user = getUser();
            logger.LogInformation("Searching all municipios idDepartamento = {0} ", idDepartamento);
            var munis = fundabiem.MunicipiosByIdDepartamento(idDepartamento);
            if (munis.Count() == 0) { return NotFound(); }
            return Ok(munis);
        }

        // obtiene las secciones con sus items de anamnesis
        [HttpGet("anamnesis/secciones")]
        public ActionResult<IEnumerable<SeccionAnamnesisDTO>> getSeccioneseItemsAnamnesis()
        {
            string user = getUser();
            logger.LogInformation("Searching list of sections and items of anamnesis");
            var secciones = fundabiem.getSeccionesconItemsAnamnesis();
            if (secciones.Count() == 0) { return NotFound(); }
            return Ok(secciones);
        }

        //obtiene los tipos de direccion
        [HttpGet("tipoDirecciones")]
        public ActionResult<IEnumerable<TipoDirecciones>> getTipoDirecciones()
        {
            getUser();
            logger.LogInformation("Reading all tipoDirecciones");
            var tipos = fundabiem.getTipoDirecciones();
            if (tipos.Count() == 0)
                return BadRequest();
            return Ok(tipos);
        }
        
        // HistoriaClinica
        [HttpPost("historiaclinica")]
        public async Task<ActionResult> newHistoriaClinica([FromBody] CrearHistoriaClinicaDTO model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                logger.LogInformation("BeginTransaction  Crear Historia Clinica");
                try
                {
                    await fundabiem.newHistoriaClinica(model);

                    transaction.Commit();
                    logger.LogInformation("Commit transaction Crear Historia Clinica");
                    return Ok();
                }
                catch (Exception ex)
                {
                    logger.LogInformation("RollBack transaction Crear Historia Clinica");
                    logger.LogError(ex.ToString());
                    return BadRequest();
                }
            }
        }
    }
}