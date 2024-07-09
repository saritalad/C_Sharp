using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class_Example
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Vehicle v ; ref
            Car mycar = new Car();
            mycar.GetSpeed(120);
            mycar.show_speed();
            //explicit implementation of interface
          //  p1 is reference of IPrintable interface
            IPrintable p1 = mycar;// int v=10,*p; p=&v;
            p1.show_details();
            //d1 is reference of Idisplayable 
            IDisplayable d1 = mycar;
            d1.show_details();
            //Car yrcar = new Car("TAta", "Punto", 6, "Red", true);
            //yrcar.GetSpeed(180);
            //yrcar.show_speed();
            //d1 = yrcar;
            //d1.show_details();
            Vehicle v = new Car();

           


           
        }
    }
}
