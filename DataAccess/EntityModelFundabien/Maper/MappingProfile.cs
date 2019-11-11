using AutoMapper;
using EntityModelFundabien.entities;
using EntityModelFundabien.Models;
using EntityModelFundabien.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Add as many of these lines as you need to mapy your objetct entities
            CreateMap<Autor, AutorDTO>();
            CreateMap<Pais, DTOPaises>();
            CreateMap<Departamento, departamentosDTO>();
            CreateMap<Municipio, municipiosDTO>();
            CreateMap<CreateAutorDTO, Autor>();
            CreateMap<Autor, CreateAutorDTO>();
            CreateMap<ItemAnamnesis, ItemAnamnesisDTO>();
            CreateMap<ItemAnamnesisDTO, ItemAnamnesis>();
            CreateMap<SeccionAnamnesis, SeccionAnamnesisDTO>();
            CreateMap<SeccionAnamnesisDTO, SeccionAnamnesis>();
            CreateMap<Persona, CreatePersonaDTO>();
            CreateMap<CreatePersonaDTO, Persona>();
            CreateMap<Direccion, DireccionDTO>();
            CreateMap<DireccionDTO, Direccion>();
            CreateMap<Paciente, CreatePacienteDTO>();
            CreateMap<CreatePacienteDTO, Paciente>();
            CreateMap<RegistroMedico, CreatePacienteDTO>();
            CreateMap<CreatePacienteDTO, RegistroMedico>();
            CreateMap<CreatePersonaDTO, FamiliarDTO>();
            CreateMap<FamiliarDTO, CreatePersonaDTO>();
            CreateMap<CicloDeRehabilitacion, CicloDeRehabilitacionDTO>();
            CreateMap<CicloDeRehabilitacionDTO, CicloDeRehabilitacion>();
            CreateMap<DetalleCicloDeRehabilitacion, DetalleCicloRehabilitcionDTO>();
            CreateMap<DetalleCicloRehabilitcionDTO, DetalleCicloDeRehabilitacion>();
            CreateMap<CreateCicloRehabilitacionDTO, CicloDeRehabilitacion>();
            CreateMap<CicloDeRehabilitacion, CreateCicloRehabilitacionDTO>();
            CreateMap<RegistroMedicoDiagnostico, RegistroMedicoDiagnosticoDTO>();
            CreateMap<RegistroMedicoDiagnosticoDTO, RegistroMedicoDiagnostico>();
            CreateMap<CreateCitaDTO, Citas>();
            CreateMap<Citas, CreateCitaDTO>();
            CreateMap<citaDTO, Citas>();
            CreateMap<Citas, citaDTO>();
            CreateMap<SeccionEstudioSocioeconomico, SeccionEstudioSocioeconomicoDTO>();
            CreateMap<ItemEstudioSocioeconomico, ItemEstudioSocioeconomicoDTO>();
            CreateMap<OpcionItemEstudioSocioeconomico, OpcionItemEstudioSocioeconomicoDTO>();
            CreateMap<pacienteDTO, Paciente>();
            CreateMap<Paciente, pacienteDTO>();
            CreateMap<CreateEvolucionMedicaDTO, EvolucionMedica>();
            CreateMap<EvolucionMedica, CreateEvolucionMedicaDTO>();
            CreateMap<DTOEvolucionMedica, EvolucionMedica>();
            CreateMap<EvolucionMedica, DTOEvolucionMedica>();
            CreateMap<EvolucionTecnica, EvolucionTecnicaDTO>();
            CreateMap<EvolucionTecnicaDTO, EvolucionTecnica>();
            CreateMap<CreateEvolucionTecnicaDTO, EvolucionTecnica>();
            CreateMap<EvolucionTecnica, CreateEvolucionTecnicaDTO>();
            CreateMap<EstudioSocioeconomico, EstudioSocioeconomicoDTO>();
            CreateMap<CreateEstudioSocioeconomicoDTO, EstudioSocioeconomico>();
            CreateMap<CreateGrupoFamiliarDTO, GrupoFamiliar>();
            CreateMap<CreateEvaluacionEstudioSocioeconomicoDTO, EvaluacionEstudioSocioeconomico>();
            CreateMap<HistoriaClinicaPsicologica, HistoriaClinicaPsicologicaDTO>();
            CreateMap<HistoriaClinicaPsicologicaDTO, HistoriaClinicaPsicologica>();
            CreateMap<antecedentesPaciente, antecedntePacienteDTO>();
            CreateMap<antecedntePacienteDTO, antecedentesPaciente>();
            CreateMap<examenMental, examenMentalDTO>();
            CreateMap<examenMentalDTO, examenMental>();
            CreateMap<HistoriaClinicaPsicologicaDTOResponse, HistoriaClinicaPsicologica>();
            CreateMap<HistoriaClinicaPsicologica, HistoriaClinicaPsicologicaDTOResponse>();
        }
    }
}
