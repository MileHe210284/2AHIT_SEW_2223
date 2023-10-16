using System;

namespace Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            double surface, volumen, radius, height;
            string ein1, ein2;
            bool ok1, ok2;

            Console.WriteLine("Please enter the radius of the zylinder");
            ein1 = Console.ReadLine();
            Console.WriteLine("Please enter the height of the zylinder");
            ein2 = Console.ReadLine();

            ok1 = Double.TryParse(ein1, out radius);
            ok2 = Double.TryParse(ein2, out height);

            volumen = Math.PI * Math.Pow(radius, 2) * height;

            surface = 2 * Math.PI * Math.Pow(radius, 2) + 2 * radius * height * Math.PI;

            if (ok1 && ok2)
            {
                Console.WriteLine("the volumen of the zylinder is: {0}, and the surface is: {1}", volumen, surface);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}