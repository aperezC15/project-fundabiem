using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using fundabiemAPI.Middleware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

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

        [HttpGet]
        public ActionResult<IEnumerable<ObjetivoDeIntervencion>> getObjetivos()
        {
            getUser();
            logger.LogInformation("Reading all ObjetivosIntervencion");
            var objetivos = fundabiem.getAllObjetivos();
            if (objetivos.Count() == 0)
                return NotFound();
            return Ok(objetivos);
        }

    }
}