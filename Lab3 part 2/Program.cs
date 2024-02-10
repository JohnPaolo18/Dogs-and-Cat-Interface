using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a dog name
            Console.WriteLine("What is your dogs name: ");
            string dogName = Console.ReadLine();

            //create the dog type object
            IAnimal dog = new Dog(dogName, "brown", 5);
            //execute getter and setter method to print the properties
            Console.WriteLine($"Name: {dog.Name}, Colour: {dog.Colour}, Age: {dog.Age}");
           
            dog.Eat();
            Console.WriteLine(dog.Cry());

            //ask the user for a cat name
            Console.WriteLine("What is your cat's name: ");
            string catName = Console.ReadLine();

            //create the cat type object
            IAnimal cat = new Cat(catName, "white", 10);
            Console.WriteLine($"Name: {cat.Name}, Colour: {cat.Colour}, Age: {cat.Age}");
                       
            cat.Eat();
            Console.WriteLine(cat.Cry());

            //Create a list called “animals” and add some animal objects to the list. 
            List<IAnimal> animals = new List<IAnimal>
            {
                dog,
                cat
            };
            Console.WriteLine("The names of all the animals in the list are: ");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
    interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        int Age { get; set; }

        void Eat();
        string Cry();
    }
    
}
