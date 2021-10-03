using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program6
    {
        private const int numberSurveyed = 12467;
        private const double purchasedEnergyDrinks = 0.14;
        private const double preferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            Console.WriteLine("Total number of people surveyed " + Program6.numberSurveyed);
             Console.WriteLine("Approximately " + ((int)CalculateEnergyDrinkers()) + " bought at least one energy drink");
             Console.WriteLine(((int)CalculatePreferCitrus()) + " of those " + "prefer citrus flavored energy drinks.");

            Console.ReadKey();
        }

        public static double CalculateEnergyDrinkers()
        {
            return Program6.purchasedEnergyDrinks * Program6.numberSurveyed;
        }

        public static double CalculatePreferCitrus()
        {
            return CalculateEnergyDrinkers() * Program6.preferCitrusDrinks;
        }
    }
}
