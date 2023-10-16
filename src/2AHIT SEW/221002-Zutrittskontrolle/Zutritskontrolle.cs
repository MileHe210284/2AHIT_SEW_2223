using System;

namespace _221002_Zutrittskontrolle
{
    class Program
    {
        static void Main(string[] args)
        {
                string password = "oof";
                string compare;
                int i = 3;

                    do
                    {
                        Console.WriteLine("geben sie das passwort ein");
                        compare = Console.ReadLine();
                        if (compare == password)
                        {
                            i = 0;
                            Console.WriteLine("richtiges passwort");
                    
                        }
                        else if (compare != password)
                        {
                            i--;
                            Console.WriteLine(" falsches passwort. verbleibende versuche: {0}", i);
                            if (i == 0)
                            {

                                Console.WriteLine("konto gesperrt ");
                            ;
                            }
                        }
                    } while (i !=0);
        }
    }
}
