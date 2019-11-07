using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.ModelsDTO;
using fundabiemAPI.clssResponses;
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
        public async Task<ActionResult> newEvolucionMedica(CreateEvolucionMedicaDTO model)
        {
            logger.LogInformation("Creating resource: EvolucionMedica by user {0}",getUser());
            try
            {
                var evolucionMedica = await fundabiem.newEvolucionMedica(model);
                return new CreatedAtRouteResult("ObtenerEvolucion", new { id = evolucionMedica.idEvolucionMedica }, evolucionMedica);
            }
            catch (Exception ex)
            {
                logger.LogInformation("An error has ocurred: EvolucionMedica");
                logger.LogError(ex.ToString());
                return BadRequest();
            }
        }

        //obtener citas
        [HttpGet("{id}", Name ="ObtenerEvolucion")]
        public ActionResult<DTOEvolucionMedica> getEvolucion(int id)
        {
            var evolucion = fundabiem.getEvolucionMedica(id);
            if (evolucion.Result == null)
                return NotFound("No se encontro la evolucion con id => " + id.ToString());
            return Ok(evolucion.Result);
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<clsResponse<DTOEvolucionMedica>>> getEvolucionMedica(int pagina, int rowsPerPage)
        {
            logger.LogInformation("searching all evoluciones medias by user => {0}", getUser());
            var evolucionesMedicas = await fundabiem.getAllEvolucionesMedicas(pagina, rowsPerPage);
            return Ok(evolucionesMedicas);
        }
    }
}
