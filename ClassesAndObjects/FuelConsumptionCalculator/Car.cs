using System;
namespace FuelConsumptionCalculator
{
    public class Car
    {
        double Odometer; // distance
        double StartKilometers; // Starting odometer reading
        double EndKilometers; // Ending odometer reading
        double Liters; // Liters of gas used between the readings

        private int consumption = 10;//for linked Fuel - Odometer class pair
        Odometer thisCarsOdometer;
        FuelGauge thisCarsFuel;


        public Car(double startOdo = 0, double endingOdo = 0, double liters = 0)
        {
            this.StartKilometers = startOdo;
            this.EndKilometers = endingOdo;
            this.Liters = liters;
            this.Odometer = endingOdo - startOdo;

        }
        public Car(double odometer)
        {
            this.Odometer = odometer;
        }

        public FuelGauge ThisCarsFuel
        {
          get
            {
                return this.thisCarsFuel;
            }
          set
            {
                this.thisCarsFuel = value;
            }

        }

        public Odometer ThisCarsOdometer
        { get
            {
                return this.thisCarsOdometer;
            }
          set
            {
                this.thisCarsOdometer = value;
            } 
        }


        //public bool IsTimeToLowerFuel
        //{get; set;}

        //public int InformationPasser 
        //{
        //    get { return informationPasser; }
        //    set { informationPasser = value; }
        //}

        public void Drive()
        {
            if(thisCarsFuel.fuel > 0 )
            {
                thisCarsOdometer.KmCounter = 1;//+1 from Odometers perspective
                if (thisCarsOdometer.KmCounter % consumption == 0)
                {
                    thisCarsOdometer.KmCounter = 0;//Reset to 0 From Odometers perspective
                    thisCarsFuel.FuelDown();
                }
                thisCarsOdometer.Incriment();
                Console.WriteLine("Wroom");
            }
            else
            {
                Console.WriteLine("No fuel...");
            }

        }


        public double CalculateConsumption()
        {
            return Liters / Odometer;
        }

        private double ConsumptionPer100Km()
        {
            return CalculateConsumption() * 100;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            this.Odometer = mileage;
            this.Liters = liters;
        }
    }
}
