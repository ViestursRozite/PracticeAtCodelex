using System;

namespace BMI
{
    class Program9
    {
        static void Main(string[] args)
        {
            whatIsMyBMI(185, 76);
            whatIsMyBMI(185, 90);
            whatIsMyBMI(185, 50);


            void whatIsMyBMI(decimal heightCentimeters, decimal weightKilograms)
            {
                decimal heightInches = heightCentimeters / 2.54M;
                decimal weightPounds = weightKilograms * 2.205M;

                decimal BMI = (weightPounds * 703) / (heightInches * heightInches);

                if (BMI < 18.5M)
                {
                    Console.WriteLine("Underweight");
                }
                else if (BMI > 25M)
                {
                    Console.WriteLine("Overweight");
                }
                else
                {
                    Console.WriteLine("Weight within norms");
                }
            }




        }
    }
}
