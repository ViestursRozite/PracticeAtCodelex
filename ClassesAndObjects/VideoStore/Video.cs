using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _taken;
        private List<int> _rating;

        public Video(string title, bool RentedOut = false)
        {
            this._title = title;
            this._taken = RentedOut;
            this._rating = new List<int>();
        }

        public string Name
        {
            get => _title;
        }

        public bool Taken
        {
            get => _taken;
            set => _taken = value;
        }

        public void CheckOut()
        {
            this._taken = true;
        }

        public void Return()
        {
            this._taken = false;
        }

        public void Rate(int rating)
        {
            this._rating.Add(rating);
        }

        public void ListRatings()
        {
            Console.WriteLine("[{0}]", String.Join<int>(", ", this._rating));
        }
        public double ReturnAvgRating()
        {
            double result = 0;
            int count = 0;

            foreach (int rating in this._rating)
            {
                result += rating;
                count++;
            }
            return (result / count);
        }
    }
}
