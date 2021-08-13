using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise6
{
    class List06
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.WriteLine(string.Join(",", colors));

            colors.Remove(colors[2]);//Remove the third element from the list.

            Console.WriteLine("After removing third element from the list:");
            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
