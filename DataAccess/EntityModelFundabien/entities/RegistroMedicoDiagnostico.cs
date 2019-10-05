using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class RegistroMedicoDiagnostico
    {
        public double idRegistroMedicoDiagnostico { get; set; }
        public double idRegistroMedico { get; set; }
        public string diagnosticoFinal { get; set; }
        public string recomendaciones { get; set; }

        public RegistroMedico registroMedico { get; set; }
    }
}
