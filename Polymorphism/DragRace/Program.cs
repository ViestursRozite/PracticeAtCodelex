using System;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 , in the 3rdtimes iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
        {
            CarClass[] cars = 
            { 
                new Mazda(6, 4), 
                new Audi(8, 6), 
                new Bmw(8, 6), 
                new Lada(4, 4), 
                new Lexus(6, 8), 
                new Tesla(9, 9) 
            };

            foreach (var car in cars)
            {
                car.StartEngine();
            }

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    car.SpeedUp();
                    car.SpeedUp();

                    if ((car is IBoost boost) && (i == 2))
                    {
                        boost.UseNitrousOxideEngine();
                    }

                    Console.WriteLine(car.ShowCurrentSpeed());
                }
            }

            CarClass fastestCar = null;
            int speed = 0;
            foreach (var car in cars)
            {
                if(int.Parse(car.ShowCurrentSpeed()) > speed)
                {
                    fastestCar = car;
                    speed = int.Parse(car.ShowCurrentSpeed());
                }
                Console.WriteLine(car.CarType() + " speed: " + car.ShowCurrentSpeed());
            }
            Console.WriteLine($"Fastest car: {fastestCar.CarType()}, with a speed of {fastestCar.ShowCurrentSpeed()}");

            Console.ReadKey();
        }
    }
}