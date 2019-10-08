using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Telefono
    {
        public double idPersona { get; set; }
        public string telefono { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool estaHabilitado { get; set; }
        
        public Persona persona { get; set; }
    }
}
