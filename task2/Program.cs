namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calc = new Calculator();

            calc.PrintWelcome();

            int sum = calc.Add(9, 6);
            Console.WriteLine("Addition Result: " + sum);


            int product1 = calc.Multiply(7, 5);
            Console.WriteLine("Multiplication Result (7 * 5): " + product1);

            int product2 = calc.Multiply(12);
            Console.WriteLine("Multiplication Result (2 * default): " + product2);

            Console.ReadLine();
        }
    }
}