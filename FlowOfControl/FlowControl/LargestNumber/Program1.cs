using System;
using System.Collections.Generic;

namespace LargestNumber
{
    class Program1
    {
        
        static void Main(string[] args)
        {       
            //         Make user give input
            decimal GetNumFromUser(string whichNumberDoYouNeed)
            {
                Console.WriteLine($"Input the {whichNumberDoYouNeed} number: ");
                decimal result = 0;
                decimal.TryParse(Console.ReadLine(), out result);
                return result; 
            }

            //      Place input in a list
            List<decimal> inputList = new List<decimal>();
            inputList.Add(GetNumFromUser("first"));
            inputList.Add(GetNumFromUser("second"));
            inputList.Add(GetNumFromUser("third"));

            //          find largest input
            decimal holderForLargestNum = 0;
            foreach(decimal inputNumber in inputList)
            {
                if (inputNumber > holderForLargestNum) holderForLargestNum = inputNumber;
            }

            //         result
            Console.WriteLine("Largest number is : " + holderForLargestNum);
            Console.ReadKey();
        }
    }
}
