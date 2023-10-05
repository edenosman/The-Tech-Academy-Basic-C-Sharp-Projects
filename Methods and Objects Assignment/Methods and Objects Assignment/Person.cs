using System;

namespace Methods_and_Objects_Assignment
{
    public class Person
    {
        // Class called Person with data type string properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Give the class a void method called SayName() that takes no parameter and writes the person's full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}
