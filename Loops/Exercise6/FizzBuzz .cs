using System;
using System.Collections.Generic;

namespace CozaLozaWoza
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an intiger: ");
            int userIntiger = int.Parse(Console.ReadLine());

            List<object[]> wordAndValueList = new List<object[]>();
            wordAndValueList.Add(new object[] { "Fizz", 3 });
            wordAndValueList.Add(new object[] { "Buzz", 5 });

            int numbersPerLine = 20;//write this many numbers on each line
            int totalNumbers = userIntiger;
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
            Console.ReadKey();
        }
    }
}
