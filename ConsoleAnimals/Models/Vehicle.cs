using ConsoleAnimals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimals.Models
{
    public class Vehicle : IPilotage
    {
        public void Move()
        {
            Console.WriteLine("Le véhicule bouge");
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
