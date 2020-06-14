using System;
using System.Collections.Generic;

namespace UnitConversions
{
    public class Program
    {
        static void UserOptions()
        {
            // Define user options in a dictionary
            Dictionary<int, string> userOptions = new Dictionary<int, string>();

            userOptions.Add(1, "Length Conversions.");
            userOptions.Add(2, "Mass Conversions.");

            // Blank line for readability
            Console.WriteLine();

            foreach (var keyval in userOptions)
            {
                Console.WriteLine(keyval);
            }

            // Blank line for readability
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            UserOptions();

            Console.Write("Please enter an int based on the options above: ");
            // Prompt the the user to enter a choice
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {
                Lengths.LengthChoices();
            }
            else if (userChoice == 2)
            {
                Mass.MassChoices();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid int.");
                UserOptions();
            }
        }
    }
}
