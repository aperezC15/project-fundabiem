using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.ModelsDTO;
using fundabiemAPI.Middleware;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fundabiemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnamnesisController : coreControllerFundabiem<AnamnesisController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;
        public AnamnesisController(ILogger<AnamnesisController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }

        // obtiene las secciones con sus items de anamnesis
        [HttpGet("secciones")]
        public ActionResult<IEnumerable<SeccionAnamnesisDTO>> getSeccioneseItemsAnamnesis()
        {
            string user = getUser();
            logger.LogInformation("Searching list of sections and items of anamnesis");
            var secciones = fundabiem.getSeccionesconItemsAnamnesis();
            if (secciones.Count() == 0) { return NotFound(); }
            return Ok(secciones);
        }
    }
}