using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    public class Program5
    {
        public static int[] WordCount(string text)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            char[] letters = text.ToCharArray();
            
            int numLines = text.Split('\n').Length;
            int numWords = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;//gets amount of human words
            int chars = letters.Length;
            int computerChars = chars;

            foreach(char c in letters)//remove non-human letters
            {
                if (c == '\n') chars--;
                if (c == '\r') chars--;
                if (c == ' ') chars--;
            }

            int[] result = new int[] { numLines, numWords, chars, computerChars};
            return result;
        }

        public static string GetPathToLear()
        {
            string fileName = "lear.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\", fileName);
            return path;
        }

        static void Main(string[] args)
        {
            string path = GetPathToLear();
            int[] data = WordCount(File.ReadAllText(path));

            Console.WriteLine($"The given text file contains:\n" +
                $"{data[0]} lines\n" +
                $"{data[1]} words\n" +
                $"{data[2]} characters\n" +
                $"{data[3]} computer characters");

            Console.ReadKey();
        }
    }
}
