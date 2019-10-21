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
        Task<Paciente> newPatient(CreatePacienteDTO paciente);
        Task<Paciente> getPacienteById(Int64 idPaciente);
        Task newPersonaEncargada(PersonaEncargada encargado);
        Task newRegistroMedico(RegistroMedico model);
        Task newDirection(DireccionDTO model, Int64 idPersona);
        Task newFamiliar(FamiliaresPaciente familiar);
    }
}
