using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3AbstractAndInterfaces.Classes
{
    internal abstract class Animal
    {
        protected string _name;
        protected string _color;
        protected int _age;

        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        public abstract int Age { get; set; }

        public abstract void Eat();
    }
}
