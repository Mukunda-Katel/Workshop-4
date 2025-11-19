namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a day: ");
            string day = Console.ReadLine().Trim().ToLower();

            DayType dayType;

            if (day == "friday" || day == "saturday")
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine($"It is: {dayType}");

            Book b1 = new Book("The Ram Katha", "Abhi Sharma", 9000.80);

            Book b2 = b1 with { title = "Ramayan", price = 500.00 };

            Console.WriteLine("\nFirst Book:");
            Console.WriteLine($"Title: {b1.title}, Author: {b1.author}, Price: {b1.price}");



            var (title, author, price) = b2;

            Console.WriteLine("\nSecond Book (Deconstructed):");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");

            Console.ReadLine();
        }
    }
}