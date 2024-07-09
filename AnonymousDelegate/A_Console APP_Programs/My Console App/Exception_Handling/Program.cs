using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=10, y,z;
            try 
            {
                //Console.WriteLine("Enter a number");
                //y = Convert.ToInt32(Console.ReadLine());
                //z = x / y;
                //Console.WriteLine("x/y =" + z);

                fun1();
            }

            catch (Exception e)
            {
               // Console.WriteLine(e.Message);
               // Console.WriteLine("Source of exception "+ e.Source);
              //  Console.WriteLine("TargetSite of exception " + e.TargetSite);
                Console.WriteLine("Stacktrace of exception " + e.StackTrace);
            }




            //catch (DivideByZeroException d)
            //{
            //    Console.WriteLine(d.Message);
            //}

            //catch (FormatException f)
            //{
            //    Console.WriteLine(f.Message);
            //}


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
        {
            int x = 25;
            int y = 0;
            x = x / y;
            Console.WriteLine("x = " + x);
        }


    }
}
