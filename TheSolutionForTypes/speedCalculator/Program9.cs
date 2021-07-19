using System;
using System.Collections.Generic;

namespace speedCalculator
{
    class Program9
    {
        static void Main(string[] args)
        {
            
            Console.Write("Write four numbers representing distance traveled in meters, \n" +
                "hours taken, minutes taken and seconds taken\n" +
                "example: \n" +
                "10000,0,1,59\n" +
                "representing 10km traveled in 0 hours 40 minutes and 59 seconds\n" +
                "numbers must be seperated by \',\' to work, also no other symbols allowed\n");

            string inString = Console.ReadLine();
                        
            string[] tokens = inString.Split(",");//        in comes a string
            List<int> listOfInNumbers = new List<int>();
            int oneNum;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out oneNum))
                    listOfInNumbers.Add(oneNum);//          out comes a list of nums
            }
            
            if (listOfInNumbers.Count != 4) return;//exit if incorrect amount of numbers

            double meters, hours, minutes, seconds, //values from list
                speedMtrPSec, speedKmPH, speedMilPH;//calculated results

                meters = listOfInNumbers[0];
                hours = listOfInNumbers[1];
                minutes = listOfInNumbers[2];
                seconds = listOfInNumbers[3];

                speedMtrPSec = meters / ((hours * 60 * 60) + (minutes * 60) + seconds);
                speedKmPH = (meters / 1000) / (hours + (minutes / 60) + (seconds / 60 / 60));
                speedMilPH = (meters / 1609) / (hours + (minutes / 60) + (seconds / 60 / 60));

            Console.WriteLine($"\nResult:\n" +
                $"{Math.Round(speedMtrPSec, 2)} meters per second or\n" +
                $"{Math.Round(speedKmPH, 2)} kilometers per hour or\n" +
                $"{Math.Round(speedMilPH, 2)} miles per hour");

            return;
        }
    }
}
