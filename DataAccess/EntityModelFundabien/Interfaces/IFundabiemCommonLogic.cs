using AutoMapper;
using EntityModelFundabien.entities;
using EntityModelFundabien.Models;
using EntityModelFundabien.ModelsDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelFundabien.Interfaces
{
    public interface IFundabiemCommonLogic<TI, TC>
        where TI : struct, IEquatable<TI>
        where TC : struct
    {
        //add all task
        Task RegistrarPAciente();
        Task Saludar<TI>();
        ActionResult<AutorDTO> obtenerAutor(int id);
        ActionResult<IEnumerable<DTOPaises>> getAllPaises();
        IEnumerable<departamentosDTO> getDepartamentosByIdPais(double idPais);
        IEnumerable<municipiosDTO> MunicipiosByIdDepartamento(double idDepartamento);
        IEnumerable<TipoDirecciones> getTipoDirecciones();

        IEnumerable<SeccionAnamnesisDTO> getSeccionesconItemsAnamnesis();

        //Task<ActionResult> CreateNewRegistroMedico(CreateRegistroMedicoDTO RegistroMedico);
        Task<Persona> getPersona(Int64 idPersona);
        Task<Persona> newPersona(CreatePersonaDTO persona);
        Task<Paciente> newPatient(int historialClinico, Int64 idPersona);
        Task<Paciente> getPacienteById(Int64 idPaciente);
        Task newPersonaEncargada(Int64 idPersona, Int64 idPaciente);
        Task newRegistroMedico(Int64 idPaciente);
        Task newDirection(DireccionDTO model, Int64 idPersona);
        Task newFamiliar(Int64 idPersona, Int64 idPaciente, string parentezco);
        IEnumerable<RegistroMedico> getAllRegistrosMedicos();
        IEnumerable<RegistroMedico> searchRegistroMedicos(int idRegistro);
        IEnumerable<Paciente> searchPaciente(string valor, string criterio);
        IEnumerable<Paciente> searchPacienteByHistorialClinico(int historialClinico);
        // Historia Clinica
        Task newAnamnesis(Int64 idHistoriaClinica, CrearAnamnesisDTO modelo);
        Task newHistoriaClinica(CrearHistoriaClinicaDTO modelo);
        IEnumerable<ObjetivoDeIntervencion> getAllObjetivos();
        Task<Int64> newCicloRehabilitacion(CreateCicloRehabilitacionDTO ciclo);
        Task<CicloDeRehabilitacion> getCicloById(Int64 idCiclo);
        Task<DetalleCicloDeRehabilitacion> newDetalleCicloRehabilitacion(DetalleCicloRehabilitcionDTO detalle);
        Task<RegistroMedicoDiagnostico> completRegistroMedico(RegistroMedicoDiagnosticoDTO model);
        IEnumerable<Paciente> getAllPacientes();
        Task<IEnumerable<RegistroMedicoDiagnostico>> getDianostico(int idRegistroMedico);
    }
}
