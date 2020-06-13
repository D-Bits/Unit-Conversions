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
    }
}
