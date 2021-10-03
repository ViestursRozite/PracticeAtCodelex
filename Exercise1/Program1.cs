using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program1
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            
            //replace array with an List and print out the results
            string[] nation = { "Germany", "Germany", "Japan", "Germany", "Germany", "Germany", "USA" };
            List<string[]> list = new List<string[]>();

            for(int i = 0; i < array.Length; i++)
            {
                list.Add(new string[] { array[i], nation[i]});
            }
            Console.WriteLine(list);
            Console.WriteLine("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("    [{0}],", string.Join(", ", list[i]));//print element in list
            }
            Console.WriteLine("]");

            //replace array with a HashSet and print out results
            Console.WriteLine();
            HashSet<string> myHashSet = new HashSet<string>(array);
            Console.WriteLine(myHashSet);
            myHashSet.ToList<String>().ForEach(x => Console.WriteLine(x));

            //replaced array with a Dictionary (use brand as key and origination as value) and print out the results
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            for(int i = 0; i < array.Length; i++)
            {
                if (!dictionary.ContainsKey(array[i])) 
                {
                    dictionary.Add(array[i], nation[i]);
                }                
            }
            
            Console.WriteLine(dictionary);
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Console.ReadKey();
        }
    }
}
