using ConsoleAnimals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimals.Models
{
    public class Dragon : Animal, IPilotage, IFly
    {

        public void Voler()
        {
            Console.WriteLine("L'animal vol");
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            Console.WriteLine("Le dragon bouge");
        }

        public new void Sleep()
        {
            Console.WriteLine("Le dragon dort");
        }


    }
}
