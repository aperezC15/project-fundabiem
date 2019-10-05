using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Autor
    {
        public int AutorId { get; set; }
        [Required]
        public string nombre { get; set; }
    }
}
