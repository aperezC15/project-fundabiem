using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class HistoriaClinicaPsicologicaDTO
    {
        public Int64 idPaciente { get; set; }
        public string motivoDeConsulta { get; set; }
        public string ocupacion { get; set; }
        public string origenProcedencia { get; set; }
        public List<antecedntePacienteDTO> antecedentesDelPaciente { get; set; }
        public examenMentalDTO examenMental { get; set; }
        public string perfilSocial { get; set; }
        public string personalidad { get; set; }
        public string datosRelevantesFamiliaPaciente { get; set; }
        public string diagnostico { get; set; }
        public string planOrientacionPsicologica { get; set; }
    }

    public class HistoriaClinicaPsicologicaDTOResponse
    {
        public Int64 idPaciente { get; set; }
        public string motivoDeConsulta { get; set; }
        public string ocupacion { get; set; }
        public string origenProcedencia { get; set; }
        public List<antecedntePacienteDTO> antecedentesDelPaciente { get; set; }
        public examenMentalDTO examenMental { get; set; }
        public string perfilSocial { get; set; }
        public string personalidad { get; set; }
        public string datosRelevantesFamiliaPaciente { get; set; }
        public string diagnostico { get; set; }
        public DateTime fechaDeRegistro { get; set; }
        public string planOrientacionPsicologica { get; set; }
        public pacienteDTO paciente { get; set; }
    }

    public class antecedntePacienteDTO
    {
        public string descripcion { get; set; }
    }

    public class examenMentalDTO
    {
        public string aparecienciaGeneral { get; set; }
        public string estadoConciencia { get; set; }
        public string estadoAnimo { get; set; }
        public string activiadMotora { get; set; }
        public string asociacionIdeasYLenguaje { get; set; }
        public string sensorium { get; set; }
        public string memoria { get; set; }
        public string pensamiento { get; set; }
        public string resultadoExamen { get; set; }
    }
}
