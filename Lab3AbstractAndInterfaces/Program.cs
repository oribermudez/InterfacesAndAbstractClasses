using Lab3AbstractAndInterfaces.Classes;
using Lab3AbstractAndInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3AbstractAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ------------------- Dog -------------------

            Console.Write("Please input your dog's name: ");
            string dogName = Console.ReadLine();
            Console.Write("Please input your dog's color: ");
            string dogColor = Console.ReadLine();
            Console.Write("Please input your dog's age: ");
            string dogAge = Console.ReadLine();

            Dog dog = new Dog();
            dog.Name = dogName;
            dog.Color = dogColor;
            dog.Age = int.Parse(dogAge);

            Console.WriteLine("Dog properties: ");
            Console.WriteLine("Name: " + dog.Name);
            Console.WriteLine("Color: " + dog.Color);
            Console.WriteLine("Age: " + dog.Age);

            // ------------------- Cat -------------------

            Console.Write("Please input your cat's name: ");
            string catName = Console.ReadLine();
            Console.Write("Please input your cat's color: ");
            string catColor = Console.ReadLine();
            Console.Write("Please input your cat's age: ");
            string catAge = Console.ReadLine();

            Cat cat = new Cat();
            cat.Name = catName;
            cat.Color = catColor;
            cat.Age = int.Parse(catAge);

            Console.WriteLine("Cat properties: ");
            Console.WriteLine("Name: " + cat.Name);
            Console.WriteLine("Color: " + cat.Color);
            Console.WriteLine("Age: " + cat.Age);

            // ------------------- Interface Dog -------------------

            Console.Write("Please input your dog's name: ");
            string dogTwoName = Console.ReadLine();
            Console.Write("Please input your dog's color: ");
            string dogTwoColor = Console.ReadLine();
            Console.Write("Please input your dog's age: ");
            string dogTwoAge = Console.ReadLine();
            Console.Write("Please input your dog's height: ");
            string dogTwoHeight = Console.ReadLine();

            IAnimal dogTwo = new Dog2();
            dogTwo.Name = dogTwoName;
            dogTwo.Color = dogTwoColor;
            dogTwo.Age = int.Parse(dogTwoAge);
            dogTwo.Height = double.Parse(dogTwoHeight);

            Console.WriteLine("Dog properties: ");
            Console.WriteLine("Name: " + dogTwo.Name);
            Console.WriteLine("Color: " + dogTwo.Color);
            Console.WriteLine("Age: " + dogTwo.Age);
            Console.WriteLine("Height: " + dogTwo.Height);

            // ------------------- Interface Cat -------------------

            Console.Write("Please input your cat's name: ");
            string catTwoName = Console.ReadLine();
            Console.Write("Please input your cat's color: ");
            string catTwoColor = Console.ReadLine();
            Console.Write("Please input your cat's age: ");
            string catTwoAge = Console.ReadLine();
            Console.Write("Please input your cat's height: ");
            string catTwoHeight = Console.ReadLine();

            IAnimal catTwo = new Cat2();
            catTwo.Name = catTwoName;
            catTwo.Color = catTwoColor;
            catTwo.Age = int.Parse(catTwoAge);
            catTwo.Height = double.Parse(catTwoHeight);

            Console.WriteLine("Cat properties: ");
            Console.WriteLine("Name: " + catTwo.Name);
            Console.WriteLine("Color: " + catTwo.Color);
            Console.WriteLine("Age: " + catTwo.Age);
            Console.WriteLine("Height: " + catTwo.Height);
        }
    }
}
