using System;

namespace _1_classesTutorial_10_03_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 40;
            Animal cat = new Animal(height, 2);

            Console.WriteLine(cat.Height);
            Console.WriteLine(cat.Age);


            cat.Age = 4;
            cat.Height = 50;

            Console.WriteLine(cat.Height);
            Console.WriteLine(cat.Age);

            string food = "vegan meat";

            Console.WriteLine(cat.eat(food)); 


            
        }
    }
}
