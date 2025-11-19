namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            ParameterDemo demo = new ParameterDemo();

            int value = 20;
            Console.WriteLine("Before Increase: " + value);
            demo.Increase(ref value);
            Console.WriteLine("After Increase: " + value);

            demo.GetFullName(out string fullName);
            Console.WriteLine("Full Name: " + fullName);
            int total = demo.SumAll(5, 10, 15, 20);
            Console.WriteLine("Sum of all numbers: " + total);

            Console.ReadLine();
        }
    }
}