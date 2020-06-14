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
    }
}