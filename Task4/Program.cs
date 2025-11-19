namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Player p1 = new Player();
            p1.playerName = "Bipul Bhandari";
            p1.level = 0;
            p1.health = 0;

            Player p2 = new Player("Mukunda Katel", 5, 100);

            Console.WriteLine("\nPlayer 1 (Default Constructor)");
            Console.WriteLine("Name: " + p1.playerName);
            Console.WriteLine("Level: " + p1.level);
            Console.WriteLine("Health: " + p1.health);

            Console.WriteLine("\nPlayer 2 (Parameterized Constructor)");
            Console.WriteLine("Name: " + p2.playerName);
            Console.WriteLine("Level: " + p2.level);
            Console.WriteLine("Health: " + p2.health);

            Console.ReadLine();
        }
    }
}