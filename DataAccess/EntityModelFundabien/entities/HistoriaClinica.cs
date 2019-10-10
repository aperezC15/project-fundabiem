using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class HistoriaClinica
    {
        [Key]
        public Int64 idHistoriaClinica { get; set; }
        public Int64 idPaciente { get; set; }
        public Int64 idPersonal { get; set; }
        public DateTime fechaDeRegistro { get; set; }
        public string motivoDeConsulta { get; set; }
        public string diagnosticoFinal { get; set; }

        public Paciente paciente { get; set; }
        public Personal personal { get; set; }
        public Tratamiento tratamiento { get; set; }
        public IList<Anamnesis> anamnesis { get; set; }
    }
}
