using System;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MathOperation1 class
            MathOperation1 mathOp = new MathOperation1();
            // Ask the user to enter first parameter
            Console.WriteLine("Please enter an integer: ");
            int nr1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter a second parameter or press enter
            Console.WriteLine("Please enter a second parameter or just press enter: ");
            try
            {
                // Call method with 2 parameters if both parameters are provided
                int nr2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.MathOperation(nr1, nr2);
                Console.WriteLine(nr1 + " * " + nr2 + " = " + results);
            }
            catch
            {
                // Call method with one parameter if only one is provided
                int results = mathOp.MathOperation(nr1);
                Console.WriteLine(nr1 + " * 1 = " + results);
            }
            Console.ReadLine();
        }
    }
}
