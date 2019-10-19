using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.ModelsDTO;
using fundabiemAPI.Middleware;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fundabiemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class fundabiemController : coreControllerFundabiem<fundabiemController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        public fundabiemController(ILogger<fundabiemController> logger,
        IFundabiemCommonLogic<int,int> fundabiem ) : base(logger)
        {
            this.fundabiem = fundabiem;
        }
        //obtiene todos los paises
        [HttpGet("/paises")]
        public  ActionResult<IEnumerable<DTOPaises>> getAllPaises()
        {
            string user = getUser();
            logger.LogInformation("Searching all paises");
            var autor = fundabiem.getAllPaises();
            return autor;
        }
        //obtiene todos los paises segun idPais
        [HttpGet("/departamentos/{id}")]
        public ActionResult<IEnumerable<departamentosDTO>> getDepartamentoByIdPais(double id)
        {
            string user = getUser();
            logger.LogInformation("Searching all departamentos idPais = {0}", id);
            var departamentos = fundabiem.getDepartamentosByIdPais(id);
            if(departamentos.Count() == 0) { return NotFound(); }
            return Ok(departamentos);
        }
        //optine todos los municipios segun idDepartaento
        [HttpGet("/municipios/{idDepartamento}")]
        public ActionResult<IEnumerable<municipiosDTO>> getMunicipiosByIdDepartamento(double idDepartamento)
        {
            string user = getUser();
            logger.LogInformation("Searching all municipios idDepartamento = {0} ", idDepartamento);
            var munis = fundabiem.MunicipiosByIdDepartamento(idDepartamento);
            if (munis.Count() == 0) { return NotFound(); }
            return Ok(munis);
        }

        //obtiene los tipos de direccion
        [HttpGet("/direcciones/tipos")]
        public ActionResult<IEnumerable<TipoDirecciones>> getTipoDirecciones()
        {
            getUser();
            logger.LogInformation("Reading all tipoDirecciones");
            var tipos = fundabiem.getTipoDirecciones();
            if (tipos.Count() == 0)
                return BadRequest();
            return Ok(tipos);
        }
    }
}