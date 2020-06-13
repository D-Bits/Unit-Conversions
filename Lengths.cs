using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConversions
{
    public class Lengths
    {
        public static double FeettoMeters(int feet)
        {
            double meters = feet / 3.2808;

            return Math.Round(meters, 2);
        }

        public static double MeterstoFeet(int meters)
        {
            double feet = meters * 3.2808;

            return Math.Round(feet, 2);
        }

        public static double MilestoKilos(int miles)
        {
            double kilos = miles / 0.62137;

            return Math.Round(kilos, 2);
        }

        public static double KilostoMiles(int kilos)
        {
            double miles = kilos * 0.62137;

            return Math.Round(miles, 2);
        }

        // Present the user w/ their choices, and prompt them to make a selection
        public static void LengthChoices()
        {
            // Define user options in a dictionary
            Dictionary<int, string> userOptions = new Dictionary<int, string>();

            userOptions.Add(1, "Feet to Meters.");
            userOptions.Add(2, "Meters to Feet.");
            userOptions.Add(3, "Miles to Kilos.");
            userOptions.Add(4, "Kilos to Miles.");

            // Blank line for readability
            Console.WriteLine();

            foreach (var keyval in userOptions)
            {
                Console.WriteLine(keyval);
            }

            Console.WriteLine();

            Console.Write("Please enter an int based on the options above: ");
            // Prompt the the user to enter a choice
            int userChoice = Convert.ToInt32(Console.ReadLine());
            

            if (userChoice == 1)
            {
               Console.Write("Enter a number of feet to convert to meters: "); 
               int userFeet = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine($"{userFeet} feet equals {Lengths.MeterstoFeet(userFeet)} meters.");
            }
            else if (userChoice == 2)
            {
                Console.Write("Enter a number of meters to convert to feet: "); 
                int userMeters = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{userMeters} meter(s) equals {Lengths.MeterstoFeet(userMeters)} feet.");
            }
        }
    }
}
