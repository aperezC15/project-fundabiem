using System;
using System.ComponentModel.DataAnnotations;

namespace EntityModelFundabien.entities
{
    public class TipoDirecciones
    {
        [Key]
        public Int64 Id { get; set; }
        public string  Descripcion { get; set; }
    }
}
