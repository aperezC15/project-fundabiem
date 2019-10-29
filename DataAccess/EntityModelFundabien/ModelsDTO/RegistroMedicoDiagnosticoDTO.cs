using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class RegistroMedicoDiagnosticoDTO
    {
        public Int64 idRegistroMedico { get; set; }
        public string diagnosticoFinal { get; set; }
        public string recomendaciones { get; set; }
    }
}
