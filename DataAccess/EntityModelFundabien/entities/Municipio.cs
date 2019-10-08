
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class Municipio
    {
        [Key]
        public double idMunicipio { get; set; }
        public string nombre { get; set; }
        public double idDepartamento { get; set; }

        public IList<Direccion> direcciones { get; set; }
        public Departamento departamento { get; }
    }
}
