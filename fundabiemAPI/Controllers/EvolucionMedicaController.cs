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
    [Route("api/evolucion-medica")]
    [ApiController]
    public class EvolucionMedicaController : coreControllerFundabiem<EvolucionMedicaController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;

        public EvolucionMedicaController(ILogger<EvolucionMedicaController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }


        // ingresa la evolucion medica
        [HttpPost]
        public async Task<ActionResult<EvolucionMedica>> newEvolucionMedica(CreateEvolucionMedicaDTO model)
        {
            logger.LogInformation("Creating resource: EvolucionMedica");

            try
            {
                var evolucionMedica = await fundabiem.newEvolucionMedica(model);
                return Ok(evolucionMedica);
            }
            catch (Exception ex)
            {
                logger.LogInformation("An error has ocurred: EvolucionMedica");
                logger.LogError(ex.ToString());
                return BadRequest();
            }
        }
    }
}
