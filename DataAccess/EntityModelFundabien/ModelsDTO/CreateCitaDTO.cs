using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class CreateCitaDTO
    {
        public Int64 dPaciente { get; set; }
        public Int64 IdTerapia { get; set; }
        //public Int64 idEstado { get; set; }
        //public int edad { get; set; }
        public string NoOrden { get; set; }
        public DateTime fechaCita { get; set; }
       // public DateTime fechaAsignacion { get; set; }
        public string AsignadoPor { get; set; }
    }

    public class citaDTO
    {
       public Int64 IdCita { get; set; }
        public Int64 dPaciente { get; set; }
        public Int64 IdTerapia { get; set; }
        public Int64 idEstado { get; set; }
        public int edad { get; set; }
        public string NoOrden { get; set; }
        public DateTime fechaCita { get; set; }
        public DateTime fechaAsignacion { get; set; }
        public string AsignadoPor { get; set; }
    }
}
