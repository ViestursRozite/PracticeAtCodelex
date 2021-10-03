using System;

namespace TicTacToe
{
    class Program7
    {
        private static string[,] board = new string[3, 3];

        private static void Main(string[] args)
        {
            int currentMoveVar = 1;

            InitBoard();
            DisplayBoard();
            ShowInstructions();

            while (true)//run program till game ends
            {
                MakeTheMove(currentMoveVar);
                DisplayBoard();
                if (HasAnyoneWon(currentMoveVar).Length == 1)
                {
                    Console.WriteLine($"{HasAnyoneWon(currentMoveVar)} has won, yay!");
                    Console.ReadKey();
                    return;
                }                

                currentMoveVar++;
                if(currentMoveVar == 10)
                {
                    Console.WriteLine("The only thing I see here are loosers");
                    Console.ReadKey();
                    return;
                }
            }
        }

        private static void ShowInstructions()//text at start
        {
            Console.WriteLine("Play a game of TicTacToe\n" +
                "I will write down your moves and declare a winner\n" +
                "You can play by entering the number on the board and I will place X or O there");
        }

        private static int AskForUserMove(int moveNr)
        {
            string xOrO = moveNr % 2 == 0 ? "O" : "X";

            Console.WriteLine($"Enter the number where you would like to place {xOrO}:\n");
            var usersChoice = Console.ReadLine();
            int usersChoiceAsInt = 0;
            int.TryParse(usersChoice, out usersChoiceAsInt);

            if (usersChoiceAsInt == 0 || (usersChoiceAsInt < 1 || usersChoiceAsInt > 9)) 
            {
                Console.WriteLine("Looks like an incorrect input, try again");
                AskForUserMove(moveNr);//ask again if input does not make sense
            }

            return usersChoiceAsInt;
        }


        private static string HasAnyoneWon(int currentMove)//return a winner of "" string
        {
            string winner = "";

            if(currentMove >= 5)
            {
                string[,] b = board;

                winner += b[0, 0].Equals(b[0, 2]) && b[0, 1].Equals(b[0, 2]) ? b[0, 0] : "";
                winner += b[1, 0].Equals(b[1, 2]) && b[1, 1].Equals(b[1, 2]) ? b[1, 0] : "";//check horizontals
                winner += b[2, 0].Equals(b[2, 2]) && b[2, 1].Equals(b[2, 2]) ? b[2, 0] : "";

                winner += b[0, 0].Equals(b[1, 0]) && b[0, 0].Equals(b[2, 0]) ? b[0, 0] : "";
                winner += b[0, 1].Equals(b[1, 1]) && b[0, 1].Equals(b[2, 1]) ? b[0, 1] : "";//check verticals
                winner += b[0, 2].Equals(b[1, 2]) && b[0, 2].Equals(b[2, 2]) ? b[0, 2] : "";

                winner += b[0, 0].Equals(b[1, 1]) && b[0, 0].Equals(b[2, 2]) ? b[0, 0] : "";//check diognal top left to bottom right
                winner += b[0, 2].Equals(b[1, 1]) && b[0, 2].Equals(b[2, 0]) ? b[0, 2] : "";//check the other one

                if(winner.Length == 1) return winner;
            }
            return "";
        }

        private static int[] GetPositionOnBoard(int someNum)
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    if (board[r, c] == $"{someNum}")
                    {
                        return new int[] { r, c};//return coordinates if possible
                    }
                }
            }
            return new int[] { -1};//return -1 if something is wrong
        }

        private static void MakeTheMove(int currentMove)
        {
            int numUserProvided = AskForUserMove(currentMove);
            int[] PositionOfNumOnBoard = GetPositionOnBoard(numUserProvided);
            
            if (PositionOfNumOnBoard.Length == 2)//user give a position without X or O
            {
                if(currentMove % 2 == 0)//write X or O on board
                {
                    int[] P = PositionOfNumOnBoard;
                    board[P[0], P[1]] = "O";
                }
                else
                {
                    int[] P = PositionOfNumOnBoard;
                    board[P[0], P[1]] = "X";
                }
            }
            else
            {
                Console.WriteLine("Seems that was already played");
                MakeTheMove(currentMove);//start over, cause user entered a played number
            }

        }
        private static void InitBoard()
        {
            // fills up the board with nums
            int nums = 1;
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                { 
                board[r, c] = $"{nums}";
                nums++;
                }
            }
            
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("");
            Console.WriteLine("      " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("     --+-+--");
            Console.WriteLine("      " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("     --+-+--");
            Console.WriteLine("      " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("");
        }
    }
}
