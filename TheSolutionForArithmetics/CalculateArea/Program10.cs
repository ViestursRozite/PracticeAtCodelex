using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program10
    {
        static void Main(string[] args)
        {
            int choice; // The user's menu choice

            do
            {
                // Get the user's menu choice.
                choice = getMenu();

                if (choice == 1)
                {
                    Console.WriteLine(": Area of a Circle");
                    calculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.WriteLine(": Area of a Rectangle");
                    calculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.WriteLine(": Area of a Triangle");
                    calculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int getMenu()
        {//              Display the menu.
            Console.WriteLine("Geometry Calculator\n" + 
                "1. Calculate the Area of a Circle\n" +
                "2. Calculate the Area of a Rectangle\n" +
                "3. Calculate the Area of a Triangle\n" +
                "4. Quit\n" +
                "Enter your choice (1-4) : ");
            
            int userChoice;
            do
            {
                int.TryParse(Console
                .ReadKey()
                .KeyChar
                .ToString()
                , out userChoice);

                if (userChoice < 1 || userChoice > 4)
                {
                    Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                }

            }while (userChoice < 1 || userChoice > 4) ;

            return userChoice;
        }

        private static decimal makeTheUserInputANum(string parameterName, string shapeWeAreCalculating)
        {
            int randomExample = new Random().Next(11, 101);//make a random num as example

            Console.WriteLine($"what is the {parameterName} of your {shapeWeAreCalculating}? \n" +// Instruct user
                "example:\n" +
                $"{randomExample}\n" +
                $"enter {parameterName}: ");

            return Decimal.Parse(Console.ReadLine());//(String input) → (decimal), then return
        }

        public static void calculateCircleArea()
        {
            decimal radius = makeTheUserInputANum("radius", "circle");
            Console.WriteLine($"The circle's area is {Geometry.areaOfCircle(radius)}");
        }

        public static void calculateRectangleArea()
        {    
            decimal length = makeTheUserInputANum("length", "rectangle");
            decimal width = makeTheUserInputANum("width", "rectangle");
            Console.WriteLine($"The rectangle's area is : {Geometry.areaOfRectangle(length, width)}");
        }

        public static void calculateTriangleArea()
        {
            decimal ground = makeTheUserInputANum("ground", "triangle");
            decimal height = makeTheUserInputANum("height", "triangle");
            Console.WriteLine($"The triangle's area is {Geometry.areaOfRectangle(ground, height)}");
        }
    }
}
