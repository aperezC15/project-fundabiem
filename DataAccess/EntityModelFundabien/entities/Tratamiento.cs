using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Tratamiento
    {
        [Key]
        public Int64 idTratamiento { get; set; }
        public Int64 idHistoriaClinica { get; set; }
        public DateTime fecha { get; set; }

        public HistoriaClinica historiaClinica { get; set; }
        public IList<DetalleTratamiento> detalle { get; set; }
    }
}
