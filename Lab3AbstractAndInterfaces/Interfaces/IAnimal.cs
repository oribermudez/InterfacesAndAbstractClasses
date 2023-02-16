using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3AbstractAndInterfaces.Interfaces
{
    internal interface IAnimal
    {
        string Name { get; set; }

        string Color { get; set; }

        int Age { get; set; }

        double Height { get; set; }

        void Eat();

        string Cry();

    }
}
