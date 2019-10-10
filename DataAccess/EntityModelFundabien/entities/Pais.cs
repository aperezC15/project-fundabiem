﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class Pais
    {
        [Key]
        public Int64 idPais { get; set; }
        public string nombre { get; set; }
        public List<Departamento> departamentos { get; set; }
    }
}
