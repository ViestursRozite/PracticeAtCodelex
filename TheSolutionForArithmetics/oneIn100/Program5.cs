using System;

namespace oneIn100
{
    class Program5
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numToGuess =rnd.Next(1, 101);

            Console.WriteLine("I am thinking of a number between 1 and 100 try and guess it");
            int guess;
            Int32.TryParse(Console.ReadLine(), out guess);

            if (numToGuess == guess) Console.WriteLine("Correct. Yay!");
            if (numToGuess > guess) Console.WriteLine("too low :c");
            if (numToGuess < guess) Console.WriteLine("too high :c");

            return;
        }

        
    }
}
