using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Anamnesis
    {
        [Key]
        public Int64 idAnamnesis { get; set; }
        [Required]
        public Int64 idHistoriaClinica { get; set; }
        [Required]
        public Int64 idItemAnamnesis { get; set; }
        [Required]
        [MaxLength(1000, ErrorMessage = "El campo 'diagnostico' de 'Anamnesis' no debe exceder 1000 caracteres.")]
        public string diagnostico { get; set; }

        public HistoriaClinica historiaClinica { get; set; }
        public ItemAnamnesis item { get; set; }
    }
}
