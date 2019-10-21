using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.Models;
using EntityModelFundabien.ModelsDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelFundabien.common
{
    public class clsFundabiemCommonLogic<TI, TC> : IFundabiemCommonLogic<TI, TC>
    where TI : struct, IEquatable<TI>
        where TC : struct
    {
        private readonly Func<IFundabiemCommonLogic<TI, TC>> contratoEntityFactory;
        private readonly dbContext context;
        private readonly IMapper mapper;
        private readonly ILogger logger;
        private dbContext context1;
        

        public clsFundabiemCommonLogic(IMapper mapper, dbContext context, ILogger logger)
        {
            this.mapper = mapper;
            this.context = context;
            this.logger = logger;
        }

        public Task RegistrarPAciente()
        {
            throw new NotImplementedException();
        }

        public Task Saludar<TI1>()
        {
            throw new NotImplementedException();
        }

        public ActionResult<AutorDTO> obtenerAutor(int id)
        {
            var autor = context.Autores.FirstOrDefault(x => x.AutorId == id);
            var autorDTO = mapper.Map<AutorDTO>(autor);
            return autorDTO;
        }

        //obtiene todos los paises existentes
        public ActionResult<IEnumerable<DTOPaises>> getAllPaises()
        {
            var paises = context.Paises.ToList();
            var paisDTO = mapper.Map<List<DTOPaises>>(paises);
            return paisDTO;
                
        }
        //obtiene los departamento de un pais
        public  IEnumerable<departamentosDTO> getDepartamentosByIdPais(double id)
        {
            var departamentos = context.Departamentos.Where(x => x.idPais == id).ToList();
            var dep = mapper.Map<List<departamentosDTO>>(departamentos);
            return dep;
        }

        //obtiene los municpios de un departamento
        public IEnumerable<municipiosDTO> MunicipiosByIdDepartamento(double idDepartamento)
        {
            var municipios = context.Municipios.Where(x => x.idDepartamento == idDepartamento).ToList();
            var munis = mapper.Map<List<municipiosDTO>>(municipios);
            return munis;
        }

        //obtiene los tipos de direcciones
        public IEnumerable<TipoDirecciones> getTipoDirecciones()
        {
            var tipos = context.tipoDirecciones.ToList();
            return tipos;
        }
        public async Task<IActionResult> newPersona(CreatePersonaDTO persona)
        {
            logger.Information("Create a new persona");
            var pe = mapper.Map<Persona>(persona);
            await context.Personas.AddAsync(pe);
            await context.SaveChangesAsync();
            var personaDTO = mapper.Map<CreatePersonaDTO>(pe);
            return new CreatedAtRouteResult("getPersona", new { idpersona = pe.idPersona }, personaDTO);
        }

        //obtiene una persona segun idPersona
        public async Task<Persona> getPersona(Int64 idPersona)
        {
            var persona = await context.Personas.FirstOrDefaultAsync(x => x.idPersona == idPersona);
            return persona;
        }

        //crea un nuevo paciente
        public async Task<IActionResult> newPatient(createPacienteDTO paciente)
        {
            logger.Information("create a new Paciente");
            var patient = mapper.Map<Paciente>(paciente);
            await context.Pacientes.AddAsync(patient);
            await context.SaveChangesAsync();
            var pacienteDTO = mapper.Map<createPacienteDTO>(patient);
            return new CreatedAtRouteResult("getPacienteById", new { idPaciente = patient.idPaciente}, pacienteDTO);
        }

        public async Task<Paciente> getPacienteById(Int64 idPaciente)
        {
            logger.Information("reading paciente with id = ", idPaciente);
            var paciente = await context.Pacientes.FirstOrDefaultAsync(x => x.idPaciente == idPaciente);
            return paciente;
        }

        //crea un registro medico
        public async Task newRegistroMedico(RegistroMedico model)
        {
            logger.Information("Create a new Registro Medico to paciente id = ", model.idPaciente);
            await context.AddAsync(model);
            await context.SaveChangesAsync();
        }

        public async Task newPersonaEncargada(PersonaEncargada encargado)
        {
            logger.Information("Create a new Persona encargado to paciente id = ", encargado.idPaciente);
            await context.AddAsync(encargado);
            await context.SaveChangesAsync();
        }
    }
}   
