using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimals.Models
{
    public abstract class Animal
    {
        public string Name { get; private set; }

        public int ID { get; set; }

        public string Rarity { get; set; }

        public Animal() { }

        public Animal(string name) { Name = name; }
        public virtual void Move()
        {
            Console.WriteLine("Move");
        }

        public virtual void Sleep() { Console.WriteLine("Sleep"); }
    }


}
