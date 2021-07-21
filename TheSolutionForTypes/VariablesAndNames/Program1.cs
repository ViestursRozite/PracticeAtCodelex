using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars = 100;
            int drivers = 28;
            int passengers = 90;
            int seatsInCar = 4;

            int carpoolCapacity = drivers * seatsInCar;
            int carsDriven = drivers;
            int carsNotDriven = carpoolCapacity - carsDriven;

            //↓↓ avg or at worst max car capacity
            double avgPassagersPerCar = passengers / carsDriven <= carsDriven ? passengers / carsDriven : seatsInCar;


            Console.WriteLine($"There are { cars} cars available.");
            Console.WriteLine($"There are only { drivers} drivers available.");
            Console.WriteLine($"There will be { carsNotDriven} empty cars today.");
            Console.WriteLine($"We can transport { carpoolCapacity} people today.");
            Console.WriteLine($"We have { passengers} to carpool today.");
            Console.WriteLine($"We need to put average of { avgPassagersPerCar} people in each car.");
            Console.ReadKey();
        }
    }
}