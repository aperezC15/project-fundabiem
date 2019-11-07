using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.ModelsDTO;
using fundabiemAPI.Middleware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundabiemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

     public class CicloRehabilitacionController : coreControllerFundabiem<CicloRehabilitacionController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;
        public CicloRehabilitacionController(ILogger<CicloRehabilitacionController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }
        //obtiene los objetivos de una intervencion
        [HttpGet("ObjetivosIntervencion")]
        public ActionResult<IEnumerable<ObjetivoDeIntervencion>> getObjetivos()
        {
            logger.LogInformation("Reading all ObjetivosIntervencion by user {0}",getUser());
            var objetivos = fundabiem.getAllObjetivos();
            if (objetivos.Count() == 0)
                return NotFound();
            return Ok(objetivos);
        }

        //crear nuevo ciclo de rehabilitacion
        [HttpPost]
        public async Task<ActionResult> newCiclo([FromBody] CreateCicloRehabilitacionDTO ciclo)
        {
            string txt = "create ciclo de rehabilitacion {0} "+getUser();
            using (var transaction = context.Database.BeginTransaction())
            {
                logger.LogInformation("BeginTransaction {0}",txt);
                try
                {
                    var cicloReha = await fundabiem.newCicloRehabilitacion(ciclo);
                    transaction.Commit();
                    logger.LogInformation("Commit transaction {0}",txt);
                    return new CreatedAtRouteResult("ObtenerCicloRehabilitacion", new { id = cicloReha.idcicloRehabilitacion}, cicloReha);
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    logger.LogError("RollBack transaction {0}",txt);
                    logger.LogError(ex.ToString());
                    return BadRequest();
                }
            }
        }

        [HttpGet("{id}", Name = "ObtenerCicloRehabilitacion")]
        public  ActionResult<CreateCicloRehabilitacionDTO> getCicloRehabilitacion(int id)
        {
            logger.LogInformation("Searching ciclo de rehabilitacion by user => ", getUser());
            var ciclo =  fundabiem.getCicloById(id);
            if (ciclo.Result == null)
                return NotFound("No se encontro el ciclo de rehabilitacion con id "+id);
            return Ok(ciclo.Result);
        }

    }
}