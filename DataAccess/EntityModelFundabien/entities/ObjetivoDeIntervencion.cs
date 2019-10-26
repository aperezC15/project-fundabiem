using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class ObjetivoDeIntervencion
    {
        [Key]
        public Int64 idObjetivo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
