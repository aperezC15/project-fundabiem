using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class DetalleTratamiento
    {
        [Key]
        public Int64 idDetalleTratamiento { get; set; }
        public Int64 idTratamiento { get; set; }
        public string descripcion { get; set; }
        public string duracion { get; set; }

        public Tratamiento tratamiento { get; set; }
    }
}
