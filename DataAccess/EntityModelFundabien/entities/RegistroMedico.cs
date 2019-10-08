using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.entities
{
    public class RegistroMedico
    {
        public double idRegistroMedico { get; set; }
        public double idPaciente { get; set; }
        public DateTime fechaAdmision { get; set; }
        public bool estaFirmado { get; set; }

        public Paciente paciente { get; set; }

    }
}
