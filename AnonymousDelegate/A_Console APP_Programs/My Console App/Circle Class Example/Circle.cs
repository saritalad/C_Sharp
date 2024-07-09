using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle_Class_Example
{
    class Circle
    {
       double  radius;
        public Circle()
        {
            radius = 7.9f;
        }
        public Circle(double r)
        {
            radius = r;
              }

        public override string ToString()
        {
            double a = Math.PI * radius * radius;
            return "Radius ="+ radius +" Area  = "+a;
        }


    }
}
