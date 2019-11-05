using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.Models;
using EntityModelFundabien.ModelsDTO;
using fundabiemAPI.clssResponses;
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
        //private readonly Func<IFundabiemCommonLogic<TI, TC>> contratoEntityFactory;
        private readonly dbContext context;
        private readonly IMapper mapper;
        private readonly ILogger logger;
        //private dbContext context1;


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
        public IEnumerable<departamentosDTO> getDepartamentosByIdPais(double id)
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

        //obtiene los estados de citas
        public IEnumerable<EstadoCitas> getAllEstadoCitas()
        {
            return context.EstadoCitas.ToList();
        }

        //obtiene las terapias disponibles
        public IEnumerable<Terapias> getAllTerapias()
        {
            return context.Terapias.ToList();
        }

        //obtiene todos los registros medicos
        public async Task<clsResponse<RegistroMedico>> getAllRegistrosMedicos(int pagina, int rowsPerPAge)
        {
            var query = context.RegistrosMedicos.AsQueryable();
            var totalRegisters = query.Count();

            logger.Information("Get all REgistros Medicos");
           // var rg = context.RegistrosMedicos.Include(paciente => paciente.paciente.persona).ToList();
            var rgs = await query
                .Skip(rowsPerPAge * (pagina - 1))
                .Take(rowsPerPAge)
                .Include(x => x.diagnostico)
                .Include(paciente => paciente.paciente.persona)
                .OrderBy(x => x.idRegistroMedico)
                .ToListAsync();
            clsResponse<RegistroMedico> rps = new clsResponse<RegistroMedico>();
            rps.Error = false;
            rps.RegistrosFundabiem = rgs;
            rps.pages = ((int)Math.Ceiling((double)totalRegisters / rowsPerPAge));
            rps.totalRows = totalRegisters;
            return rps;
        }

        //optiene historias clinicas
        public async Task<clsResponse<HistoriaClinica>> getAllHistoriaClinicas(int pagina, int rowsPerPAge)
        {
            var query = context.HistoriasClinicas.AsQueryable();
            var totalRegisters = query.Count();
            var historias = await query
                .Skip(rowsPerPAge * (pagina - 1))
                .Take(rowsPerPAge)
                .OrderBy(x => x.idHistoriaClinica)
                .ToListAsync();
            clsResponse<HistoriaClinica> histClinicas = new clsResponse<HistoriaClinica>();
            histClinicas.Error = false;
            histClinicas.RegistrosFundabiem = historias;
            histClinicas.pages = ((int)Math.Ceiling((double)totalRegisters / rowsPerPAge));
            histClinicas.totalRows = totalRegisters;
            return histClinicas;
        }

        //para obtener un registro medico segun id de paciente o HistorialClinico
        public IEnumerable<RegistroMedico> searchRegistroMedicos(int idRegistro)
        {
            logger.Information("Search Registro Medico by Id");
            return context.RegistrosMedicos.Where(x => x.idRegistroMedico == idRegistro).Include(paciente => paciente.diagnostico).Include(x=> x.paciente.persona).ToList();
        }

        //para obtener un paciente segun su id
        public IEnumerable<Paciente> searchPaciente(string valor, string criterio)
        {
            var resultado = new List<Paciente>();
            switch (criterio)
            {
                case "id":
                    resultado = context.Pacientes.Where(x => x.idPaciente == Convert.ToInt64(valor)).Include(x => x.persona).ToList();
                    break;

                case "nombre":
                    resultado = context.Pacientes.Where(x => (x.persona.primerNombre + " " + x.persona.segundoNombre + " " + x.persona.primerApellido + " " + x.persona.segundoApellido).Contains(valor)).Include(x => x.persona).ToList();
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
        public async Task<CicloDeRehabilitacion> newCicloRehabilitacion(CreateCicloRehabilitacionDTO ciclo)
        {
            logger.Information("create a new ciclo de rehabilitacion ");
            var cl = mapper.Map<CicloDeRehabilitacion>(ciclo);
            await context.CicloDeRehabilitaciones.AddAsync(cl);
            await context.SaveChangesAsync();
            return cl;
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
        public async Task<CreateCicloRehabilitacionDTO> getCicloById(Int64 idCiclo)
        {
            var ciclo= await context.CicloDeRehabilitaciones.Include(x => x.detalleCicloRehabilitacion).FirstOrDefaultAsync(x => x.idcicloRehabilitacion == idCiclo);
            var cicloDTO = mapper.Map<CreateCicloRehabilitacionDTO>(ciclo);
            return cicloDTO;
        }
        
        //obiene una cita por  su id
        public async Task<citaDTO> getCitaById(int id)
        {
             var cita = await context.Citas.FirstOrDefaultAsync(x => x.IdCita == id);
             var citaDTO = mapper.Map<citaDTO>(cita);
            return citaDTO;
        }

        //obtiene cita por la fecha, y por rango de fechas si range = true
        public async Task<IEnumerable<citaDTO>> getCitaByDate(string DateType, DateTime fecha, bool range, DateTime dateEnd, int idTerapia, int idEstado)
        {
            var cita = new List<Citas>();

            if (DateType == "fechaCita")
            {
                if (range)
                    cita = await context.Citas.Where(x => x.fechaCita.Date >= fecha.Date && x.fechaCita.Date <= dateEnd.Date && x.IdTerapia == idTerapia && x.idEstado == idEstado).ToListAsync();
                else
                    cita = await context.Citas.Where(x => x.fechaCita.Date == fecha.Date && x.IdTerapia == idTerapia && x.idEstado == idEstado).ToListAsync();
            }
            else if (DateType == "fechaAsignacion")
            {
                if (range)
                    cita = await context.Citas.Where(x => x.fechaAsignacion.Date >= fecha.Date && x.fechaAsignacion.Date <= dateEnd.Date && x.IdTerapia == idTerapia && x.idEstado == idEstado).ToListAsync();
                else
                    cita = await context.Citas.Where(x => x.fechaAsignacion.Date == fecha.Date && x.IdTerapia == idTerapia && x.idEstado == idEstado).ToListAsync();
            }
            else
                cita = null;
            var ct = mapper.Map<List<citaDTO>>(cita);
            return ct;
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
            return context.Pacientes.Include(x => x.registrosMedicos).Include(x => x.cicloDeRehabilitaciones).ToList();
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
            rg.fechaAdmision = DateTime.Today;
            rg.estaFirmado = true;
            await context.RegistrosMedicos.AddAsync(rg);
            await context.SaveChangesAsync();
        }
        //buscar persona por  DPI
        public async Task<IEnumerable<Persona>> searchPersonaByDPI(string dpi) {
            logger.Information("Search person by dpi = {0} ", dpi);
            var persona = await context.Personas.Where(x => x.dpi == dpi).ToListAsync();
            return persona;
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

        //new cita
        public async Task<Citas> NewCita(CreateCitaDTO model)
        {
            var paciente = context.Pacientes.Include(x => x.persona).FirstOrDefaultAsync(x => x.idPaciente == model.dPaciente);
            logger.Information("Creatin a new cita");
            var cita = mapper.Map<Citas>(model);
            cita.idEstado = 5;
            cita.fechaAsignacion = DateTime.Today;
            cita.edad = DateTime.Today.AddTicks(-paciente.Result.persona.fechaNacimiento.Ticks).Year - 1;
            await context.Citas.AddAsync(cita);
            await context.SaveChangesAsync();
            return cita;
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

        //obtiene una evolucion medica segun su id
        public async Task<EvolucionMedica> getEvolucionMedica(Int64 idEvolucionMedica) =>
            await context.EvolucionesMedicas.FirstOrDefaultAsync(e => e.idEvolucionMedica == idEvolucionMedica);
        

        public async Task<EvolucionMedica> newEvolucionMedica(CreateEvolucionMedicaDTO modelo)
        {
            var evolucionMedica = mapper.Map<EvolucionMedica>(modelo);
            await context.EvolucionesMedicas.AddAsync(evolucionMedica);
            await context.SaveChangesAsync();
            
            return await getEvolucionMedica(evolucionMedica.idEvolucionMedica);
        }
    }
}   
