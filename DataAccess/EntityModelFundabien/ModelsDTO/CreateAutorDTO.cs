using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.Models
{
    public class CreateAutorDTO
    {
        [Required]
        public string nombre { get; set; }
    }
}
