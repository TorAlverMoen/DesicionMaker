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

            if (options.Count < 2)      // Make sure there are at least two options in the list
            {
                Console.WriteLine("You must enter at least two options!");
                return;
            }

            string currentChoice = options[0];
            options.RemoveAt(0);

            while (options.Count > 0)
            {
                string nextChoice = options[0];
                options.RemoveAt(0);

                Console.WriteLine($"Choose between:\n1.{currentChoice}\n2.{nextChoice}");
                Console.Write("Enter 1 or 2: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // This choice will continue as options number 1
                }
                else if (choice == "2")
                {
                    currentChoice = nextChoice;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2");
                    options.Insert(0, nextChoice);
                    continue;
                }
            }

            Console.WriteLine($"\nBest option: {currentChoice}");
        }

        static void Main(string[] args)
        {
            DesicionMaking();
        }
    }
}
