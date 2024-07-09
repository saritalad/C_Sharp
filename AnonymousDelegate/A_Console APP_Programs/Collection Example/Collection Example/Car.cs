using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection_Example
{
    class Car
    {
        int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Car(int i, string s)
        {
            year = i; model = s;
        }
        public override string  ToString()
        {
            return Year  +"\t"+ Model  ;
        }
    }
}
