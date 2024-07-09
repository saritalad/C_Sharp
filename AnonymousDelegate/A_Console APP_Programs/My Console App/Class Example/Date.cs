using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Example
{
    class Date
    {
        int day;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
         
        public Date()
        {
            day = 12;
            month = 8;
            year = 1947;
        }
        public Date(int d,int m,int y)
        {
            day =d;
            month = m;
            year = y;
        }
        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }

        //public override bool Equals(object obj)
        //{
        //    Date d = (Date)obj;
        //    if (this.year == d.year)
        //        if (this.month == d.month)
        //            if (this.day == d.day)
        //                return true;
        //            else return false;
        //}


    }
}
