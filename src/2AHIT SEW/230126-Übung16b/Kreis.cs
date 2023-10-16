using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230126_Übung16b
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
        public Kreis(double r, double y,double x)
        {
            this.radius = r;
            this.ym = y;
            this.xm = x;
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

            circumference = 2* Math.PI * radius;

            return circumference;
        }
        public double Mittelpunkt()
        {
            double mittel;


            return mittel;
        }
    }
}
