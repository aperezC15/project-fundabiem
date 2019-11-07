using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class SeccionEstudioSocioeconomico
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo 'nombre' de 'SeccionEstudioSocioeconomico' no debe exceder de 100 caracteres.")]
        public string nombre { get; set; }
        [MaxLength(255, ErrorMessage = "El campo 'descripcion' de 'SeccionEstudioSocioeconomico' no debe exceder de 255 caracteres")]
        public string descripcion { get; set; }

        public IEnumerable<ItemEstudioSocioeconomico> items { get; set; }
    }
}
