using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise7
{
    class List07
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

            if (colors.IndexOf("White") != -1) 
            {
                Console.WriteLine($"Found the element: colors[{colors.IndexOf("White")}]");
            }
            else
            {
                Console.WriteLine("There is no such element");
            }
            Console.ReadKey();
        }
    }
}
