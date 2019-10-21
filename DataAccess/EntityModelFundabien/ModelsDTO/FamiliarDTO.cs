using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class FamiliarDTO
    {
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public bool sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string grupoEtnico { get; set; }
        public string escolaridad { get; set; }
        public string religion { get; set; }
        public bool isManager { get; set; }
        public string parentezco { get; set; }
    }
}
