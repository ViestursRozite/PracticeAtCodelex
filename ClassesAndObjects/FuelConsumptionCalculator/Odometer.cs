using System;

namespace FuelConsumptionCalculator
{
    public class Odometer
    {
        public int mileage;
        private int kmCounter;
        Car thisOdometersCar;

        public Odometer(int mileage, Car carInstance)
        {
            this.kmCounter = 0;
            this.thisOdometersCar = carInstance;

            if (mileage >= 0 || mileage <= 999999) this.mileage = mileage;
            else this.mileage = 0;
        }

        public int Mileage
        { 
            get
            {
                return mileage;
            }
            set
            {
                value = 1;
                value = (mileage + value) % 999999;
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

        public int  KmCounter
        {
            get { return this.kmCounter; } 
            set 
            {
                if(value == 1) this.kmCounter += value;
                else this.kmCounter = 0;
            }  
        }

    }
}
