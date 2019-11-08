using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class EvolucionTecnicaDTO
    {
        public Int64 idEvolucionTecnica { get; set; }
        public Int64 idPaciente { get; set; }
        public string diagnostico { get; set; }
        public DateTime fecha { get; set; }
        public pacienteDTO paciente { get; set; }
    }

    public class CreateEvolucionTecnicaDTO
    {
        public Int64 idPaciente { get; set; }
        public string diagnostico { get; set; }
    }
}
