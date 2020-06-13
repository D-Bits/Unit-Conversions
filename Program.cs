using System;
using System.Collections.Generic;

namespace UnitConversions
{
    class Program
    {
        static void UserOptions()
        {
            // Define user options in a dictionary
            Dictionary<int, string> userOptions = new Dictionary<int, string>();

            userOptions.Add(1, "Feet to Meters.");
            userOptions.Add(2, "Meters to Feet.");
            userOptions.Add(3, "Miles to Kilos.");
            userOptions.Add(4, "Kilos to Miles.");

            // Blank line for readability
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Lengths.LengthChoices();
        }
    }
}
