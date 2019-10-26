using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Pais
    {
        [Key]
        public Int64 idPais { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'nombre' de 'Pais' no debe exceder 100 caracteres.")]
        public string nombre { get; set; }
        public List<Departamento> departamentos { get; set; }
    }
}
