using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230530_Übung_26b
{
    class Luftfahrzeug:Fortbewegungsmittel
    {
        public Luftfahrzeug() { }
        public Luftfahrzeug(double maxOperatingHeight, double minOperatingHeight, double distanceFlown)
        {
            MinOperatingHeight = minOperatingHeight;
            MaxOperatingHeight = maxOperatingHeight;
            DistanceFlown = distanceFlown;
        }

        public double MaxOperatingHeight { get; set; }
        public double MinOperatingHeight { get; set; }
        public double DistanceFlown { get; set; }

        public void land()
        {

        }
        public void takeOff() 
        {
        
        }
    }
}
