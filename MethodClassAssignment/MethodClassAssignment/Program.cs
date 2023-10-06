using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MyClass
            MyClass myClassInstance = new MyClass();
            // Call the MyMethod in the MyClass, passing in two numbers
            myClassInstance.MyMethod(5, 10);
            // Call the MyMethod in the MyClass, specifying the parameters by name
            myClassInstance.MyMethod(num1: 20, num2: 30);
        }
    }
}