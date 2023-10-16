using System;

namespace _220922_Verbrauch
{
    class Program
    {
        static void Main(string[] args)
        {
            string ein1, ein2;
            double gas, km, middle;
            bool ok1, ok2;

            Console.WriteLine("bitte geben sie die gefahrene strecke ein");
            ein1 = Console.ReadLine();
            Console.WriteLine("bitte geben sie die den verbrauch an ");
            ein2 = Console.ReadLine();


            ok1 = Double.TryParse(ein1, out km);
            ok2 = Double.TryParse(ein2, out gas);

            middle = (gas * 100) / km;
            if (ok1 && ok2)
            {
                Console.WriteLine("der mittlere verbrauch ist : {0} l/km", middle);
            }
            else
            {
                Console.WriteLine("Ungültige eingabe");
            }
        }
    }
}