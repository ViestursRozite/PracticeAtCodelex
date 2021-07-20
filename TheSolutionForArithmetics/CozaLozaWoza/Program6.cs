using System;
using System.Collections.Generic;

namespace CozaLozaWoza
{
    class Program6
    {
        static void Main(string[] args)
        {
            List<object[]> wordAndValueList = new List<object[]>();
            wordAndValueList.Add(new object[] { "Coza", 3 });
            wordAndValueList.Add(new object[] { "Woza", 5 });
            wordAndValueList.Add(new object[] { "Loza", 7 });

            int numbersPerLine = 11;//write this many numbers on each line
            int totalNumbers = 110;
            string finalResult = "";
                        
            string calcPosition(int inputPosition) //spit out either a string of words or a num if no words can be written in this position
            {
                string outputOfThisFunc = "";
                bool writeAWordAsOutput = false;

                foreach (var wordValuePair in wordAndValueList)
                {
                    string theWord = (string)wordValuePair[0];
                    int theNumber = (int)wordValuePair[1];
                    bool imAllowedToWriteAWord = false;

                    if (inputPosition % theNumber == 0) imAllowedToWriteAWord = true;
                    if (imAllowedToWriteAWord) writeAWordAsOutput = true;
                    if (imAllowedToWriteAWord) outputOfThisFunc += theWord;
                }
                if (!writeAWordAsOutput) outputOfThisFunc = $"{inputPosition}";
                return outputOfThisFunc;//either words or 1 number
            }

            for (int i = 1; i < totalNumbers + 1; i++)
            {
                finalResult += calcPosition(i);//write what has to be written
                finalResult += " ";//press space
                if (i % numbersPerLine == 0) finalResult += "\n"; //hit enter if line length is reached
            }

            Console.WriteLine(finalResult);

        }
    }
}
