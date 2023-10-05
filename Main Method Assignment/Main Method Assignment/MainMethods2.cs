using System;

namespace Main_Method_Assignment
{
    public class MainMethods2
    {
        // First method - takes an integer
        public int MathOp(int nr)
        {
            return nr + 10;
        }
        // Second method - takes a decimal
        public int MathOp(decimal nr)
        {
            // Convert the decimal to an int to perform math operation
            int newnr = Convert.ToInt32(nr);
            return newnr * 15;
        }
        // Third method - takes a string
        public int MathOp(string nr)
        {
            // Convert the string to an int to perform math operation
            int newnr = Convert.ToInt32(nr);
            return newnr % 5;
        }
    }
}