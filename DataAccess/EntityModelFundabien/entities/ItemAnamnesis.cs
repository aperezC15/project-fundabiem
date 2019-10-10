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
        public Int64 idSeccionAnamnesis { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public SeccionAnamnesis seccion { get; set; }
    }
}
