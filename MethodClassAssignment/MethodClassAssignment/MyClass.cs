using System;

namespace MethodClassAssignment
{
    // Create a new class
    public class MyClass
    {
        // Create a void method (MyMethod) that takes 2 integers as parameters
        public void MyMethod(int num1, int num2)
        {
            // Perform a math op on the first int
            num1 += 1;
            // Display the second int to the screen
            Console.WriteLine("The second number is " + num2);
        }
    }
}