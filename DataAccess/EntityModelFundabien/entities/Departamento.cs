using System.Collections.Generic;

namespace EntityModelFundabien.entities
{
    public class Departamento
    {
        public int idDepartameto { get; set; }
        public string nombre { get; set; }

        public IList<Municipio> municipios { get; set; }
    }
}
