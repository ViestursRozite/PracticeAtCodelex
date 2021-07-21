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

            //out a (string) containing words or a (string) containing a num           
            string calcPosition(int positionInTheNumList) 
            {
                string outputOfThisFunc = "";
                bool funcIsGoingToOutputAWord = false;

                foreach (var wordValuePair in wordAndValueList)
                {
                    string stringFromWordValPair = (string)wordValuePair[0];
                    int numFromWordValPair = (int)wordValuePair[1];
                    
                    if (positionInTheNumList % numFromWordValPair == 0)
                    {
                        funcIsGoingToOutputAWord = true;
                        outputOfThisFunc += stringFromWordValPair;
                    }
                }
                if (!funcIsGoingToOutputAWord) outputOfThisFunc = $"{positionInTheNumList}";
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
