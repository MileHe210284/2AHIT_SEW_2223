using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230513_Übung_26a_Fortbewegungsmittel
{
    class Landfahrzeug:Fortbewegungsmittel
    {
        public Landfahrzeug() { }
        public Landfahrzeug(double distanceDriven)
        {
            DistanceDriven = distanceDriven;
        }
        public double DistanceDriven { get; set; }
        
   

        public void getPowerUsage()
        {

        }
    }
}
