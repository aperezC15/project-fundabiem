using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityModelFundabien.entities
{
    public class Direccion
    {
        [Key]
        public Int64 idDireccion { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "El campo 'descripcion' de 'Direccion' no debe exceder 255 caracteres.")]
        public string descripcion { get; set; }
        [Required]
        public Int64 idMunicipio { get; set; }
        public Municipio municipio { get; set; }
        //relacion a la tabla persona
        [Required]
        public Int64 idPersona { get; set; }
        [ForeignKey("idPersona")]
        public Persona persona { get; set; }
        //relacion a la tabla tipoDirecciones
        [Required]
        public Int64 idTipoDireccion { get; set; }
        [ForeignKey("idTipoDireccion")] 
        public TipoDirecciones tipoDirecciones { get; set; }
    }
}
