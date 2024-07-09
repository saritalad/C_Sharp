using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousDelegate
{// f8 for break point and f11 for step in 
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        public delegate float PointerToFun(float r);
        static void Main(string[] args)
        {

       
            PointerToFun CircleArea = delegate (float r)
              {
                  return 3.14f* r * r;

              };


          float a=  CircleArea(9);
            Console.WriteLine(a);

        }


    }

   
}
