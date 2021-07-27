namespace FuelConsumptionCalculator
{
    public class Car
    {
        double Odometer; // distance
        double StartKilometers; // Starting odometer reading
        double EndKilometers; // Ending odometer reading
        double Liters; // Liters of gas used between the readings

        public Car(double startOdo = 0, double endingOdo = 0, double liters = 0)
        {
            this.StartKilometers = startOdo;
            this.EndKilometers = endingOdo;
            this.Liters = liters;
            this.Odometer = endingOdo - startOdo;
        }
        public Car(double startOdo)
        {
            this.Odometer = startOdo;
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
