using System;

namespace Exercise3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int[] actualNumbers = new int[20];
            string[] covered = new string[20];
            Random randNum = new Random();

            for (int i = 0; i < actualNumbers.Length; i++)
            {
                actualNumbers[i] = randNum.Next(1, 1000);//write actual hidden array

                int x = actualNumbers[i].ToString().Length;//↓
                string c = $"{actualNumbers[i].ToString()[x - 1]}";//last digit
                string z = new String('X', x - 1);//make X's
                covered[i] = $"{z}{c}";//write representing array [xx1, x5, xxx2...]
            }

            Console.WriteLine("[{0}]", string.Join(" ,", covered));
            Console.WriteLine("I have an array where i have hidden my numbers, which one would you like to know?\n" +
                "enter the desired index (0-19):");

            int userInput = int.Parse(Console.ReadLine());//react to user
            Console.WriteLine($"\n {actualNumbers[userInput]} - that's my favourite!\n" +
                $"\nActual list: ");
            Console.WriteLine("[{0}]", string.Join(" ,", actualNumbers));
            
            Console.ReadKey();
        }
    }
}
