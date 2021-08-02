using System;

namespace FuelConsumptionCalculator
{

    class Program2
    {
        private static void Main(string[] args)
        {
            Car car1 = new Car(0);//make a car
            Odometer odo1 = new Odometer(0, car1);//Make odometer for car
            FuelGauge fuel1 = new FuelGauge(50, car1);// Make fuelGauge for car 50 l
            car1.ThisCarsOdometer = odo1;// Let car know it has an Odometer
            car1.ThisCarsFuel = fuel1;//Let car know it has a FuelGauge

            for (int i = 0; i < 510; i++)//Drive for 500 
            {
                car1.Drive();
                car1.ThisCarsFuel.Report();
                car1.ThisCarsOdometer.Report();
            }

            for (int i = 0; i < 75; i++)//Pour 5 l too many in car
            {
                car1.ThisCarsFuel.FuelUp();
                car1.ThisCarsFuel.Report();
            }

            Console.WriteLine("\ndone");

            Console.ReadKey();
        }
    }
}
