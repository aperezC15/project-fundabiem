using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class Departamento
    {
        [Key]
        public double idDepartamento { get; set; }
        public string nombre { get; set; }
        public double idPais { get; set; }

        public Pais pais { get; set; }
        public IList<Municipio> municipios { get; set; }
    }
}
