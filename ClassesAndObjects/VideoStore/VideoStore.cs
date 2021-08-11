using System;
using System.Collections.Generic;

namespace VideoStore
{

    class VideoStore
    {
        private Dictionary<string, List<Video>> _inventory;

        public VideoStore()
        {
            this._inventory = new Dictionary<string, List<Video>>();
        }

        public void AddVideo(string title)// dictionary where key==video name, value list of all videoes with the same name
        {
            List<Video> allSameVideoes;
            if (!this._inventory.TryGetValue(title, out allSameVideoes))
            {
                this._inventory.Add(title, new List<Video>());  // the key isn't in the dictionary.
                this._inventory[title].Add(new Video(title));// add 1 instance of a video in dictionary
            }
            else
            {
                this._inventory[title].Add(new Video(title));// add 1 more instance of a video
            }
        }
        
        public string Checkout(string title)
        {
            List<Video> allSameVideoes;
            if (!this._inventory.TryGetValue(title, out allSameVideoes))
            {
                return "We do not have such video's";// the key isn't in the dictionary.
            }
            else
            {
                foreach (Video v in allSameVideoes)//look trough our inventory
                {
                    if(!v.Taken)//this coppy is not taken
                    {
                        v.Taken = true;
                        return $"Video {title} now rented out";
                    }
                }
                return $"ERROR All copies({allSameVideoes.Count}) of {title} rented out";
            }
        }

        public string ReturnVideo(string title)
        {
            List<Video> allSameVideoes;
            if (!this._inventory.TryGetValue(title, out allSameVideoes))
            {
                return "We do not have such video's";// the key isn't in the dictionary.
            }
            else
            {
                for(int i = 0; i < allSameVideoes.Count; i++)//look trough our inventory
                {
                    int foo = allSameVideoes.Count - i - 1;
                    if (allSameVideoes[foo].Taken)//this coppy is taken
                    {
                        allSameVideoes[foo].Taken = false;
                        return $"Video {title} returned";
                    }
                }
                return $"ERROR All copies({allSameVideoes.Count}) of {title} already returned";
            }
        }

        public string TakeUsersRating(int rating, string title)
        {
            List<Video> allSameVideoes;
            if (!this._inventory.TryGetValue(title, out allSameVideoes))
            {
                return "We do not have such video's";// the key isn't in the dictionary.
            }
            else
            {
                foreach(Video vid in allSameVideoes)
                {
                    vid.Rate(rating);
                    return "Rating saved";
                }
                return "You shouldn't see this messige";
            }
        }

        public void ListInventory()
        {
            foreach (string movieName in _inventory.Keys)
            {
                double avgRating = _inventory[movieName][0].ReturnAvgRating();
                string status = _inventory[movieName][0].Taken ? "is already taken " : "is avilable ";

                Console.WriteLine(movieName + status + "With an average rating of " + avgRating);
            }
        }
    }
}
