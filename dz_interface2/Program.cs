using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Dog : IAnimalIEnergy
    {
        int energy = 0;
        public void eat()
        {
            energy += 85;
            Console.WriteLine("Dog eats");
        }

        public void walk()
        {
            energy += 60;
            Console.WriteLine("dog walked");
        }
    }

    class Cat : IAnimalIEnergy
    {
        int energy;
        public void eat()
        {
            energy += 75;
            Console.WriteLine("cat eats");
        }
        public void walk()
        {
            energy += 47;
            Console.WriteLine("ct walked");
        }
    }

    class Giraffe : IAnimalIEnergy
    {
        int energy;

        public void eat()
        {
            energy += 95;
            Console.WriteLine("giraffe eat");
        }
        public void walk()
        {
            energy += 87;
            Console.WriteLine("giraffe walked");
        }
    }

    interface IAnimalIEnergy
    {
        void walk();
        void eat();
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
