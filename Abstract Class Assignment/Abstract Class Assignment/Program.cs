using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee sam = new Employee() { firstName = "Sample", lastName = "Student" };

            // Call the SayName method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}