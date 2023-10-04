using System;
using System.Collections.Generic;

namespace ConsoleApp_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Array
            string[] carArray = { "Audi", "BMW", "Volkswagen", "Mercedes-Benz", "Toyota", "Renault", "Volvo", "Tesla" };
            // Ask the user to select a number
            Console.WriteLine("Select a number between 0 and 7:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Great! Your favorite car model is " + carArray[stringSelect]);
                    validString = true;
                }
                // Message to display if the index selected doesn't exist
                catch
                {
                    Console.WriteLine("Oops, that number selection is invalid. Please select a number between 0 and 7:");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Integer Array
            int[] intArray = { 5, 8, 28, 23, 19, 25, 9, 10, 100, 1000 };
            // Ask the user to select a number
            Console.WriteLine("\nSelect a number between 0 and 9:");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    Console.WriteLine("You selected number: " + intArray[intSelect]);
                    validInt = true;
                }
                // Message displayed if the user selects and index that doesn't exist
                catch
                {
                    Console.WriteLine("Oops! the number selected is invalid. Please select a number between 0 and 9:");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // String List
            List<string> TennisPlayersList = new List<string>()
            {   "Roger Federer",
                "Rafael Nadal",
                "Novak Djokovic",
                "Andy Murray",
                "Stan Wawrinka",
                "Pete Sampras",
                "Andre Agassi",
                "Boris Becker",
                "Bjorn Borg",
                "John McEnroe"
            };
            // Ask the user to select a number
            Console.WriteLine("Select another number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your favorite tennis player is " + TennisPlayersList[listSelect]);
                    validList = true;
                }
                // Message to display if the number doesn't exist
                catch
                {
                    Console.WriteLine("Oops! The number selected is invalid. Please select a number between 0 and 9:");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
