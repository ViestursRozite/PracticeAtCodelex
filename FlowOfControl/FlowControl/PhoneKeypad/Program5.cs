using System;
using System.Collections.Generic;

namespace PhoneKeypad
{
    class Program5
    {
        static void Main(string[] args)
        {
            //                    Ask user for input
            string GetUserInput()
            {
                Console.WriteLine("Enter some text and i will generate \n" +
                    "instructions on how to write it on a button phone:\n");

                return Console
                    .ReadLine()
                    .ToLower();
            }

            //           write down user input
            string inputAsLowercase = GetUserInput();

            //              make keypad
            string[] phoneKeypad = new string[]
            {
                 "1",  "abc2",  "def3",
                 "ghi4",  "kl5", "mno6",
                 "pqrs7",  "tuv8", "wxyz9"
            };

            //      FigureWhatToPress on the keypad 
            string FigureWhatToPress(char symbIWantToType)
            {
                foreach(string button in phoneKeypad)//                                                                 look at buttons
                {
                    
                    if (button.IndexOf(symbIWantToType) != -1)//                                                        is the letter on this button 
                    {
                        char thisNumber = (char)button[button.Length - 1];//                                                see which button i press
                        int pressItXTimes = button.IndexOf(symbIWantToType) + 1;//                                          see how many times I mash it

                        return new string(thisNumber, pressItXTimes);
                    }
                    
                }
                return "wait a bit";
            }

            //                  output a wall of text
            foreach(char letter in inputAsLowercase)
            {
                Console.WriteLine("You need to press: " + FigureWhatToPress(letter));
            }

            Console.ReadLine();
        }
    }
}
