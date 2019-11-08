using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class EvolucionTecnica
    {
        [Key]
        public Int64 idEvolucionTecnica { get; set; }
        public Int64 idPaciente { get; set; }
        public string diagnostico { get; set; }
        public DateTime fecha { get; set; }
        public Paciente paciente { get; set; }
    }
}
