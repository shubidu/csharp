using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateLib
{
    public class Date
    {
        private int day;
        private int month;
        private int year;
        private static string[] allMonths = new String[]
        {"","January","February", "March", "April", "May", "June", "July", "August", "September",
            "Octomber", "November", "December"};

        public Date(int d, int m, int y)
        {
            Day = d;
            Month = m;
            Year = y;
        }

        public Date() : 
            this(0, 0, 0)
        { }
        
        public Date(Date d)
            : this(d.Day, d.Month, d.Year)
        { }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return Day;
                else if (index == 1)
                    return Month;
                else if (index == 2)
                    return Year;
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index == 0)
                    Day = value;
                else if (index == 1)
                    Month = value;
                else if (index == 2)
                    Year = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        

        public int Month
        {
            get { return month; }
            set { if(value >=1 && value <= 12) month = value; }
        }
        

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1:D2}, {2}", allMonths[Month], Day, Year);
        }
    }
}
