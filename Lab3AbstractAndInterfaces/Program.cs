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

            Console.WriteLine("Please input your dog's name");
            string dogName = Console.ReadLine();
            Console.WriteLine("Please input your dog's color");
            string dogColor = Console.ReadLine();
            Console.WriteLine("Please input your dog's age");
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

            Console.WriteLine("Please input your cat's name");
            string catName = Console.ReadLine();
            Console.WriteLine("Please input your cat's color");
            string catColor = Console.ReadLine();
            Console.WriteLine("Please input your cat's age");
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

            Console.WriteLine("Please input your dog's name");
            string iDogName = Console.ReadLine();
            Console.WriteLine("Please input your dog's color");
            string iDogColor = Console.ReadLine();
            Console.WriteLine("Please input your dog's age");
            string iDogAge = Console.ReadLine();
            Console.WriteLine("Please input your dog's height");
            string iDogHeight = Console.ReadLine();

            IAnimal iDog = new iDog();
            iDog.Name = iDogName;
            iDog.Color = iDogColor;
            iDog.Age = int.Parse(iDogAge);
            iDog.Height = double.Parse(iDogHeight);

            Console.WriteLine("Dog properties: ");
            Console.WriteLine("Name: " + iDog.Name);
            Console.WriteLine("Color: " + iDog.Color);
            Console.WriteLine("Age: " + iDog.Age);
            Console.WriteLine("Height: " + iDog.Height);

            // ------------------- Interface Cat -------------------

            Console.WriteLine("Please input your cat's name");
            string iCatName = Console.ReadLine();
            Console.WriteLine("Please input your cat's color");
            string iCatColor = Console.ReadLine();
            Console.WriteLine("Please input your cat's age");
            string iCatAge = Console.ReadLine();
            Console.WriteLine("Please input your cat's height");
            string iCatHeight = Console.ReadLine();

            IAnimal iCat = new iCat();
            iCat.Name = iCatName;
            iCat.Color = iCatColor;
            iCat.Age = int.Parse(iCatAge);
            iCat.Height = double.Parse(iCatHeight);

            Console.WriteLine("Cat properties: ");
            Console.WriteLine("Name: " + iCat.Name);
            Console.WriteLine("Color: " + iCat.Color);
            Console.WriteLine("Age: " + iCat.Age);
            Console.WriteLine("Height: " + iCat.Height);
        }
    }
}
