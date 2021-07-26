using System;

namespace MoreVariablesAndPrinting
{
    class Program2
    {
        static void Main(string[] args)
        {
            String Name, Eyes, Teeth, Hair;
            Name = "Zed A. Shaw";
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            double Age = 35;
            //imperial
            double HeightImp = 74;
            double WeightImp = 180;

            //double chops 0's after '.'   2 places with bad fix ↓↓wards
            double Height = Math.Round((HeightImp * 2.45), 2);  // cm's 
            double Weight = Math.Round((WeightImp * 0.453592), 2); // kg's


            Console.WriteLine($"Let's talk about {Name}.");
            //              wrong way to .0's ↓
            Console.WriteLine($"He's { Height}0 cm tall.");
            Console.WriteLine($"He's { Weight} kilograms.");
            Console.WriteLine($"Actually, that's not too heavy.");
            Console.WriteLine($"He's got { Eyes} eyes and { Hair} hair.");
            Console.WriteLine($"His teeth are usually { Teeth} depending on the coffee.");
            //                                            ↓ zero
            Console.WriteLine($"If I add { Age}, { Height}0 , and { Weight} I get { Math.Round(Age + Height + Weight, 2)} .");

            Console.ReadKey();
        }
    }
}