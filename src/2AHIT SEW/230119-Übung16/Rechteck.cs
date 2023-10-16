using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230119_Übung16
{
    class Rechteck
    {
        public double len;
        public double with;

        public Rechteck()
        {
            this.len = 0;
            this.with = 0;
        }
        public Rechteck(double a, double b)
        {
            this.len = a;
            this.with = b;
        }
        public double GetArea()
        {
            double area;

            area = len * with;

            return area;
        }

        public double GetCircumference()
        {
            double circumference;

            circumference = (2 * len) +( 2 * with);

            return circumference;
        }
    }
}
