using System;


namespace Polymorphism_Assignment
{
    // Define an interface 
    public interface IQuittable
    {
        // Define a void method
        void Quit();
    }
    
    // Define a class that implements the interface created above
    public class Employee : IQuittable
    {
        // Implement the Quit method from the interface
        public void Quit()
        {
            // Print a message to the console
            Console.WriteLine("The employee has quit.");
        }
    }
}