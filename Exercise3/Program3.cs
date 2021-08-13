using System;
using System.Collections.Generic;
namespace Exercise3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a list of names");
            HashSet<string> names = new HashSet<string>();

            bool loop = true;
            int iteration = 1;
            while (loop)
            {
                Console.WriteLine($"Enter name nr.({iteration})");

                string readResult = "";
                readResult += Console.ReadLine();
                if (readResult.Equals(""))
                {
                    Console.WriteLine("Blank name entered, printing unique:\n");
                    loop = false;
                }
                else
                {
                    if (names.Add(readResult))
                    {
                        Console.WriteLine("That is a new name");
                        iteration++;
                    }
                    else
                    {
                        Console.WriteLine("That's a duplicate");
                    }
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", names));
            Console.ReadKey();
        }
    }
}
