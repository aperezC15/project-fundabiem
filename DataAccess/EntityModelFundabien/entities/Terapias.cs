using IdentityServer.dbContext;
using IdentityServer.dbContext.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Terapias
    {
        [Key]
        public Int64 IdTerapia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string  Encargado { get; set; }
        
    }
}
