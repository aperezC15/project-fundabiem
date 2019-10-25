using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class CrearHistoriaClinicaDTO
    {
        public Int64 idPaciente { get; set; }
        public string motivoConsulta { get; set; }
        public string diagnosticoFinal { get; set; }
        public IList<CrearAnamnesisDTO> anamnesis { get; set; }
    }
}
