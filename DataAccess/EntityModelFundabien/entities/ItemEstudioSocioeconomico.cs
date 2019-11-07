using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class ItemEstudioSocioeconomico
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public long idSeccionEstudioSocioeconomico { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'nombre' de 'ItemEstudioSocioeconomico' no debe exceder 100 caracteres.")]
        public string nombre { get; set; }
        [MaxLength(255, ErrorMessage = "El campo 'descripcion' de 'ItemEstudioSocioeconomico' no debe exceder 255 caracteres.")]
        public string descripcion { get; set; }

        public SeccionEstudioSocioeconomico seccion { get; set; }
    }
}
