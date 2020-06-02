using AutoMapper;
using BrokerServices.common;
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
    [Route("api/reportes")]
    [ApiController]
    public class ReportesController : coreControllerFundabiem<ReportesController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;

        public ReportesController(
            ILogger<ReportesController> logger,
            IFundabiemCommonLogic<int, int> fundabiem, 
            IMapper mapper, 
            dbContext context
        ) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("pacientes")]
        public async Task<ActionResult<IEnumerable<citaDTO>>> obtenerReporte(int idMunicipio, int idTerpia)
        {
            var citas = await fundabiem.getReportePacientes(idMunicipio, idTerpia);
            if (citas.Count() == 0)
                return NotFound("No se econtraron citas de pacientes en esa región.");
            return Ok(citas);
        }
    }
}
