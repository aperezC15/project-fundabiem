using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class RegistroMedicoDiagnostico
    {
        [Key]
        public Int64 idRegistroMedicoDiagnostico { get; set; }
        public Int64 idRegistroMedico { get; set; }
        public string diagnosticoFinal { get; set; }
        public string recomendaciones { get; set; }

        public RegistroMedico registroMedico { get; set; }
    }
}
