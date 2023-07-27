using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string packageWeight = Console.ReadLine();
            int weight = Convert.ToInt32(packageWeight);

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                string packageWidth = Console.ReadLine();
                int width = Convert.ToInt32(packageWidth);

                Console.WriteLine("Please enter the package height:");
                string packageHeight = Console.ReadLine();
                int height = Convert.ToInt32(packageHeight);

                Console.WriteLine("Please enter the package length:");
                string packageLength = Console.ReadLine();
                int length = Convert.ToInt32(packageLength);

                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int dimensions = height * width * length;
                    int packagedimensionsAndweight = dimensions * weight;
                    int quote = packagedimensionsAndweight / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ". Thank you!");
                }
                Console.ReadLine();
            }
            
        }
    }
}
