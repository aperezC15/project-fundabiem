using EntityModelFundabien.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class CreateRegistroMedicoDTO
    {
        public CreatePersonaDTO paciente { get; set; }
        public int HistorialClinico { get; set; }
        public DireccionDTO direccionPaciente { get; set; }
        public IList<FamiliarDTO> familiaresPaciente { get; set; }
        public DireccionDTO direccionEncargado { get; set; }
    }
}
