
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Citas
    {
        [Key]
        public Int64 IdCita { get; set; }
        public Int64 dPaciente { get; set; }
        public Int64 IdTerapia { get; set; }
        public Int64 idEstado { get; set; }
        public int edad { get; set; }
        public string NoOrden { get; set; }
        public DateTime fechaCita { get; set; }
        public DateTime fechaAsignacion { get; set; }
        public string AsignadoPor { get; set; }
        //relaciones
        public Paciente paciente { get; set; }
        public Terapias Terapia { get; set; }
        public EstadoCitas estadoCita { get; set; }
    }
}
