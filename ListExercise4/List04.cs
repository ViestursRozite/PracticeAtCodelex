using System;
using System.Collections.Generic;

namespace ListExercise4
{
    class List04
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            string element = colors[0];
            Console.WriteLine("First element: " + element);

            element = colors[2];
            Console.WriteLine("Third element: " + element);
            Console.ReadKey();
        }
    }
}
