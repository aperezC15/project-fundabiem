using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class EstadoCitas
    {
        [Key]
        public Int64 idEstado { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
