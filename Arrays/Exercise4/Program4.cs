﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program4
    {
        //TODO: Write a C# program to test if an array contains a specific value.
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };
            int lookingForThisNum = 1245; //check if contains number 1245 

            Console.Write("Does ");
            Console.Write("[{0}]", string.Join(", ", myArray));
            Console.WriteLine($" contain {lookingForThisNum}?");
                        
            if (myArray.Contains(lookingForThisNum))
            {
                Console.WriteLine("-Yes");
            }
            else
            {
                Console.WriteLine("-No");
            }
            Console.ReadKey();
        }
    }
}
