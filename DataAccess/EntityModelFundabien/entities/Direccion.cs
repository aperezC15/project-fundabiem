
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class Direccion
    {
        [Key]
        public double idDireccion { get; set; }
        public string descripcion { get; set; }
        public double idMunicipio { get; set; }

        public Municipio municipio { get; set; }
    }
}
