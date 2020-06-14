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

            return Math.Round(meters, 4);
        }

        public static double MeterstoFeet(int meters)
        {
            double feet = meters * 3.2808;

            return Math.Round(feet, 4);
        }

        public static double MilestoKilos(int miles)
        {
            double kilos = miles / 0.62137;

            return Math.Round(kilos, 4);
        }

        public static double KilostoMiles(int kilos)
        {
            double miles = kilos * 0.62137;

            return Math.Round(miles, 4);
        }

        // Present the user w/ their choices, and prompt them to make a selection
        public static void LengthChoices()
        {
            // Define user options in a dictionary
            Dictionary<int, string> userOptions = new Dictionary<int, string>();

            userOptions.Add(0, "Main Menu.");
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
            
            if (userChoice == 0)
            {
                Program.Main(null);
            }
            else if (userChoice == 1)
            {
               Console.Write("Enter a number of feet to convert to meters: "); 
               int userFeet = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine($"{userFeet} feet equals {Lengths.FeettoMeters(userFeet)} meters.");
               Program.Main(null);
            }
            else if (userChoice == 2)
            {
                Console.Write("Enter a number of meters to convert to feet: "); 
                int userMeters = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{userMeters} meter(s) equals {Lengths.MeterstoFeet(userMeters)} feet.");
                Program.Main(null);
            }
            else if (userChoice == 3)
            {
                Console.Write("Enter a number of miles to convert to kilometers: "); 
                int userMiles = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{userMiles} mile(s) equals {Lengths.MilestoKilos(userMiles)} kilometers.");
                Program.Main(null);
            }
            else if (userChoice == 4)
            {
                Console.Write("Enter a number of kilometers to convert to miles: ");
                int userKilos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{userKilos} kilometers(s) equals {Lengths.MilestoKilos(userKilos)} mile(s).");
                Program.Main(null);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid int.");
                Lengths.LengthChoices();
            }
        }
    }
}
