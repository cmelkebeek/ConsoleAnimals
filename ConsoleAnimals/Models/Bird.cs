using ConsoleAnimals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimals.Models
{
    public class Bird : Animal, IFly
    {
        public void Voler()
        {
            Console.WriteLine("L'animal vol");
        }
    }
}
