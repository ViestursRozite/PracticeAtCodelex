using System;
//using System.Collections;
using System.Collections.Generic;

namespace sumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type in numbers to sum: \n4,7,4\n4,0,9,7,3,5\nlike the given eamples");

            string inputString = Console.ReadLine();

            string[] tokens = inputString.Split(',');
            List<int> nums = new List<int>();
            int oneNum;

            //Is value a num? add to list : nothing
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out oneNum))
                    nums.Add(oneNum);
            }

            //create a result
            int result = 0;
            foreach (int item in nums)
            {
                result = result + item;
            }
            Console.WriteLine(result);





        }
    }
}
