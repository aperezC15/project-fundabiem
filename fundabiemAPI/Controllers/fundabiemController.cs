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

        [HttpGet("/paises")]
        public  ActionResult<IEnumerable<DTOPaises>> getAllPaises()
        {
            string user = getUser();
            logger.LogInformation("Searching all paises");
            var autor = fundabiem.getAllPaises();
            return autor;
        }

        [HttpGet("/departamentos/{id}")]
        public ActionResult<IEnumerable<Departamento>> getDepartamentoByIdPais(double id)
        {
            string user = getUser();
            logger.LogInformation("Searching all departamentos idPais = {0}", id);
            var departamentos = fundabiem.getDepartamentosByIdPais(id);
            if(departamentos.Count() == 0) { return NotFound(); }
            return Ok(departamentos);
        }
    }
}