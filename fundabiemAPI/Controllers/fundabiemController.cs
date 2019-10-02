using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityModelFundabien.Interfaces;
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

        [HttpGet]
        public async Task<IActionResult> responderHola()
        {
            //var r = await fundabiem.Saludar();
             return Ok("Hola Fundabien estoy :)  ");
        }
    }
}