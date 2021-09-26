using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class List01
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Yellow");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Orange");

            Console.WriteLine("List: [{0}]", string.Join(", ", colors));
            Console.ReadKey();
        }
    }
}
