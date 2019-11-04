﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrokerServices.common;
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

    
    public class CitasController : coreControllerFundabiem<CitasController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;
        public CitasController(ILogger<CitasController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("{id}", Name = "ObtenerCita")]
        public ActionResult<citaDTO> getCitaByID (int id)
        {
            var cita = fundabiem.getCitaById(id);
            if (cita.Result == null)
                return NotFound("No se encontro la cita con id  "+ id.ToString());
            return Ok(cita.Result);
        }

        ////obtine citas por fecha
        //[HttpGet("searchByDate/{DateType}/{date}")]
        //public async Task<ActionResult<IEnumerable<citaDTO>>> GetCitaByDate(string DateType, DateTime date)
        //{
        //    var cita = await fundabiem.getCitaByDate(DateType, date, false,date);
        //    if (cita.Count() == 0)
        //        return NotFound("No se encontro la cita con fecha " + date);
        //    return Ok(cita);
        //}

        [HttpGet("searchByDates")]
        public async Task<ActionResult<IEnumerable<citaDTO>>> getCitaRangeDtes(string DateType, DateTime dateStart, DateTime dateEnd, bool range)
        {
            var citas = await fundabiem.getCitaByDate(DateType, dateStart, range, dateEnd);
            if (citas.Count() == 0)
                return NotFound("No se econtraron citas entra la fecha "+dateStart.ToString() +" y "+dateEnd.ToString());
            return Ok(citas);
        }

        [HttpPost("new")]
        public async Task<ActionResult> newCita([FromBody] CreateCitaDTO model)
        {
            string txt = "Create cita medica";
            using (var transaction = context.Database.BeginTransaction())
            {
                logger.LogInformation("BeginTransaction {0} ",txt);
                try
                {
                    var cita = await fundabiem.NewCita(model);
                    transaction.Commit();
                    logger.LogInformation("Commit Transaction {0} ",txt);
                    return new CreatedAtRouteResult("ObtenerCita", new { id = cita.IdCita }, cita);
                }catch(Exception ex)
                {
                    transaction.Rollback();
                    logger.LogError("RollBack transaction {0} ",txt);
                    logger.LogError("Error ==>> {0} ", ex.ToString());
                    return BadRequest("No se completo la accion " + txt);
                }
            }
        }


    }
}