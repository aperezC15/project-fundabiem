using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Persona
    {
        public double idPersona { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public bool sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string grupoEtnico { get; set; }
        public Direccion domicilio { get; set; }
        public Direccion residencia { get; set; }
        public string escolaridad { get; set; }
        public string religion { get; set; }
    }
}
