using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class ItemAnamnesis
    {
        [Key]
        public Int64 idItemAnamnesis { get; set; }
        [Required]
        public Int64 idSeccionAnamnesis { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'nombre' de 'ItemAnamnesis' no debe exceder 100 caracteres.")]
        public string nombre { get; set; }
        [MaxLength(255, ErrorMessage = "El campo 'descripcion' de 'ItemAnamnesis' no debe exceder 255 caracteres.")]
        public string descripcion { get; set; }

        public SeccionAnamnesis seccion { get; set; }
    }
}
