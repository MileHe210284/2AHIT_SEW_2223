using System;

namespace _221011_Ratespiel
{
    class Ratespiel
    {
        static void Main(string[] args)
        {
            int i = 0;
            string ein1;
            bool ok1;
            int number;
            int random = RandomNumber();

            do
            {
                Console.WriteLine("give your {0}. guess: ", i);
                ein1 = Console.ReadLine();
                ok1 =int.TryParse(ein1, out number);
                    if (number > random)
                    {
                    i++;
                        Console.WriteLine("You guesset too high");
                    }
                    else if (number < random)
                    {
                    i++;
                        Console.WriteLine("You guesset too low");
                    }
            }while (number!=random) ;

                Console.WriteLine("you did it on your {0}. guess", i);
            
        }
        public static int RandomNumber(int min=1, int max=100)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


    }
}
