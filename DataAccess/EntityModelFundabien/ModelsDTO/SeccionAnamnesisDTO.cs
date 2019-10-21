using System;
using System.Collections.Generic;

namespace EntityModelFundabien.ModelsDTO
{
    public class SeccionAnamnesisDTO
    {
        public Int64 idSeccionAnamnesis { get; set; }
        public string nombre { get; set; }
        public IEnumerable<ItemAnamnesisDTO> itemsAnamnesis { get; set; }
    }
}
