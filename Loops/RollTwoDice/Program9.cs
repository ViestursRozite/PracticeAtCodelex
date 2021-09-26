using System;

namespace RollTwoDice
{
    class Program9
    {
        static void Main()
        {
            int dice = 2;
            int sides = 6;
            int lowestOnDice = 1;
            int minVal = dice * lowestOnDice;
            int maxVal = dice * sides;
            int userInput = 0;

            Console.WriteLine($"I will roll {dice} d{sides}'s. \nEnter the sum you want to get:");
            int.TryParse(Console.ReadLine(), out userInput);
            if(userInput < minVal || userInput > maxVal)//get valid input
            {
                Console.WriteLine("... why?");
                Main();
            }

            Console.WriteLine("Let's roll some dice!");
            Random rnd = new Random();


            int sumHolder = 0;
            do
            {
                sumHolder = 0;
                for (int i = 0; i < dice; i++)
                {
                    int roll = rnd.Next(lowestOnDice, sides + 1);
                    Console.WriteLine($"Roll{i + 1}: {roll}");
                    sumHolder += roll;
                }
                Console.WriteLine($"Summ: {sumHolder}\n");

                if (sumHolder != userInput)//react to roll
                {
                    Console.WriteLine($"Aww come on! One more try");
                }

            } while (sumHolder != userInput);

            Console.WriteLine($"LETS GOOOOOOO! I got it! \n asked:{userInput} \nrolled:{sumHolder}");

            Console.WriteLine("enter 'y' to play again, nothing to close");
            string answer = Console.ReadLine().ToLower();
            if(answer.Equals("y"))//end or play again?
            {
                Main();
            }

            Console.WriteLine("thanks for playing");
            Console.ReadKey();
        }
    }
}
