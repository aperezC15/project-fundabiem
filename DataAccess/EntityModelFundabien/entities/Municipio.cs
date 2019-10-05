
using System.Collections.Generic;

namespace EntityModelFundabien.entities
{
    public class Municipio
    {
        public int idMunicipio { get; set; }
        public string nombre { get; set; }
        public int idDepartamento { get; set; }

        public IList<Direccion> direcciones { get; set; }
        public Departamento departamento { get; }
    }
}
