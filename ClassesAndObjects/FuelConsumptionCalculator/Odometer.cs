using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    public class Odometer
    {
        /*
         The Odometer Class: This class will simulate the car’s odometer. Its responsibilities are as follows:

 - To know the car’s current mileage. done
 - To report the car’s current mileage. done
 - To be able to increment the current mileage by 1 kilometer.
 The maximum mileage the odometer can store is 999,999 kilometer. 
 When this amount is exceeded, the odometer resets the current mileage to 0.
 - To be able to work with a FuelGauge object.
 It should decrease the FuelGauge object’s current amount of fuel by 1 
 liter for every 10 kilometers traveled. (The car’s fuel economy is 10 kilometers per liter.)
         */

        public int mileage;
        private int kmCounter;
        private int consumption = 10;
        FuelGauge fuelGauge;

        public Odometer(int mileage, int fuelLevel = 0)
        {
            this.fuelGauge = new FuelGauge(fuelLevel);
            this.kmCounter = 0;

            if (mileage >= 0 || mileage <= 999999) this.mileage = mileage;
            else this.mileage = 0;
        }

        public Odometer(int mileage)
        {
            if (mileage >= 0 || mileage <= 999999) this.mileage = mileage;
            else this.mileage = 0;
        }

        public int Mileage
        {   get
            {
                return mileage;
            }
            set
            {
                kmCounter++;
                if(kmCounter % consumption == 0)
                {
                    kmCounter = 0;
                    fuelGauge.FuelDown();
                }

                value = 1;
                value =(mileage + value )% 999999;
                mileage = value;
            }
        }

        public void Report()
        {
            Console.WriteLine($"Odometer reading: {Mileage}");
        }

        public void Incriment()
        {
            Mileage++;
        }

    }
}
