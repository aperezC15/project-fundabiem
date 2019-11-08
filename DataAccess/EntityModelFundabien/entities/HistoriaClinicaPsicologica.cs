using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class HistoriaClinicaPsicologica
    {
        [Key]
        public Int64 idHistoriaclinicaPsicologica { get; set; }
        public Int64 idPaciente { get; set; }
        public string motivoDeConsulta { get; set; }
        public List<antecedentesPaciente> antecedentesDelPaciente { get; set; }
        public string perfilSocial { get; set; }
        public string personalidad { get; set; }
        public string examenMental { get; set; }
        public string datosRelevantesFamiliaPaciente { get; set; }
        public string diagnostico { get; set; }
        public string planOrientacionPsicologica { get; set; }
        public Paciente paciente { get; set; }
    }

    public class antecedentesPaciente{
        public Int64 idAntecedente { get; set; }
        public Int64 idHistoriaClinicaPsicologica { get; set; }
        public string descripcion { get; set; }
        public HistoriaClinicaPsicologica HistoriaClinicaPsicologica { get; set; }
    }

    public class examenMental {
        [Key]
        public Int64 idExamenMental { get;set;}
        public Int64 idHistoriaClinicaPsicologica { get; set; }
        public string aparecienciaGeneral { get; set; }
        public string estadoConciencia { get; set; }
        public string estadoAnimo { get; set; }
        public string activiadMotora { get; set; }
        public string asociacionIdeasYLenguaje { get; set; }
        public string sensorium { get; set; }
        public string memoria { get; set; }
        public string pensamiento { get; set; }
        public string resultadoExamen { get; set; }
        public HistoriaClinicaPsicologica HistoriaClinicaPsicologica { get; set; }
    }
}
