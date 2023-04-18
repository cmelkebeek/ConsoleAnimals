using ConsoleAnimals.Models;
using ConsoleAnimals.Interface;

class Program
{
    static void Main(string[] args)
    {
        IList<Chien> chiens = new List<Chien>();

        chiens.Add(new Chien()
        {
            Name = "Snow",
        });

        chiens.Add(new Chien()
        {
            Name = "Ety",
        });

        chiens.Add(new Chien()
        {
            Name = "Beethoven",
        });

        chiens.Add(new Chien()
        {
            Name = "Eva",
        });

        chiens.Add(new Chien()
        {
            Name = "Bill",
        });
        IEnumerable<Chien> ListeChiens = 
            from chien in chiens
            where chien.Name != "Snow"
            select chien;

        foreach (Chien chien1 in ListeChiens)
        {
            Console.WriteLine(chien1.Name);
        }

        foreach (Chien item in chiens)
        {
            if (item.Name != "Snow") { Console.WriteLine(item.Name); }
        }
    }
}