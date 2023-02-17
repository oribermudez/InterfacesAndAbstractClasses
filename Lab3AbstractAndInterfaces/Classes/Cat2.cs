using Lab3AbstractAndInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3AbstractAndInterfaces.Classes
{
    internal class Cat2 : IAnimal
    {
        // Property implementation:
        public string Name { get; set; }

        public string Color { get; set; }

        public double Height { get; set; }

        public int Age { get; set; }

        // Method implementation

        string IAnimal.Cry() => "Meow!";

        void IAnimal.Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
