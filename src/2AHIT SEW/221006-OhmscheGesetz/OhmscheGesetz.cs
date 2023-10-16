using System;

namespace _221006_OhmscheGesetz
{
    class OhmscheGesetz
    {
        static void Main(string[] args)
        {

            string choice, ein2, ein3;
            double U, I, R;
            bool ok1, ok2;

            Console.WriteLine("what do you need? (U); (I); (R);");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "U":
                    Console.WriteLine("the formula is : U=R*I");
                    Console.WriteLine("please enter R");
                    ein2 = Console.ReadLine();
                    Console.WriteLine("please enter I");
                    ein3 = Console.ReadLine();

                    ok1 = Double.TryParse(ein2, out R);
                    ok2 = Double.TryParse(ein3, out I);


                    if (ok1 && ok2)
                    {
                        U = R * I;
                        Console.WriteLine("U= " + U + "V");
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }


                    break;


                case "I":
                    Console.WriteLine("the formula is : I= U/R");
                    Console.WriteLine("please enter U");
                    ein2 = Console.ReadLine();
                    Console.WriteLine("please enter R");
                    ein3 = Console.ReadLine();

                    ok1 = Double.TryParse(ein2, out U);
                    ok2 = Double.TryParse(ein3, out R);


                    if (ok1 && ok2)
                    {
                        I = U / R;

                        Console.WriteLine("I= " + I + "Ohm");
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                    break;


                case "R":

                    Console.WriteLine("the formula is : R = U*I");
                    Console.WriteLine("please enter U");
                    ein2 = Console.ReadLine();
                    Console.WriteLine("please enter I");
                    ein3 = Console.ReadLine();

                    ok1 = Double.TryParse(ein2, out U);
                    ok2 = Double.TryParse(ein3, out I);


                    if (ok1 && ok2)
                    {
                        R = U * I;

                        Console.WriteLine("R= " + R + "A");
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }

                    break;
            }
        }


        
    }
}
