using System;

namespace AsciiFigure
{
    class AsciiFigure
    {
        public int Height;
        public string LeftSlash = "////";//elements
        public string RightSlash = "\\\\\\\\";
        public string Star = "****";

        public AsciiFigure(int height)
        {
            this.Height = height;
        }

        public string HitKey(string key, int timesToPress)//return that element n times
        {
            string result = "";
            for (int i = 0; i < timesToPress; i++)
            {
                result += key;
            }
            return result;
        }

        public string BuildNthLine(int line, int numSides = 0)//build pyramid from the top, topmost line is 0
        {
            string leftSide = "";
            string rightSide = "";
            int numStars = line;
            int numSlashes = Height - line - 1;
            
            leftSide += HitKey(LeftSlash, numSlashes);  
            leftSide += HitKey(Star, numStars);

            rightSide += HitKey(Star, numStars);
            rightSide += HitKey(RightSlash, numSlashes);
            //      ///+***   ****+\\\     \n
            return leftSide + rightSide + HitKey("\n", 1);
        }

        public string Build()//draw pyramid
        {
            string result = "";
            for (int i = 0; i < Height; i++)
            {
                result += BuildNthLine(i);
            }
            return result;
        }

    }
    class Program8
    {
        static void Main()
        {
            Console.WriteLine("enter height (1-∞):");
            int userInput = 0;
            int.TryParse(Console.ReadLine(), out userInput);

            if (userInput <= 0) Main();//loop back to start if user does not give int

            AsciiFigure pyramid = new AsciiFigure(userInput);
            Console.WriteLine(pyramid.Build());//print a pyramid

            Console.ReadKey();
        }
    }
}
