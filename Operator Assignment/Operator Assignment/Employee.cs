using System;

namespace Operator_Assignment
{
    // Create a class - Employee
    public class Employee
    {
        // Define properties for Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the '==' operator
        public static bool operator ==(Employee e1, Employee e2)
        {
            // check if two Employee objects are equal by comparing their Id
            return e1.Id == e2.Id;
        }

        // Overload the '!=' operator
        public static bool operator !=(Employee e1, Employee e2)
        {          
            // Check if two Employee objects are not equal by comparing their Id
            return e1.Id != e2.Id;
        }
    }
}