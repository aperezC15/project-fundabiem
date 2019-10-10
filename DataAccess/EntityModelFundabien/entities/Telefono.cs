using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Telefono
    {
        [Key]
        public Int64 idTelefono { get; set; }
        public Int64 idPersona { get; set; }
        public string telefono { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool estaHabilitado { get; set; }
        
        public Persona persona { get; set; }
    }
}
