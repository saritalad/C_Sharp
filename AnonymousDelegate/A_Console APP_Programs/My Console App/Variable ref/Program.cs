using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variable_ref
{
    class Program
    {
       
       
        static void Area_Circle(float r, out float area)
        {
            area = (float)Math.PI * r * r;
        }

        public static void Rect_Area(int l, int b, out int A)
        {
            A = l * b;

        }
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }
        //call by values
        static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int x = 40,y=90;
            //swap(x, y);
           Swap(ref x, ref y);
            Console.WriteLine("x = {0} and y = {1} ", x, y);
            //float radius, Area;
            //Console.WriteLine("Pls enter radius");

            //radius = (float)Convert.ToDouble(Console.ReadLine());
            //Area_Circle(radius, out Area);
            //Console.WriteLine("Area of Circle is {0:f}", Area);
           
            
            
            
            int length, breadth,A;
            Console.WriteLine("Pls enter length and breadth ");
          
            length = Convert.ToInt32(Console.ReadLine());
            breadth = Convert.ToInt32(Console.ReadLine());

            Rect_Area(7, 8, out A);
            Console.WriteLine("Area of rectagle ={0}" + A);
 


        }
        
        
    }
}
