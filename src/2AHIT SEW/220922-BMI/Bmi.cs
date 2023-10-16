using System;

namespace _220922_BMI
{
    class Bmi
    {
        static void Main(string[] args)
        {
            string ein1, ein2, gender;
            double height, weight, bmi, multiplikator;
            bool ok1, ok2;

            Console.WriteLine("please enter your heigh.");
            ein1 = Console.ReadLine();
            Console.WriteLine("please enter your weight");
            ein2 = Console.ReadLine();
            Console.WriteLine("please enter your gender");
            gender = Console.ReadLine();

            ok1 = Double.TryParse(ein1, out height);
            ok2 = Double.TryParse(ein2, out weight);

            bmi = weight / Math.Pow(height, 2);

            if (ok1 == true && ok2 == true)
            {
                bmi = weight / Math.Pow(height, 2);

                if (gender == "m")
                {
                    multiplikator = 0.95;
                }
                else
                {
                    multiplikator = 0.9;
                }

                if (bmi >= 16 && bmi <= 17)
                {
                    Console.Write("untergewicht\n");
                }
                else if (bmi <= 18.5)
                {
                    Console.Write("Leichtes untergewicht\n");
                }
                else if (bmi <= 25 * multiplikator)
                {
                    Console.Write("Normalgewicht\n");
                }
                else if (bmi <= 30)
                {
                    Console.Write("Praeadipositas\n");
                }
                else if (bmi <= 35)
                {
                    Console.Write("Adipositas Grad 1\n");
                }
                else if (bmi <= 40)
                {
                    Console.Write("Adipositas Grad 2\n");
                }
                else if (bmi > 40)
                {
                    Console.Write("Adipositas Grad 3\n");
                }
                else
                {
                    Console.Write("Starkes Untergewicht\n");
                }
                Console.Write("Bmi= {0}", bmi);
            }
            else
            {
                Console.WriteLine("Fehlerhafte eingabe");

            }



        }
    }
}
