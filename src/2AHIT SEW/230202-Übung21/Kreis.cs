using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230202_Übung21
{
    class Kreis
    {
        public double radius; // Radius --> public
        public double xm;
        public double ym;
        public readonly double density;
        public double d;

        public Kreis()
        {
            this.radius = 0;
            this.xm = 0;
            this.ym = 0;
            this.d = 0;
        }
        public Kreis(double r)
        {
            this.radius = r;
            this.density = d;
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
        public double Radius()
        {
            return -radius;
        }
        public double Mass()
        {
            double mass, area;
            area = GetArea();
            mass = area * d;
            return mass;
        }
    }
}
