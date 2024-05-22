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

            while (options.Count > 1)
            {
                List<string> nextRound = new List<string>();    // A new list with the chosen options

                for (int i = 0; i < options.Count; i += 2)
                {
                    if (i + 1 < options.Count)
                    {
                        string option1 = options[i];
                        string option2 = options[i + 1];

                        Console.WriteLine($"Choose between:\n1.{option1}\n2.{option2}");
                        Console.Write("Enter 1 or 2: ");
                        string choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            nextRound.Add(option1);
                        }
                        else if (choice == "2")
                        {
                            nextRound.Add(option2);
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please enter 1 or 2");
                            i -= 2;     // Move the counter back one pair
                        }
                    }
                    else
                    {
                        // If there is one choice left at bottom of the list, automatically add that to the next round
                        nextRound.Add(options[i]);
                    }
                }

                options = nextRound;
            }

            Console.WriteLine($"\nBest option: {options[0]}");
        }

        static void Main(string[] args)
        {
            DesicionMaking();
        }
    }
}
