using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{

    /*
     * Its responsibilities are as follows:
 - To know the car’s current amount of fuel, in liters. done
 - To report the car’s current amount of fuel, in liters. done
 - To be able to increment the amount of fuel by 1 liter.
 This simulates putting fuel in the car. ( The car can hold a maximum of 70 liters.)
 - To be able to decrement the amount of fuel by 1 liter,
 if the amount of fuel is greater than 0 liters. This simulates burning fuel as the car runs.
     */
    class FuelGauge
    {
        public int fuel;

        public FuelGauge(int fuel)
        {
            this.fuel = fuel;
        }

        public int Fuel//know the car’s current amount of fuel, in liters
        {
            get { return fuel; }    
            set 
            {
                if (value <= 70 && fuel < value) fuel = value;//can only add fuel if it makes sense
                else fuel = fuel; 
            }
        }

        public void Report()
        {
            Console.WriteLine($"Fuel level: {Fuel}");
        }

        public void FuelUp()
        {
            fuel++;
        }

        public void FuelDown()
        {
            if(fuel >= 1) fuel--;
        }

    }
}
