using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class documenti:scaffale

    {
         public string codice { get;set; }
         public string titolo { get; set; }
         public DateTime anno { get; set; }
         public string settore { get; set; }        
         public string stato { get; set; }  
        
    }
}
