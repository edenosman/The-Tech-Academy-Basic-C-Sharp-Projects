using System;

namespace Method_Assignment
{
    class MathOperation1
    {
        // Method that takes two integers as parameters
        // Make one parameter optional (provides a default value)
        public int MathOperation(int a, int b = 1)
        {
            // Perform multiplication on integers and return the result
            int result = a * b;
            return result;
        }
    }
}