using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Persona
    {
        [Key]
        public Int64 idPersona { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public bool sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string grupoEtnico { get; set; }
        
        public string escolaridad { get; set; }
        public string religion { get; set; }

        public Int64 idDomicilio { get; set; }
        [ForeignKey("idDomicilio")]
        public Direccion domicilio { get; set; }

        public Int64 idResidencia { get; set; }
        [ForeignKey("idResidencia")]
        public Direccion residencia { get; set; }
    }
}
