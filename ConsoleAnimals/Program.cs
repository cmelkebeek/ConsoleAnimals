using ConsoleAnimals.Models;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();

        //Bdd animal = new Bdd();

        string result;

        do
        {
            Console.WriteLine("Veuillez choisir un type d'animal (Aigle, Chien, Dragon, Griffin)");
            result = Console.ReadLine();
        } while (result.ToLower() != "aigle" || result.ToLower() != "chien" || result.ToLower() != "dragon" || result.ToLower() != "griffin");

        


        // program.InsertData(animal);

        program.RecupData();
    }


    public void InsertData(Bdd bdd)
    {
        
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Cours;User ID=Admin;Integrated Security=True;");

        conn.Open();

        string query = $"INSERT INTO Animals (Type, Name, Rarity) VALUES ('{bdd.Type}', '{bdd.Name}', '{bdd.Rarity}')";//{chien.GetType}

        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();

        conn.Close();
    }

    public void RecupData()
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Cours;User ID=Admin;Integrated Security=True;");

        conn.Open();

        string query = "SELECT * FROM Animals";

        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            Console.WriteLine("ID : " + dataReader["ID"].ToString());
            Console.WriteLine("Type : " + dataReader["Type"].ToString());
            Console.WriteLine("Name : " + dataReader["Name"].ToString());
            Console.WriteLine("Rarity : " + dataReader["Rarity"].ToString());
            Console.WriteLine("-----------------------------------");

        }

        conn.Close();
    }
}