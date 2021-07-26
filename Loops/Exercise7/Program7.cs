using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int playersPoints = 0;

            Console.WriteLine("Lets play a game of \"Piglet\" :");

            string makePlayerWriteInput(int option = 1)//gives y or n, talks to player
            {
                string option1 = $"You have {playersPoints} points \nWould you like to roll the dice?\n enter y/n:\n";
                string option2 = $"Would you like to keep going (y) or stop here (n) ?";
                if(option == 1)Console.WriteLine(option1);
                if(option == 2)Console.WriteLine(option2);

                string answer = Console.ReadLine();

                if(answer != "y" && answer != "n") makePlayerWriteInput();

                return answer;
            }
            
            string playerWantsToPlay = "y";
            do
            {
                string input = makePlayerWriteInput(1);
                int roll = rnd.Next(1, 7);

                if (input == "y")//player wants to roll the dice
                {
                    if (roll == 1)//player got 1 :c
                    {
                        Console.WriteLine($"You rolled: {roll}, \ngame over.[");
                        playersPoints = 0;
                        return;//exit
                    }

                    Console.WriteLine($"You rolled: {roll}, \n total points: {playersPoints += roll}");//player got != 1
                    playerWantsToPlay = makePlayerWriteInput(2);//does player want to keep going?
                }
                if (input == "n") return;
            }
            while (playerWantsToPlay == "y");

            Console.WriteLine($"You finished the game with {playersPoints} points");
            Console.ReadKey();
        }
    }
}
