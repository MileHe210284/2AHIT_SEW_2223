using System;

namespace Kreis_Punkt220929
{
    class KreisPunkt
    {
        static void Main(string[] args)
        {
            string ein1, ein2, ein3;
            double radius, px, py;
            bool ok1, ok2, ok3;

            Console.WriteLine("Please enter the value of x");
            ein1 = Console.ReadLine();
            Console.WriteLine("Please enter the value of y");
            ein2 = Console.ReadLine();
            Console.WriteLine("Please enter the radius of your circle");
            ein3 = Console.ReadLine();

            ok1 = Double.TryParse(ein1, out px);
            ok2 = Double.TryParse(ein2, out py);
            ok3 = Double.TryParse(ein3, out radius);



            if (ok1 && ok2 && ok3)
            {
                double distance = Math.Sqrt(Math.Pow(px, 2) * Math.Pow(py, 2));

                if (distance < radius)
                {
                    Console.WriteLine("the point is in the circle");
                }
                else if (distance == radius)
                {
                    Console.WriteLine("the point is on the border of the circle");
                }
                else if (distance > radius)
                {
                    Console.WriteLine("the point is outside of the circle");
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
