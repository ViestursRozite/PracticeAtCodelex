using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Date
    {
        string day, month, year;

        public Date( string day, string month, string year)
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

        public string DisplayDate()
        {
            Console.WriteLine($"{Day}/{Month}/{Year}");
            return $"{Day}/{Month}/{Year}";
        }
    }
}
