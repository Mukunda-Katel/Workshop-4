namespace Task6
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks obtained: ");
            string inputMarks = Console.ReadLine();

            Console.Write("Enter total marks: ");
            string inputTotal = Console.ReadLine();

            int marks;
            int total;

            bool isMarksValid = int.TryParse(inputMarks, out marks);
            bool isTotalValid = int.TryParse(inputTotal, out total);

            if (!isMarksValid || !isTotalValid)
            {
                Console.WriteLine("Invalid input. Please enter integer values.");
                return;
            }
            double percentage = (double)marks / total * 100;

            Console.WriteLine("Percentage: " + percentage);
            Console.ReadLine();
        }
    }
}