namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating first student1
            Student s1 = new Student();
            s1.name = "Mukunda";
            s1.age = 21;
            s1.course = "Backend Development";

            // Creating second student1
            Student s2 = new Student();
            s2.name = "Bipul";
            s2.age = 95;
            s2.course = "React";

            // Displaying values for student1
            Console.WriteLine("Student 1 Details");
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("Age: " + s1.age);
            Console.WriteLine("Course: " + s1.course);

            // Display values for student2
            Console.WriteLine("\nStudent 2 Details");
            Console.WriteLine("Name: " + s2.name);
            Console.WriteLine("Age: " + s2.age);
            Console.WriteLine("Course: " + s2.course);

            Console.WriteLine("\nCollege Name (Static Field): " + Student.collegeName);

            Console.ReadLine();
        }
    }

}