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

        //obtiene todos los objetivos de intervencion
        public IEnumerable<ObjetivoDeIntervencion> getAllObjetivos()
        {
           return context.ObjetivosDeIntervenciones.ToList();
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

        //obtiene todos los registros medicos
        public  IEnumerable<RegistroMedico> getAllRegistrosMedicos()
        {
            logger.Information("Get all REgistros Medicos");
            return context.RegistrosMedicos.Include(paciente => paciente.paciente.persona).ToList();
        }

        //para obtener un registro medico segun id de paciente o HistorialClinico
        public IEnumerable<RegistroMedico> searchRegistroMedicos(int idRegistro)
        {
            logger.Information("Search Registro Medico by Id");
            return context.RegistrosMedicos.Where(x=> x.idRegistroMedico == idRegistro).Include(paciente => paciente.paciente.persona).ToList();
        }

        //para obtener un paciente segun su id
        public IEnumerable<Paciente> searchPaciente(string valor, string criterio)
        {
            var resultado  = new List<Paciente>();
            switch (criterio)
            {
                case "id":
                     resultado = context.Pacientes.Where(x => x.idPaciente == Convert.ToInt64(valor)).Include(x => x.persona).ToList();
                    break;

                case "nombre":
                    resultado = context.Pacientes.Where(x => (x.persona.primerNombre +" "+ x.persona.segundoNombre +" "+ x.persona.primerApellido +" "+ x.persona.segundoApellido).Contains(valor) ).Include(x => x.persona).ToList();
                    break;

                case "historialClinico":
                    resultado = context.Pacientes.Where(x => x.historialClinico == Convert.ToInt64(valor)).Include(x => x.persona).ToList();
                    break;

                case "DPI":
                    resultado = context.Pacientes.Where(x => x.persona.dpi == valor).Include(x => x.persona).ToList();
                    break;
                    
            }
            return resultado;
            
        }

        //para obtener un paciente segun su numero de historialClinico
        public IEnumerable<Paciente> searchPacienteByHistorialClinico(int historialClinico)
        {
            return context.Pacientes.Where(x => x.historialClinico == historialClinico).Include(x => x.persona).ToList();
        }

        public IEnumerable<SeccionAnamnesisDTO> getSeccionesconItemsAnamnesis()
        {
            var secciones = context.SeccionesAnamnesis.Include(seccion => seccion.itemsAnamnesis).ToList();

            var seccionesDTO = mapper.Map<List<SeccionAnamnesisDTO>>(secciones);

            return seccionesDTO;
        }
    
        //crea un ciclo de rehabilitcion
        public async Task<Int64> newCicloRehabilitacion(CreateCicloRehabilitacionDTO ciclo)
        {
            logger.Information("create a new ciclo de rehabilitacion ");
            var cl = mapper.Map<CicloDeRehabilitacion>(ciclo);
            await context.CicloDeRehabilitaciones.AddAsync(cl);
            await context.SaveChangesAsync();
            return cl.idcicloRehabilitacion;
        }

        //crea el detalle del ciclo de rehabilitacion
        public async Task<DetalleCicloDeRehabilitacion> newDetalleCicloRehabilitacion(DetalleCicloRehabilitcionDTO detalle)
        {
            logger.Information("Create a new detalle ciclo de rehabilitacion");
            var dt = mapper.Map<DetalleCicloDeRehabilitacion>(detalle);
            await context.DetalleCicloDeRehabilitaciones.AddRangeAsync(dt);
            await context.SaveChangesAsync();
            return dt;
        }

        public async Task<Persona> newPersona(CreatePersonaDTO persona)
        {
            logger.Information("Create a new persona");
            var pe = mapper.Map<Persona>(persona);
            await context.Personas.AddAsync(pe);
            await context.SaveChangesAsync();
            var personaDTO = mapper.Map<CreatePersonaDTO>(pe);
            return await getPersona(pe.idPersona);
        }

        //obtiene un ciclo de rehabilitacion segun su id
        public async Task<CicloDeRehabilitacion> getCicloById(Int64 idCiclo)
        {
            return await context.CicloDeRehabilitaciones.FirstOrDefaultAsync(x => x.idcicloRehabilitacion == idCiclo);
        }

        //obtiene una persona segun idPersona
        public async Task<Persona> getPersona(Int64 idPersona)
        {
            var persona = await context.Personas.FirstOrDefaultAsync(x => x.idPersona == idPersona);
            return persona;
        }
        //busca el diagnotico
        public async Task<IEnumerable<RegistroMedicoDiagnostico>> getDianostico(int idRegistroMedico)
        {
            var dg = await context.RegistrosMedicosDiagnostico.Where(x => x.idRegistroMedico == idRegistroMedico).ToListAsync();
            return dg;
        }

        //crea un nuevo paciente
        public async Task<Paciente> newPatient(int historialClinico, Int64 idPersona)
        {
            logger.Information("create a new Paciente");
            CreatePacienteDTO paciente = new CreatePacienteDTO();
            paciente.estaActivo = true;
            paciente.historialClinico = historialClinico;
            paciente.idPersona = idPersona;
            var patient = mapper.Map<Paciente>(paciente);
            await context.Pacientes.AddAsync(patient);
            await context.SaveChangesAsync();
            var pacienteDTO = mapper.Map<CreatePacienteDTO>(patient);
            return await getPacienteById(patient.idPaciente);
        }

        //obtener todos los pacientes
        public IEnumerable<Paciente> getAllPacientes()
        {
            return context.Pacientes.Include(x=>x.registrosMedicos).Include(x => x.cicloDeRehabilitaciones).ToList();
        }
        //buscar paciente por id
        public async Task<Paciente> getPacienteById(Int64 idPaciente)
        {
            logger.Information("reading paciente with id = ", idPaciente);
            var paciente = await context.Pacientes.FirstOrDefaultAsync(x => x.idPaciente == idPaciente);
            return paciente;
        }

        //crea un registro medico
        public async Task newRegistroMedico(Int64 idPaciente)
        {
            logger.Information("Create a new Registro Medico to paciente id = {0}", idPaciente);
            RegistroMedico rg = new RegistroMedico();
            rg.idPaciente = idPaciente;
            rg.fechaAdmision = new DateTime();
            rg.estaFirmado = true;
            await context.RegistrosMedicos.AddAsync(rg);
            await context.SaveChangesAsync();
        }

        //completar un registro medico
        public async Task<RegistroMedicoDiagnostico> completRegistroMedico(RegistroMedicoDiagnosticoDTO model)
        {
            logger.Information("completar registro medico");
            var cp = mapper.Map<RegistroMedicoDiagnostico>(model);
            await context.RegistrosMedicosDiagnostico.AddAsync(cp);
            await context.SaveChangesAsync();
            return cp;
        }

        public async Task newPersonaEncargada(Int64 idPersona, Int64 idPaciente)
        {
            logger.Information("Create a new Persona encargado to paciente id = {0}", idPaciente);
            PersonaEncargada prsonEncargada = new PersonaEncargada();
            prsonEncargada.idPersona = idPersona;
            prsonEncargada.idPaciente = idPaciente;
            prsonEncargada.estaActivo = true;
            await context.PersonasEncargadas.AddAsync(prsonEncargada);
            await context.SaveChangesAsync();
        }

        //guarda la direccion de una persona
        public async Task newDirection(DireccionDTO model, Int64 idPersona)
        {
            logger.Information("Creating a new direction");
            var direction = mapper.Map<Direccion>(model);
            direction.idPersona = idPersona;
            await context.Direcciones.AddAsync(direction);
            await context.SaveChangesAsync();
        }

        //crea un familiar de un paciente
        public async Task newFamiliar(Int64 idPersona, Int64 idPaciente, string parentezco)
        {
            logger.Information("Creating a new familiar to pacienteId = {0}", idPaciente);
            FamiliaresPaciente fmr = new FamiliaresPaciente();
            fmr.idPersona = idPersona;
            fmr.idPaciente = idPaciente;
            fmr.parentezco = parentezco;
            await context.familiaresPacientes.AddAsync(fmr);
            await context.SaveChangesAsync();
        }

        public async Task newAnamnesis(Int64 idHistoriaClinica,  CrearAnamnesisDTO modelo)
        {
            logger.Information("Creating a new history");

            var anamnesis = new Anamnesis
            {
                idHistoriaClinica = idHistoriaClinica,
                idItemAnamnesis = modelo.idItemAnamnesis,
                diagnostico = modelo.diagnostico
            };

            await context.Anamnesis.AddAsync(anamnesis);
            await context.SaveChangesAsync();
        }

        public async Task newHistoriaClinica(CrearHistoriaClinicaDTO modelo)
        {
            logger.Information("Creating a new clinic history");

            var historiaClinica = new HistoriaClinica
            {
                idPaciente = modelo.idPaciente,
                fechaDeRegistro = DateTime.Today,
                motivoDeConsulta = modelo.motivoConsulta,
                diagnosticoFinal = modelo.diagnosticoFinal
            };

            await context.HistoriasClinicas.AddAsync(historiaClinica);
            await context.SaveChangesAsync();

            foreach(var anamnesis in modelo.anamnesis)
            {
                await newAnamnesis(historiaClinica.idHistoriaClinica, anamnesis);
            }
        }
    }
}   
