using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
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
    public class HistoriaClinicaController : coreControllerFundabiem<HistoriaClinicaController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;
        public HistoriaClinicaController(ILogger<HistoriaClinicaController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }

        // HistoriaClinica
        [HttpPost("new")]
        public async Task<ActionResult> newHistoriaClinica([FromBody] CrearHistoriaClinicaDTO model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                logger.LogInformation("BeginTransaction  Crear Historia Clinica");
                try
                {
                    await fundabiem.newHistoriaClinica(model);
                    transaction.Commit();
                    logger.LogInformation("Commit transaction Crear Historia Clinica");
                    return Ok();
                }
                catch (Exception ex)
                {
                    logger.LogInformation("RollBack transaction Crear Historia Clinica");
                    logger.LogError(ex.ToString());
                    return BadRequest();
                }
            }
        }

        //[HttpGet]
        //public async Task<ActionResult<HistoriaClinica>> get()
        //{
        //    try
        //    {
        //        var histo = fundabiem.newHistoriaClinica
        //    }catch(Exception ex)
        //    {

        //    }

        //}
    }
}