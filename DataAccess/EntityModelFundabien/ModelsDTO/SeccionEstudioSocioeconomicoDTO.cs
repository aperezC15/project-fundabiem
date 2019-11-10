using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.ModelsDTO
{
    public class SeccionEstudioSocioeconomicoDTO
    {
        public long Id { get; set; }
        public string nombre { get; set; }
        public IEnumerable<ItemEstudioSocioeconomicoDTO> items { get; set; }
    }
}
