using System;
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class Direccion
    {
        [Key]
        public Int64 idDireccion { get; set; }
        public string descripcion { get; set; }
        public Int64 idMunicipio { get; set; }

        public Municipio municipio { get; set; }
    }
}
