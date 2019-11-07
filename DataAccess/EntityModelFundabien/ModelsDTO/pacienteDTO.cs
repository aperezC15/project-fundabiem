using EntityModelFundabien.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class pacienteDTO
    {
        public Int64 idPaciente { get; set; }
        
        public Int64 historialClinico { get; set; }
        
        public Int64 idPersona { get; set; }
        
        public bool estaActivo { get; set; }

        public Persona persona { get; set; }
    }
}
