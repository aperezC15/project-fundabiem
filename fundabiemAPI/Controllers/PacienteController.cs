using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using fundabiemAPI.Middleware;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fundabiemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : coreControllerFundabiem<PacienteController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;
        public PacienteController(ILogger<PacienteController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }

        //obtiene paciente segun id
        [HttpGet("paciente/searchById")]
        public ActionResult<IEnumerable<Paciente>> searchPacienteId(int idPaciente)
        {
            getUser();
            var paciente = fundabiem.searchPacienteById(idPaciente);
            if (paciente.Count() == 0)
                return NotFound();
            return Ok(paciente);
        }

        [HttpGet("paciente/searchByHistorialClinico")]
        //obtiene paciente segun su numero de historialClinico
        public ActionResult<IEnumerable<Paciente>> serachByNoHistorialClinico(int NumeroHistoriakClinico)
        {
            getUser();
            var paciente = fundabiem.searchPacienteByHistorialClinico(NumeroHistoriakClinico);
            if (paciente.Count() == 0)
                return NotFound();
            return Ok(paciente);
        }
    }
}