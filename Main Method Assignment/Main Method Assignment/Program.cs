using System;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MainMethods2 - class
            MainMethods2 math1 = new MainMethods2();
            // Call the first method with an int parameter
            Console.WriteLine(math1.MathOp(10));
            // Call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(10.5m));
            // Call the third method with a string parameter
            Console.WriteLine(math1.MathOp("10"));
        }
    }
}
