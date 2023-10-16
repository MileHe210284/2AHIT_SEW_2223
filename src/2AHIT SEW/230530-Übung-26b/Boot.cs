using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230530_Übung_26b
{
    class Boot:Wasserfahrzeug
    {
        public Boot() { }
        public Boot(bool hasSails, double maxKnots, double minKnots)
        {
            HasSails = hasSails;
            MaxKnots = maxKnots;
            MinKnots = minKnots;
            HasEngine = true;
        }

        public bool HasSails { get; set; }
        public double MaxKnots { get; set; }
        public double MinKnots { get; set; }
       
        
    }
}
