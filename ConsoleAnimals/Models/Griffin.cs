namespace ConsoleAnimals.Models
{
    public class Griffin : Animal
    {
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
