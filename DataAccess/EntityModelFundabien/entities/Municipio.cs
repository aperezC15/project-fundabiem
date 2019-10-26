using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class Municipio
    {
        [Key]
        public Int64 idMunicipio { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'nombre' de 'Municipio' no debe exceder 100 caracteres.")]
        public string nombre { get; set; }
        [Required]
        public Int64 idDepartamento { get; set; }

        public IList<Direccion> direcciones { get; set; }
        public Departamento departamento { get; }
    }
}
