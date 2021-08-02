using System;

namespace FuelConsumptionCalculator
{
    public class FuelGauge
    {
        public int fuel;
        Car thisFuelsCar;

        public FuelGauge(int fuel, Car carInstance)
        {
            this.fuel = fuel;
            this.thisFuelsCar = carInstance;//fuel can effect car and itself trough car (thisFuelsCar.thisCarsFuel)
        }

        public int Fuel
        {
            get { return fuel; }    
            set 
            {
                if (value == 1 && fuel < 70)
                {
                    fuel += value;
                }
                else if (value == -1 && fuel >= 1)
                {
                    fuel += value;
                }
                else
                {
                    fuel += 0;
                    Console.WriteLine("Sploosh- the fuel hits the ground");
                }
            }
        }

        public void Report()
        {
            Console.WriteLine($"Fuel level: {Fuel}");
        }

        public void FuelUp()
        {
            Fuel = 1;
        }

        public void FuelDown()
        {
            if(fuel >= 1) fuel--;
        }

    }
}
