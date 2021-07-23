using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program5
    {
        //TODO: Write a C# program to find the index of an array element.
        private static void Main(string[] args)
        {
            int[] myArray = {25, 14, 56, 15, 36, 56, 77, 18, 29, 49};

            var find1 = 36;
            var find2 = 29;

            var indexOfElement36 = Array.IndexOf(myArray, find1);
            var indexOfElement29 = Array.IndexOf(myArray, find2);

            Console.WriteLine("Index position of 36 is: " + indexOfElement36);
            Console.WriteLine("Index position of 29 is: " + indexOfElement29);

            Console.ReadKey();
        }
    }
}
