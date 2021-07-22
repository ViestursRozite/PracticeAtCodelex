using System;
using System.Linq;

namespace TenBillion
{
    class Program3
    {
        
        static void Main(string[] args)
        {   
            IsNumPassedAsStringLessThan10Bil("999999999");// just right 
            IsNumPassedAsStringLessThan10Bil("10000000000");// too many 0
            IsNumPassedAsStringLessThan10Bil("1000000000");// 10bil '1' too many            
            IsNumPassedAsStringLessThan10Bil("-56000000");// negative
            IsNumPassedAsStringLessThan10Bil("154gj23");// letters
            IsNumPassedAsStringLessThan10Bil("0023664");// nonsense number
            IsNumPassedAsStringLessThan10Bil("");// ask user

            void IsNumPassedAsStringLessThan10Bil(string numToCheck = "")
            {
                //                               get input
                //either from user or as func parameter.
                string input;
                if (numToCheck == "")
                {
                    Console.WriteLine("Input an integer number less than ten billion: ");
                    input = Console
                        .ReadLine()
                        .Trim();
                }
                else 
                {
                    input = numToCheck;
                }

                //                      Check requirements 
                //.All is aproximetly a foreach,     it also     sees '-' as char so takes out negatives
                bool isDigitsOnlyAndPositive = input.All(someCharInInput => someCharInInput >= '0' && someCharInInput <= '9');
                bool firstDigitNotZero = input.IndexOf('0') != 0 ? true : false;
                bool lessThan10Bilion = input.Length < 10 ? true : false;

                //                   interpret result and exit
                if(isDigitsOnlyAndPositive && firstDigitNotZero && lessThan10Bilion)
                {
                    Console.WriteLine($"The number provided \"{ input}\" is positive, less than 10 billion and is {input.Length} digits long");
                }
                //                  show some errors if needed
                else if(!isDigitsOnlyAndPositive)
                {
                    Console.WriteLine($"{input} is not a positive intiger");
                    return;
                }
                else if (!firstDigitNotZero)
                {
                    Console.WriteLine($"{input} should not start with 0");
                    return;
                }
                else if (!lessThan10Bilion)
                {
                    Console.WriteLine($"{input} is too long");
                    return;
                }
            }
            // pause, then end
            Console.ReadKey();
            return;
        }
    }
}
