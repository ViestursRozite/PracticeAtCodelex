using System;
using System.Collections.Generic;

namespace ListExercise10
{
    class List10
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine("Original array list: ");
            Console.WriteLine("[{0}]", string.Join(",", colors));

            colors = new List<string>();

            Console.WriteLine("New array list: ");
            Console.WriteLine("[{0}]", string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
