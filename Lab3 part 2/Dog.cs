using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3_part_2
{
    class Dog : IAnimal
    {
        public Dog(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }

        public string Name { get; set ; }
        public string Colour { get ; set ; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
        public string Cry()
        {
            return "Woof!";
        }
    }
    
}
