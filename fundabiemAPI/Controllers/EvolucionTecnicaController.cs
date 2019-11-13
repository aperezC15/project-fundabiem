    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrokerServices.common;
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
    public class EvolucionTecnicaController : coreControllerFundabiem<EvolucionTecnicaController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;

        public EvolucionTecnicaController(ILogger<EvolucionTecnicaController> logger,
       IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult> newEvolucion(CreateEvolucionTecnicaDTO model)
        {
            logger.LogInformation("Creating EvolucionTecnica by user {0}", getUser());
            try
            {
                var evolucionTecnica = await fundabiem.newEvolucionTecnica(model);
                var dto = mapper.Map<EvolucionTecnicaDTO>(evolucionTecnica);
                return new CreatedAtRouteResult("ObtenerEvolucionTecnica", new { id = evolucionTecnica.idEvolucionTecnica }, dto);
            }
            catch (Exception ex)
            {
                logger.LogInformation("An error has ocurred: EvolucionMedica");
                logger.LogError(ex.ToString());
                return BadRequest();
            }
        }
        //para obtener una evolucion tecnica
        [HttpGet("{id}", Name = "ObtenerEvolucionTecnica")]
        public ActionResult<CreateEvolucionTecnicaDTO> getEvolucion(int id)
        {
            var evolucion = fundabiem.getEvelucionTecnica(id);
            if (evolucion.Result == null)
                return NotFound("No se encontro la evolucion con id => " + id.ToString());
            return Ok(evolucion.Result);
        }

        //para obtener evluciones tecnicas pagianados
        [HttpGet]
        public async Task<ActionResult<clsResponse<EvolucionTecnicaDTO>>> getAll(int pagina, int rowsPerPage)
        {
            logger.LogInformation("Get all evolucion tecnicas page {0} rowPerPage {1} by user => {2}", pagina, rowsPerPage, getUser());
            var evoluciones = await fundabiem.getAllEvolucionesTecnicas(pagina,rowsPerPage);
            return Ok(evoluciones);
        }
    }
}