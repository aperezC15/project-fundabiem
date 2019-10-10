using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class Municipio
    {
        [Key]
        public Int64 idMunicipio { get; set; }
        public string nombre { get; set; }
        public Int64 idDepartamento { get; set; }

        public IList<Direccion> direcciones { get; set; }
        public Departamento departamento { get; }
    }
}
