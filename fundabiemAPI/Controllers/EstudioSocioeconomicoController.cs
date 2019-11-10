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
        public async Task<ActionResult<clsResponse<SeccionEstudioSocioeconomicoDTO>>> get()
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
    }
}
