using System;
using Xunit;
using FlightPlanner;
using System.Collections.Generic;
using System.Linq;

namespace TestProjectCollections
{
    public class UnitTest2
    {
        [Fact]
        public void FillTravelMap_InReadTet_OutCorrectHashSets()
        {
            //Arrange
            HashSet<string> travelStartingPoints = new HashSet<string>();
            travelStartingPoints.Add("San Jose");
            travelStartingPoints.Add("New York");
            travelStartingPoints.Add("Anchorage");
            travelStartingPoints.Add("Honolulu");
            travelStartingPoints.Add("Denver");
            travelStartingPoints.Add("San Francisco");

            string[] readText = new string[] {
            "San Jose -> San Francisco", "San Jose -> Anchorage",
            "New York -> Anchorage", "New York -> San Jose",
            "New York -> San Francisco", "New York -> Honolulu",
            "Anchorage -> New York", "Anchorage -> San Jose",
            "Honolulu -> New York", "Honolulu -> San Francisco",
            "Denver -> San Jose", "San Francisco -> New York",
            "San Francisco -> Honolulu", "San Francisco -> Denver"};

            Dictionary<string, HashSet<string>> travelMap = new Dictionary<string, HashSet<string>>();

            List<string> expected = new List<string>();
            expected.Add("Anchorage");
            expected.Add("San Jose");
            expected.Add("San Francisco");
            expected.Add("Honolulu");
            //Act
            Program6.FillTravelMap(travelStartingPoints, readText, travelMap);

            HashSet<string> NewYorkCities = new HashSet<string>();
            travelMap.TryGetValue("New York", out NewYorkCities);
            List<string> actual = NewYorkCities.ToList();
            //Assert
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
        
             [Fact]
        public void UniqueStartingPointsToHashSet_InStringArr_OutCorrectHashSets()
        {
            //Arrange
            List<string> travelStartingPointsCorrect = new List<string>();
            travelStartingPointsCorrect.Add("San Jose");
            travelStartingPointsCorrect.Add("New York");
            travelStartingPointsCorrect.Add("Anchorage");
            travelStartingPointsCorrect.Add("Honolulu");
            travelStartingPointsCorrect.Add("Denver");
            travelStartingPointsCorrect.Add("San Francisco");

            string[] readText = new string[] {
            "San Jose -> San Francisco", "San Jose -> Anchorage",
            "New York -> Anchorage", "New York -> San Jose",
            "New York -> San Francisco", "New York -> Honolulu",
            "Anchorage -> New York", "Anchorage -> San Jose",
            "Honolulu -> New York", "Honolulu -> San Francisco",
            "Denver -> San Jose", "San Francisco -> New York",
            "San Francisco -> Honolulu", "San Francisco -> Denver"};
            //Act
            HashSet<string> travelStartingPoints = new HashSet<string>();
            HashSet<string> travelStartingPointsResAsHashSet = Program6.UniqueStartingPointsToHashSet(travelStartingPoints, readText);
            //Assert
            List<string> travelStartingPointsAsList = travelStartingPointsResAsHashSet.ToList();
            for (int i = 0; i < travelStartingPointsCorrect.Count; i++)
            {
                Assert.Equal(travelStartingPointsCorrect[i], travelStartingPointsAsList[i]);
            }

        }
    }
}

