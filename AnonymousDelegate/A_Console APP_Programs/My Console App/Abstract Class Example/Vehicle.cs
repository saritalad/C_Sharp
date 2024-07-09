using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class_Example
{
   abstract class Vehicle
    {
        int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public abstract void show_speed();
        
   
       // public abstract void Show_capacity();

    }
}
