using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Anamnesis
    {
        [Key]
        public Int64 idAnamnesis { get; set; }
        public Int64 idHistoriaClinica { get; set; }
        public Int64 idItemAnamnesis { get; set; }
        public string diagnostico { get; set; }

        public HistoriaClinica historiaClinica { get; set; }
        public ItemAnamnesis item { get; set; }
    }
}
