using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Model
{
    class Basement : IPart
    {
        public int countPart { get; set; }
        public double price { get; set; }
        public string partName { get; set; }
        public int order { get; set; }
    }
}
