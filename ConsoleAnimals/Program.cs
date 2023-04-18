using ConsoleAnimals.Models;
using ConsoleAnimals.Interface;

class Program
{
    static void Main(string[] args)
    {
        Chien dragon = new Chien();
        dragon.ID = 1;
        dragon.Rarity = "Rare";
        dragon.Name = "Ety";

        Chien griffon= new Chien();
        griffon.ID = 2;
        griffon.Rarity = "Epique";
        griffon.Name = "Eva";

        Chien chien = new Chien();
        chien.ID = 3;
        chien.Rarity = "Commun";
        chien.Name = "Toutou";

        Chien Beethoven = new Chien();
        chien.ID = 4;
        chien.Rarity = "Rare";
        chien.Name = "Beethoven";

        IList<Chien> animallist = new List<Chien>() { 
            dragon, griffon, chien, Beethoven
        };

        var result = animallist.Where(item => item.Rarity == "Rare").ToList();

        Console.WriteLine(result);
    }
}