using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230207_Übung22b_Computer
{
    class MathOperations
    {
        public double A;
        public double B;
        public double Number;
        public const double PI = 3.14519;
        public const double E = 2.71828;

        public MathOperations()
        {
            this.A = 0;
            this.B = 0;
            this.Number = 0;

        }

        public MathOperations(double a, double b, double number)
        {
            this.A = a;
            this.B = b;
            this.Number = number;

        }
        public double Add()
        {
            double sum;

            sum = A + B;

            return sum;
        }
        public double Devide()
        {
            double dev;

            dev = A / B;

            return dev;
        }

        public double Multiply()
        {
            double multi;

            multi = A * B;

            return multi;
        }
        public double Subtract()
        {
            double sub;

            sub = A - B;

            return sub;
        }
        public double Abs(double zahl)
        {
            double betrag;

            betrag = zahl * -1;

            return betrag;
        }
        public double Signum(double zahl)
        {
            double signum;

            return signum;
        }
    }
}
