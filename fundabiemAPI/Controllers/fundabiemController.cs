﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrokerServices.common;
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
    public class FundabiemController : coreControllerFundabiem<FundabiemController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly IMapper mapper;
        private readonly dbContext context;
        public FundabiemController(ILogger<FundabiemController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, IMapper mapper, dbContext context) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.mapper = mapper;
            this.context = context;
        }
        //obtiene todos los paises
        [HttpGet("paises")]
        public ActionResult<IEnumerable<DTOPaises>> getAllPaises()
        {
            logger.LogInformation("Searching all paises by user => {0}", getUser());
            var autor = fundabiem.getAllPaises();
            return autor;
        }
        //obtiene todos los paises segun idPais
        [HttpGet("departamentos/{id}")]
        public ActionResult<IEnumerable<departamentosDTO>> getDepartamentoByIdPais(double id)
        {
            logger.LogInformation("Searching all departamentos idPais = {0} by user => {1}", id,getUser());
            var departamentos = fundabiem.getDepartamentosByIdPais(id);
            if (departamentos.Count() == 0) { return NotFound(); }
            return Ok(departamentos);
        }
        //optine todos los municipios segun idDepartaento
        [HttpGet("municipios/{idDepartamento}")]
        public ActionResult<IEnumerable<municipiosDTO>> getMunicipiosByIdDepartamento(double idDepartamento)
        {
            logger.LogInformation("Searching all municipios idDepartamento = {0} by user {1}", idDepartamento,getUser());
            var munis = fundabiem.MunicipiosByIdDepartamento(idDepartamento);
            if (munis.Count() == 0) { return NotFound(); }
            return Ok(munis);
        }

        //obtiene los tipos de direccion
        [HttpGet("tipoDirecciones")]
        public ActionResult<IEnumerable<TipoDirecciones>> getTipoDirecciones()
        {
            logger.LogInformation("Reading all tipoDirecciones by user => {0}",getUser());
            var tipos = fundabiem.getTipoDirecciones();
            if (tipos.Count() == 0)
                return BadRequest();
            return Ok(tipos);
        }

        [HttpGet("EstadoCitas")]
        public ActionResult<IEnumerable<EstadoCitas>> getEstadocitas()
        {
            logger.LogInformation("get Estados citas by user => ", getUser());
            var estados = fundabiem.getAllEstadoCitas();
            if (estados.Count() == 0)
                return BadRequest("No se encontraron estados disponibles");
            return Ok(estados);
        }

        [HttpGet("Terapias")]
        public async Task<ActionResult<IEnumerable<Terapias>>> getTerapias()
        {
            logger.LogInformation("get all terapias by user => {0}", getUser());
            var terapias = await fundabiem.getAllTerapias();
            if (terapias.Count() == 0)
                return BadRequest("No se encontraron Terapias");
            return Ok(terapias);
        }
    }
}