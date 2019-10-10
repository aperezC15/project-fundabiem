using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class Departamento
    {
        [Key]
        public Int64 idDepartamento { get; set; }
        public string nombre { get; set; }
        public Int64 idPais { get; set; }

        public Pais pais { get; set; }
        public IList<Municipio> municipios { get; set; }
    }
}
