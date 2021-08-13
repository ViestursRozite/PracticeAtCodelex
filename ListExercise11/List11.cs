using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class List11
    {
        static void Main(string[] args)
        {
            //Create an List with string elements
            List<string> myList = new List<string>();
            //Add 10 values to list
            for (int i = 0; i < 10; i++)
            {
                myList.Add($"SomeValue({i + 1 })");
            }
            //Add new value at 5th position
            myList.Insert(4, "Value at position 5");
            //Change value at last position (Calculate last position programmatically)
            myList[myList.Count - 1] = "Changed value";
            //Sort your list in alphabetical order
            myList.Sort();
            //Check if your list contains "Foobar" element
            bool yay = myList.Contains("Foobar") ? true : false;
            //Print each element of list using loop
            foreach(string element in myList)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
