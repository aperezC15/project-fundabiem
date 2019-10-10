using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class FormularioAnamnesis
    {
        [Key]
        public Int64 idFormularioAnamnesis { get; set; }
        public string idPersonal { get; set; }
        
        public Personal personal { get; set; }
        public IList<DetalleFormularioAnamnesis> detalle { get; set; }
    }
}
