using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a list of names");

            bool loop = true;
            int iteration = 1;
            HashSet<string> names = new HashSet<string>;

            while (loop)
            {
                Console.WriteLine($"Enter name nr.({iteration})");
                string readResult = "";
                readResult += Console.ReadLine();
                if (readResult.Equals(""))
                {
                    Console.WriteLine("Blank nam entered, printing unique:\n")
                    loop = false;
                    return;
                }

                names.Add(readResult) ? Console.WriteLine("That is a new name") : Console.WriteLine("That's a duplicate");
            }

            Console.WriteLine("[{0}]", string.Join(", ", names));
            Console.ReadKey();
        }
    }
}
