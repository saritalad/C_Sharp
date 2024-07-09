using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                fun1();
            }

            catch (System.DivideByZeroException  e)
            {
                Console.WriteLine("Message Property" + e.Message);
        Console.WriteLine("Source Property" + e.Source);
         Console .WriteLine ("TargetSite Property"+e.TargetSite);
            Console.WriteLine("Stack Trace Property " + e.StackTrace);
            
            }

        }


        public static void fun1()
        {
            Console.WriteLine("Calling Function 2");
            fun2();
        }
        public static void fun2()
        {
            Console.WriteLine("Calling Fun 3");
            fun3();
        }
        public static void fun3()
        { int x= 23;
            int y=0;
            x=x/y;
            Console .WriteLine ("x = "+x);
        }
    }
}
