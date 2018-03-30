using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class ResortPrices
    {
        static void Main(string[] args)
        {
            double[] nightlyRates = { 200.00, 180.00, 160.00, 145.00 };
            int[] daysRangeLowLimit = { 1, 3, 5, 8 };
           
            int day;
            double nightlyRate = 0;
            double totalCost = 0;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("      Carefree Resort Reservations      ");
            Console.WriteLine("----------------------------------------");
            Console.Write("How many days would you like to stay? ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            if (day > 0)
            {
                int x = daysRangeLowLimit.Length - 1;
            while (x >=0 && day < daysRangeLowLimit[x])
           
                --x;
            nightlyRate = nightlyRates[x];

                totalCost = nightlyRate * day;

                Console.WriteLine("  {0}     Cost per Day for " + day + " days", nightlyRate.ToString("#,####0.00").PadLeft(10,' '));
                Console.WriteLine("  {0}     Total Cost ", totalCost.ToString("#,####0.00").PadLeft(10, ' '));
                Console.WriteLine("----------------------------------------");
            }
            else
            {
                Console.WriteLine("You must stay for at least 1 day.");
            }

        }
    }
}
