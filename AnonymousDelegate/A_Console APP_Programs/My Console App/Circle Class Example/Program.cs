using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle_Class_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle(5.5);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
