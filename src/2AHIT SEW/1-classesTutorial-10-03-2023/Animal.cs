using System;
using System.Collections.Generic;
using System.Text;

namespace _1_classesTutorial_10_03_2023
{
    class Animal
    {
        private double height;
        private int age;

        public Animal() { }
        public Animal(double height, int age)
        {
            this.height = height;
            this.age = age;
        }
        public double Height 
        {
            get { return height; }
            set { height = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string eat(string food)
        {
            return "eating..."+food;
        }

    }
}
