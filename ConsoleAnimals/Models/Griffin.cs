using ConsoleAnimals.Interface;

namespace ConsoleAnimals.Models
{
    public class Griffin : Animal, IFly
    {

        public void Voler()
        {
            Console.WriteLine("L'animal vol");
        }
        public override void Move()
        {
            Console.WriteLine("Le Griffon bouge");
        }

        public new void Sleep()
        {
            Console.WriteLine("Le Griffon dort");
        }
    }
}
