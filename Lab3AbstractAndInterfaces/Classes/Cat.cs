using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3AbstractAndInterfaces.Classes
{
    internal class Cat : Animal
    {
        public override string Name // overriding property
        {
            get => this._name;

            set => this._name = value;
        }

        public override string Color // overriding property
        {
            get => this._color;

            set => this._color = value;
        }

        public override int Age // overriding property
        {
            get => this._age;

            set => this._age = value;
        }

        public Cat() { }
        public override void Eat() => Console.WriteLine("Cats eat mice.");
    }
}

