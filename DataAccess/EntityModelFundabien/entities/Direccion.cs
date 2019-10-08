
namespace EntityModelFundabien.entities
{
    public class Direccion
    {
        public double idPersona { get; set; }
        public int idMunicipio { get; set; }
        public string direccion { get; set; }

        public Persona persona { get; set; }
        public Municipio municipio { get; set; }
    }
}
