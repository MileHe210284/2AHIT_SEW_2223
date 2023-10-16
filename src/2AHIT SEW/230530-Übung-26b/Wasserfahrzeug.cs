using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230530_Übung_26b
{
    class Wasserfahrzeug:Fortbewegungsmittel
    {
        public Wasserfahrzeug() { }
        public Wasserfahrzeug( double knots)
        {
            Knots = knots;
        }

        public double Knots { get; set; }
    }
}
