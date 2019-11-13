using fundabiemAPI.Middleware;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using EntityModelFundabien.Interfaces;
using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.ModelsDTO;
using fundabiemAPI.clssResponses;

namespace fundabiemAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudioSocioeconomicoController : coreControllerFundabiem<EstudioSocioeconomicoController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;

        public EstudioSocioeconomicoController(
            ILogger<EstudioSocioeconomicoController> logger, 
            IFundabiemCommonLogic<int, int> fundabiem, 
            IMapper mapper, 
            dbContext context
        )
             : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<clsResponse<EstudioSocioeconomicoDTO>>> getAllEstudiosSocioeconomicos(int pagina, int rowsPerPAge)
        {
            try
            {
                logger.LogInformation("Obteniendo una lista de EstudioSocioeconomico");
                var respuesta = await fundabiem.getAllEstudioSocioeconomico(pagina, rowsPerPAge);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                logger.LogError("Ha ocurrido un error al obtener la lista de estudio socioeconómico", ex.Message);
                return BadRequest("ocurrió un error al obtener la lista de estudio socioeconómico");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EstudioSocioeconomicoDTO>> getEstudioSocioeconomico(long id)
        {
            try
            {
                logger.LogInformation("Obteniendo el EstudioSocioeconomico con ID {0}.", id);
                var respuesta = await fundabiem.getEstudioSocioeconomicoById(id);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                logger.LogError($"Ha ocurrido un error al obtener el estudio socioeconómico con Id {id}. ", ex.Message);
                return BadRequest($"ocurrió un error al obtener el estudio socioeconómico con Id {id}.");
            }
        }


        [HttpGet("secciones")]
        public async Task<ActionResult<clsResponse<SeccionEstudioSocioeconomicoDTO>>> getSecciones()
        {
            try
            {
                logger.LogInformation("Getting sections of EstudioSocioeconomico");
                var respuesta = await fundabiem.getAllSeccionesDeEstudioSocioeconomico();
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                logger.LogError("Ha ocurrido un error al leer las secciones de estudio socioeconómico", ex.Message);
                return BadRequest("ocurrió un error al leer las secciones de estudio socioeconómico");
            }
        }

        [HttpPost]
        public async Task<ActionResult<EstudioSocioeconomicoDTO>> newEstudioSocioeconomico(CreateEstudioSocioeconomicoDTO modelo)
        {
            try
            {
                logger.LogInformation("Creating: EstudioSocioeconomico.");
                var respuesta = await fundabiem.newEstudioSocioeconomico(modelo);
                return CreatedAtAction("getEstudioSocioeconomico", new { id = respuesta.Id }, respuesta );
            }
            catch (Exception ex)
            {
                logger.LogError("Ha ocurrido un error al crear un estudio socioeconómico.", ex.Message);
                return BadRequest("Ha ocurrido un error al crear un estudio socioeconómico.");
            }
        }
    }
}
