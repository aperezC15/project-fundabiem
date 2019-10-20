using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityModelFundabien.entities
{
    public class Direccion
    {
        [Key]
        public Int64 idDireccion { get; set; }
        public string descripcion { get; set; }
        public Int64 idMunicipio { get; set; }
        public Municipio municipio { get; set; }
        //relacion a la tabla persona
        public Int64 idPersona { get; set; }
        [ForeignKey("idPersona")]
        public Persona persona { get; set; }
        //relacion a la tabla tipoDirecciones
        public Int64 idTipoDireccion { get; set; }
        [ForeignKey("idTipoDireccion")] 
        public TipoDirecciones tipoDirecciones { get; set; }
    }
}
