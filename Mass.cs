using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConversions
{
    public class Mass
    {
        public static double PoundstoKilos(int pounds)
        {
            double kilos = pounds / 2.2046;

            return Math.Round(kilos, 4);
        }

        public static double KilostoPounds(int kilos)
        {
            double miles = kilos * 2.2046;
            
            return Math.Round(miles, 4);
        }

        public static double OuncestoGrams(int ounces)
        {
            double grams = ounces / 0.035274;

            return Math.Round(grams, 4);
        }

        public static double GramstoOunces(int grams)
        {
            double ounces = grams * 0.035274;

            return Math.Round(ounces, 4);
        }

        public static void MassChoices()
        {
            // Define user options in a dictionary
            Dictionary<int, string> userOptions = new Dictionary<int, string>();

            userOptions.Add(0, "Main Menu.");
            userOptions.Add(1, "Pounds to Kilograms.");
            userOptions.Add(2, "Kilograms to Pounds.");
            userOptions.Add(3, "Ounces to Grams.");
            userOptions.Add(4, "Grams to Ounces.");

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
                Console.Write("Enter a number of pounds to convert to kilograms: "); 
                int userLbs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{userLbs} feet equals {Mass.PoundstoKilos(userLbs)} meters.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid int.");
                Mass.MassChoices();
            }
        }
    }
}