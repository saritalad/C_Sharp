using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is a function because reusable");
            int radius = 10;
     double   A = Area_Circle(radius);
            ShowLine();
            Console.WriteLine("area of circle "+A+ "Radius = "+radius);
            A= Area_Circle();
            Console.WriteLine("area of circle " + A);
            ShowLine();
            Area(radius);
        }
        // reusable code is called function
        // 2 types
        // 1 system defined
        // user defined
 
        
        public  static   double  Area_Circle(int radius)
        {
            radius += 5;
            return Math.PI * radius * radius;
         
        }
        public static void ShowLine()
        {
            Console.WriteLine("........................................");
        }
        public static double Area_Circle()
        {
            int radius;
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            return Math.PI * radius * radius;

        }

        public static void Area(int r)
        {
            Console.WriteLine("Area of circle value displayed from AreaFNT" + Math.PI * r * r);
        }
    }
}
