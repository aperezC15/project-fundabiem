using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class createPacienteDTO
    {
        public Int64 historialClinico { get; set; }
        public Int64 idPersona { get; set; }
        public bool estaActivo { get; set; }
    }
}
