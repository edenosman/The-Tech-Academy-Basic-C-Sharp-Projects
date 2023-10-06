using System;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism to create an object of type IQuittable
            IQuittable quittable = new Employee();
            // Call the Quit method on the IQuittable object
            quittable.Quit();
        }
    }
}
