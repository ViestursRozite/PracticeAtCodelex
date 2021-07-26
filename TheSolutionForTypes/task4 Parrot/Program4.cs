using System;

namespace parrot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name and \npress enter:");
            string myName = Console.ReadLine();

            Console.WriteLine("Type the year you were born:");
            int yearBorn = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"My name is {myName} and I was born in {yearBorn}.");
        }
    }
}
