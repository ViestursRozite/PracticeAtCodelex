using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program4
    {
        public static string HappyOrSad(int yourNumber)
        {
            HashSet<int> numbers = new HashSet<int>();
            while (true)
            {
                if(numbers.Add(yourNumber))
                {
                    char[] arr = yourNumber.ToString().ToCharArray();
                    yourNumber = 0;
                    foreach(char c in arr)
                    {
                        int num = c - '0';
                        yourNumber += num * num;
                    }
                    if (yourNumber == 1) return "Happy";
                }
                else
                {
                    return "Sad";
                }
            }
        }

        static void Main(string[] args)
        {
            int[] ints = new int[] { 2, 6, 11, 55, 77, 5, 87, 3654, 8976, 253, 12353, 7657, 139 };

            foreach(int i in ints)
            {
                Console.WriteLine($"{i} is: " + HappyOrSad(i));
            }

            Console.ReadKey();
        }
    }
}
