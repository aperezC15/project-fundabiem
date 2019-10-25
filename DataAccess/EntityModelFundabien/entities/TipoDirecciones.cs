using System;
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class TipoDirecciones
    {
        [Key]
        public Int64 Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'Descripcion' de 'TipoDirecciones' no debe exceder 100 caracteres.")]
        public string  Descripcion { get; set; }
    }
}
