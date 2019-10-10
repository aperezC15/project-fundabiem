using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class DetalleFormularioAnamnesis
    {
        [Key]
        public Int64 idDetalleFormulario { get; set; }
        public Int64 idFormularioAnamnesis { get; set; }
        public Int64 idItemAnamnesis { get; set; }
        public bool esItemActivo { get; set; }

        public FormularioAnamnesis formulario { get; set; }
        public ItemAnamnesis item { get; set; }
    }
}
