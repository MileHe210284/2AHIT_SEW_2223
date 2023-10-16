using System;

namespace _220922_ZahlenSumme
{
    class Program
    {

        static void Main(string[] args)
        {
            string eingabe1, eingabe2;
            double zahl1, zahl2, summe;
            bool isOk1, isOk2;

            Console.WriteLine("zahlenaddition");
            Console.Write("geben sie zahl 1 ein:");
            eingabe1 = Console.ReadLine();
            Console.Write("geben sie Zahl2 ein: ");
            eingabe2 = Console.ReadLine();

            //umwandlung von Strings
            // zahl1= Convert.TokjDouble(eingabe1);
            //zahl2= Convert.ToDouble(eingabe2);

            //umwandlung von string in double mit fehlerprüfung
            //rückgabewert true oder falso
            //ggf. weitere fehlerbehandlung
            isOk1 = Double.TryParse(eingabe1, out zahl1);
            isOk2 = double.TryParse(eingabe2, out zahl2);

            if (isOk1 == true && isOk2 == true)
            {
                summe = zahl1 + zahl2;
                Console.WriteLine("summe {0} + {1} = {2}", zahl1, zahl2, summe);
            }
            else
            {
                Console.WriteLine("fehlerhafte eingabe!");
            }
            Console.ReadKey();
        }

    }
}