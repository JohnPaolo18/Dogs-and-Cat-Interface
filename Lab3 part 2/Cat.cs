using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_part_2
{
    class Cat : IAnimal
    {
        public Cat(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }

        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
        public string Cry()
        {
            return "Meow!";
        }
    }
}
