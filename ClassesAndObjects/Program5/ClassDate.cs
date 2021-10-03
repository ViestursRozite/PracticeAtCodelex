using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Date
    {
        string month, day, year;

        public Date(string month, string day, string year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }

        public string Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        public string Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
        public string Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}
