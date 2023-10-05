using System;

namespace Abstract_Class_Assignment
{
    // Create another class - Employee - and have it inherit from the Person class
    public class Employee : Person
    {
        public int Id { get; set; }
        // Implement the SayName() method inside the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}