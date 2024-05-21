using System;
using System.Collections.Generic;

namespace DesicionMaker
{
    internal class Program
    {
        static List<string> InputDecisions()
        {
            Console.WriteLine("Desicion Maker\n");
            Console.Write("Enter comma-separated options to decide between: ");
            string tempOptionsInput = Console.ReadLine();
            List<string> tempOptions = new List<string>(tempOptionsInput.Split(','));   // Temporary list of options from the user

            for (int i = 0; i < tempOptions.Count; i++)     // Trim whitespaces from the list
            {
                tempOptions[i] = tempOptions[i].Trim();
            }

            return tempOptions;
        }

        static void DesicionMaking()
        {
            List<string> options = InputDecisions();

            for (int i = 0; i < options.Count; i++)     // DEBUG: Write the contents of the options list
            {
                Console.WriteLine(options[i]);
            }

            if (options.Count < 2)      // Make sure there are at least two options in the list
            {
                Console.WriteLine("You must enter at least two options!");
                return;
            }

            while (options.Count > 1)
            {

            }
        }

        static void Main(string[] args)
        {
            DesicionMaking();
        }
    }
}
