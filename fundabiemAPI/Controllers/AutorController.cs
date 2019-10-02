using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.Models;
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
    public class AutorController : coreControllerFundabiem<AutorController>
    {
        private readonly IFundabiemCommonLogic<int, int> fundabiem;
        private readonly dbContext context;
        private readonly IMapper mapper;

        public AutorController(ILogger<AutorController> logger,
        IFundabiemCommonLogic<int, int> fundabiem, dbContext context, IMapper mapper) : base(logger)
        {
            this.fundabiem = fundabiem;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("{id}", Name = "ObtenerAutor")]
        public ActionResult<AutorDTO> GetId(int id)
        {
            logger.LogInformation("Searching Autor with id = {0}",id);
            var autor = fundabiem.obtenerAutor(id);
            if(autor == null) { return NotFound(); }
            return autor;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateAutorDTO autorCreacion)
        {
            var autor = mapper.Map<Autor>(autorCreacion);
            context.Autores.Add(autor);
            await context.SaveChangesAsync();
            var autorDTO = mapper.Map<AutorDTO>(autor);
            return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.AutorId }, autorDTO);
        }


    }
}