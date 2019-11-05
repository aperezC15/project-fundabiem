using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundabiemAPI.clssResponses
{
    public class clsResponse<T> 
    { 
        public bool Error { get; set; }
        public List<T> RegistrosFundabiem { get; set; }
        public int pages { get; set; }
        public int totalRows { get; set; }
    }
}
