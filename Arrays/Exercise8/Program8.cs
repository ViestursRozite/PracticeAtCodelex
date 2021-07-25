using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise8
{
    class Program8
    {
        private static string[] wordsToGuess = new string[] 
        {
        "every", "time", "you", "play", "hangman",
        "a", "stickman", "family", "looses", "their", "father"
        };

        class Hangman
        {
            public string HiddenWord;
            public string StateOfGuess;
            public int GameMove;
            public int NumGuessesLeft;
            public List<char> WrongLetters;

            public Hangman(string[] wordsToGuess, int numGuesses = 6)
            {
                this.HiddenWord = wordsToGuess[new Random().Next(0, wordsToGuess.Length)];
                this.NumGuessesLeft = numGuesses;
                this.GameMove = 0;
                this.StateOfGuess = new string('_', HiddenWord.Length);
                this.WrongLetters = new List<char>();

                Console.WriteLine("Lets play a game of Hangman");
            }

            public void DisplayState()
            {
                Console.WriteLine("Word: " + this.StateOfGuess);
                Console.WriteLine("Game move: " + this.GameMove);
                Console.WriteLine("Guesses left: " + this.NumGuessesLeft);
                Console.WriteLine("Wrong letters: " + "[{0}]", string.Join(", ", this.WrongLetters));
            }


            public char GetCharFromPlayer()
            {
                Console.WriteLine("enter your guess:\n");
                char playerGuess;
                string temporaryHolder = Console.ReadLine();

                if (temporaryHolder.Length != 1)
                {
                    Console.WriteLine("You must enter your guess 1 character at a time");
                    GetCharFromPlayer();
                }

                char.TryParse(temporaryHolder, out playerGuess);
                return playerGuess;
            }

            public string ProgressGame(char character)
            {
                if (this.HiddenWord.Contains(character))//Player gets the correct letter
                {
                    string newStateOfGuess = "";

                    for(int i = 0; i < this.HiddenWord.Length; i++)//update how the result should look like
                    {
                        if(this.HiddenWord[i] == character)
                        {
                            newStateOfGuess += $"{character}";
                        }
                        else if (this.StateOfGuess[i] != '_')
                        {
                            newStateOfGuess += $"{this.HiddenWord[i]}";
                        }
                        else
                        {
                            newStateOfGuess += $"{'_'}";
                        }
                    }
                    this.StateOfGuess = newStateOfGuess;
                    this.GameMove++;
                    return this.StateOfGuess;//out the new result
                }
                else
                {
                    this.GameMove++;
                    this.NumGuessesLeft--;// player guessed incorrectly decriment guess
                    this.WrongLetters.Add(character);//wrie down the wron guess
                    return this.StateOfGuess;
                }
            }

            public bool IsTheGameOver()
            {
                if (this.NumGuessesLeft <= 0 || HiddenWord.Equals(StateOfGuess))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

       
        static void Main(string[] args)
        {
            char choice = 'x';
            do
            {
                Hangman game = new Hangman(wordsToGuess);

                while (!game.IsTheGameOver())
                {
                    game.DisplayState();
                    game.ProgressGame(game.GetCharFromPlayer());
                }

               
                while (choice != 'y' || choice != 'n')// get a y or n ,   restart or end
                {
                    Console.WriteLine("would you like to play again? y/n");
                    char whateverPlayerTypes = Console.ReadKey().KeyChar;
                    if (whateverPlayerTypes == 'y' || whateverPlayerTypes == 'n')
                    {
                        choice = whateverPlayerTypes;
                        break ;
                    }
                }
            }
            while (choice == 'y') ;

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
            return;

        }
    }
}
