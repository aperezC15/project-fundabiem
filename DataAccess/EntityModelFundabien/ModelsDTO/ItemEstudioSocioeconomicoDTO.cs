using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class ItemEstudioSocioeconomicoDTO
    {
        public long Id { get; set; }
        public string nombre { get; set; }
        public ICollection<OpcionItemEstudioSocioeconomicoDTO> opciones { get; set; }
    }
}
