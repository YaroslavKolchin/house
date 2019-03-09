using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public interface IPart
    {
        int countPart { get; set; }
        double price { get; set; }
        string partName { get; set; }
        int order { get; set; }
       
    }
}
