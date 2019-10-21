using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class FamiliaresPaciente
    {
        public Int64 id { get; set; }
        public Int64 idPersona { get; set; }
        public Int64 idPaciente { get; set; }
        public string parentezco { get; set; }
        public Persona persona { get; set; }
    }
}
