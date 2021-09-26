using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program2
    {
        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();

            mySet.Add("Red");
            mySet.Add("Black");
            mySet.Add("Yellow");
            mySet.Add("Blue");
            mySet.Add("Green");

            Console.WriteLine("Should have 5 elements: ");
            Console.WriteLine(string.Join(",", mySet));

            var list = mySet.ToList();
            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine(list[i]);
            }
            
            Console.WriteLine("Is mySet empty: ");
            mySet = new HashSet<string>();
            Console.WriteLine(mySet.Count == 0);

            //check if it is possible to add duplicated values
            mySet.Add("Green");
            mySet.Add("Orange");
            mySet.Add("Green");
            mySet.Add("Purple");

            Console.WriteLine(string.Join(",", mySet));
            Console.ReadKey();
        }
    }
}
