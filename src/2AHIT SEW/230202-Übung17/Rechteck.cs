using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230202_Übung17
{
    class Rechteck
    {
        public double len;
        public double with;
        public double xm;
        public double ym;

        public Rechteck()
        {
            this.len = 0;
            this.with = 0;
            this.xm = 0;
            this.ym = 0;
        }
        public Rechteck(double a, double b)
        {
            this.len = a;
            this.with = b;
        }
        public Rechteck(double a, double b, double xm, double ym) : this(a, b)
        {
            this.xm = xm;
            this.ym = ym;
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

            circumference = (2 * len) + (2 * with);

            return circumference;
        }

        public double Lenght()
        {
            return -len;
        }
        
        public double Width()
        {
            return -with;
        }

    }
}
