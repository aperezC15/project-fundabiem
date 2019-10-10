using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class SeccionAnamnesis
    {
        [Key]
        public Int64 idSeccionAnamnesis { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public IList<ItemAnamnesis> itemsAnamnesis { get; set; }
    }
}
