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
            getUser();
            logger.LogInformation("Reading all ObjetivosIntervencion");
            var objetivos = fundabiem.getAllObjetivos();
            if (objetivos.Count() == 0)
                return NotFound();
            return Ok(objetivos);
        }

        //crear nuevo ciclo de rehabilitacion
        [HttpPost]
        public async Task<ActionResult> newCiclo([FromBody] CreateCicloRehabilitacionDTO ciclo)
        {
            string txt = "create ciclo de rehabilitacion";
            using (var transaction = context.Database.BeginTransaction())
            {
                logger.LogInformation("BeginTransaction {0}",txt);
                try
                {
                    var cicloReha = await fundabiem.newCicloRehabilitacion(ciclo);
                    transaction.Commit();
                    logger.LogInformation("Commit transaction {0}",txt);
                    return Ok();
                }
                catch(Exception ex)
                {
                    logger.LogError("RollBack transaction {0}",txt);
                    logger.LogError(ex.ToString());
                    return BadRequest();
                }
            }
        }

    }
}