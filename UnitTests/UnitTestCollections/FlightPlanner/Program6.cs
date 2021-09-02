using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FlightPlanner
{
    public class Program6
    {
        public static int getInt(string messageToUser, int minVal, int maxVal)
        {
            Console.WriteLine(messageToUser);
            int userChoice = -1;
            int.TryParse(Console.ReadLine(), out userChoice);
            if (userChoice == -1)
            {
                Console.Write("number not read");
                getInt(messageToUser, minVal, maxVal);
            }
            if (!((minVal <= userChoice) && (userChoice <= maxVal)))
            {
                Console.Write("not within constraints");
                getInt(messageToUser, minVal, maxVal);
            }
            return userChoice;
        }

        private const string fileName = "flights.txt";
        private static string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\", fileName));

        public static HashSet<string> UniqueStartingPointsToHashSet(HashSet<string> travelStartingPoints, string[] readText)
        {
            foreach (var s in readText)//unique starting points to hashSet
            {
                //locations formatted: "New York -> Hana Lu Lu"
                int rg = s.IndexOf('>');
                string leavesFrom = s.Substring(0, (rg - 2));

                travelStartingPoints.Add(leavesFrom);
            }
            return travelStartingPoints;
        }

        public static void FillTravelMap(HashSet<string> travelStartingPoints, string[] readText, Dictionary<string, HashSet<string>> travelMap)
        {
            foreach (string startingPoint in travelStartingPoints)//Keys
            {
                HashSet<string> travelablePlaces = new HashSet<string>();//Values
                foreach (var s in readText)
                {
                    int rg = s.IndexOf('>');
                    string goesTo = s.Substring((rg + 2));
                    string leavesFrom = s.Substring(0, (rg - 2));

                    if (startingPoint.Equals(leavesFrom))
                    {
                        travelablePlaces.Add(goesTo);//Values
                    }
                }
                travelMap.Add(startingPoint, travelablePlaces);//Fill travelMap
            }
        }

        private static void Main(string[] args)
        {
            //Goal: make travel map
            HashSet<string> travelStartingPoints = new HashSet<string>();//stores starting airports
            Dictionary<string, HashSet<string>> travelMap = new Dictionary<string, HashSet<string>>();

            var readText = File.ReadAllLines(path);

            UniqueStartingPointsToHashSet(travelStartingPoints, readText);

            //foreach (var s in readText)//unique starting points to hashSet
            //{
            //    //locations formatted: "New York -> Hana Lu Lu"
            //    int rg = s.IndexOf('>');
            //    string leavesFrom = s.Substring(0, (rg - 2));

            //    travelStartingPoints.Add(leavesFrom);
            //}


            FillTravelMap(travelStartingPoints, readText, travelMap);
            //fill Dict travelMap  keys: "TravelStartingPoint" values: {hashMaps of allowed destinations}
            //foreach (string startingPoint in travelStartingPoints)//Keys
            //{
            //    HashSet<string> travelablePlaces = new HashSet<string>();//Values
            //    foreach (var s in readText)
            //    {
            //        int rg = s.IndexOf('>');
            //        string goesTo = s.Substring((rg + 2));
            //        string leavesFrom = s.Substring(0, (rg - 2));

            //        if (startingPoint.Equals(leavesFrom))
            //        {
            //            travelablePlaces.Add(goesTo);//Values
            //        }
            //    }
            //    travelMap.Add(startingPoint, travelablePlaces);//Fill travelMap
            //}

            //Display starting locations
            Console.WriteLine("press 0 to exit");
            Console.WriteLine("Possible starting locations:\n");
            int iterator = 1;//gets reused in further loops
            foreach (KeyValuePair<string, HashSet<string>> kvp in travelMap)
            {
                Console.WriteLine($"nr.({iterator}) {kvp.Key}");
                iterator++;
            }
            
            //Get users travel plan
            int whereverUserWants = getInt("\n Where would you like to start your journey?\nEnter the number:\n", 0, iterator);
            if(whereverUserWants == 0)
            {
                Console.WriteLine("Exited early");
                Console.ReadKey();
                return;
            }

            string place = travelMap.Keys.ElementAt(whereverUserWants - 1);
            List<string> travelPlan = new List<string>();

            bool runLoop = true;
            do
            {
                travelPlan.Add(place);
                Console.Clear();
                Console.WriteLine($"You travel to: {place}\n" +
                    $"Where would you like to go to next?:\n" +
                    $"options:\n" +
                    $"nr.(0) for exit\n");

                iterator = 1;
                foreach(string city in travelMap[place])
                {
                    Console.WriteLine($"nr.({iterator}) {city}");
                    iterator++;
                }

                whereverUserWants = getInt("\nEnter the desired location:\n", 0, travelMap[place].Count);
                if (whereverUserWants == 0) 
                {
                    runLoop = false;
                    break;
                }

                place = travelMap[place].ToList()[whereverUserWants - 1];
            } while (runLoop);

            //Travel plan made, display it
            Console.Clear();
            if (travelPlan.Count == 1) Console.WriteLine($"You visit the airport at {travelPlan[0]}");
            else
            {
                Console.WriteLine("You travel to: \n{0}", string.Join("\n", travelPlan));
            }

            Console.ReadKey();
        }
    }
}
