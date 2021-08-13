using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise9
{
    class List09
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", firstList));
            Console.WriteLine(string.Join(",", secondList));

            var thirdList = firstList.Concat(secondList);

            Console.WriteLine("[{0}]", string.Join(",", thirdList));
            Console.ReadKey();
        }
    }
}
