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
    public class HistoriaClinicaPsicologicaController : coreControllerFundabiem<HistoriaClinicaPsicologicaController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;
        public HistoriaClinicaPsicologicaController(ILogger<HistoriaClinicaPsicologicaController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }

        //para crear una historia clinica psicologica nueva
        [HttpPost("new")]
        public async Task<ActionResult> newHistoriaPsicologica([FromBody]HistoriaClinicaPsicologicaDTO model)
        {
            var txt = "Creating new HistoriaPsicologica by user => "+getUser();
            using(var transaction = context.Database.BeginTransaction())
            {
                logger.LogInformation("Begin Transaction {0}", txt);
                try
                {
                    var psicologica = await fundabiem.newHistoriaClinicaPsicologica(model);
                    transaction.Commit();
                    logger.LogInformation("Commit Transaction {0}", txt);
                    return new CreatedAtRouteResult("ObtenerHistoriaPsicologica", new { id=psicologica.idHistoriaclinicaPsicologica}, psicologica);
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    logger.LogInformation("RollBack transaction {0}", txt);
                    logger.LogError(ex.ToString());
                    return BadRequest("No se completo la tarea de nuevo hisoriaclinicaPsicologica");
                }
            }
        }

        [HttpGet("{id}", Name = "ObtenerHistoriaPsicologica")]
        public  ActionResult<HistoriaClinicaPsicologica> getHistoriaClinica(int id)
        {
            logger.LogInformation("Searhing historia clinica psicologica with id = {0} by user {1}", id, getUser());
            var psicologica =  fundabiem.getHistoriaClinicaPsicologicaById(id);
            if (psicologica.Result == null)
                return NotFound("No se encontro la historia clinica Psicologica con id = "+ id);
            return Ok(psicologica.Result);
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<clsResponse<HistoriaClinicaPsicologicaDTO>>> getAll(int pagina, int rowsPerPage)
        {
            logger.LogInformation("Get all ciclo de historia clinica psicologica page {0} rowsPerPage {1} by user => {2}", pagina, rowsPerPage, getUser());
            var psicologicas = await fundabiem.getallHistoriaClinicaPsicologicas(pagina, rowsPerPage);
            return Ok(psicologicas);
        }
    }
}