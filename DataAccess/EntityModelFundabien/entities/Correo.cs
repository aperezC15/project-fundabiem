using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Correo
    {
        public double idPersona { get; set; }
        public string  correo { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool estaHabilitado { get; set; }

        public Persona persona { get; set; }
    }
}
