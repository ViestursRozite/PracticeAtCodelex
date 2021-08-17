using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program7
    {
        private const string fileName = "midtermscores.txt";
        private static string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\", fileName));

        private static void Main(string[] args)
        {
            string readText = File.ReadAllText(path);
            Dictionary<string, List<int>> scores = new Dictionary<string, List<int>>();

            scores.Add("00-09", new List<int>());
            scores.Add("10-19", new List<int>());
            scores.Add("20-29", new List<int>());
            scores.Add("30-39", new List<int>());
            scores.Add("40-49", new List<int>());
            scores.Add("50-59", new List<int>());
            scores.Add("60-69", new List<int>());
            scores.Add("70-79", new List<int>());
            scores.Add("80-89", new List<int>());
            scores.Add("90-99", new List<int>());
            scores.Add("100", new List<int>());

            foreach (var s in readText.Split(' '))
            {
                int score = int.Parse(s);
                if ((0 <= score) && (score <= 9)) scores["00-09"].Add(score);
                else if ((10 <= score) && (score <= 19)) scores["10-19"].Add(score);
                else if ((20 <= score) && (score <= 29)) scores["20-29"].Add(score);
                else if ((30 <= score) && (score <= 39)) scores["30-39"].Add(score);
                else if ((40 <= score) && (score <= 49)) scores["40-49"].Add(score);
                else if ((50 <= score) && (score <= 59)) scores["50-59"].Add(score);
                else if ((60 <= score) && (score <= 69)) scores["60-69"].Add(score);
                else if ((70 <= score) && (score <= 79)) scores["70-79"].Add(score);
                else if ((80 <= score) && (score <= 89)) scores["80-89"].Add(score);
                else if ((90 <= score) && (score <= 99)) scores["90-99"].Add(score);
                else if (score == 100) scores["100"].Add(score);
            }
            
            foreach(KeyValuePair<string, List<int>> kvp in scores)
            {
                string dots = new string('*', scores[kvp.Key].Count);
                Console.WriteLine($"{kvp.Key} : {dots}");
            }

            Console.ReadKey();
        }
    }
}
