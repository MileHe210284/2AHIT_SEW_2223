using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230530_Übung_26b
{
    class Flugzeug:Luftfahrzeug
    {
        
        public Flugzeug(double wingSpan) 
        {
            WingSpan = wingSpan;
            HasEngine = true;
           
        }
        public Flugzeug() { }

        public double WingSpan { get; set; }
    }
}
