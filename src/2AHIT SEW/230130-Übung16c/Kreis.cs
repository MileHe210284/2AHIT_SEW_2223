using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230130_Übung16c
{
    class Kreis
    {
        public double radius; // Radius --> public
        public double xm;
        public double ym;


        public Kreis()
        {
            this.radius = 0;
            this.xm = 0;
            this.ym = 0;
        }
        public Kreis(double r)
        {
            this.radius = r;
           
        }
        public Kreis(double r, double ym, double xm) : this(r)
        {
            this.xm = xm;
            this.ym = ym;
        }
        public double GetArea()
        {
            double area;

            area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

        public double GetCircumference()
        {
            double circumference;

            circumference = 2 * Math.PI * radius;

            return circumference;
        }
        
    }
}
