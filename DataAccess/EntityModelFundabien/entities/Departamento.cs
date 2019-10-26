using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class Departamento
    {
        [Key]
        public Int64 idDepartamento { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'nombre' de 'Departamento' no debe exceder 100 caracteres.")]
        public string nombre { get; set; }
        [Required]
        public Int64 idPais { get; set; }

        public Pais pais { get; set; }
        public IList<Municipio> municipios { get; set; }
    }
}
