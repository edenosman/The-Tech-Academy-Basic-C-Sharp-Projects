using System;

namespace Operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with the same Id
            Employee employee1 = new Employee { Id = 1, FirstName = "Eden", LastName = "Osman" };
            Employee employee2 = new Employee { Id = 1, FirstName = "Johnny", LastName = "Bravo" };

            // Use the overloaded '==' operator to check if the two employees are equal
            Console.WriteLine(employee1 == employee2);

            // Create another Employee object with a different Id
            Employee employee3 = new Employee { Id = 2, FirstName = "Joe", LastName = "Cena" };

            // Use the overloaded '!=' operator to check if two employees are equal
            Console.WriteLine(employee1 != employee3);
        }
    }
}