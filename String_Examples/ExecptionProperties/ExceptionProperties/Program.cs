using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                f1();

            }

            catch (Exception e)
            {
                Console.WriteLine("Message  :"+e.Message );//what kind of error occured message 
                Console.WriteLine("StackTrace  :"+e.StackTrace) ;// tracing of error in the functions how it is moving from one fnt to another
                Console.WriteLine("TargetSite "+e.TargetSite);// exaction location i.e. function name where error has occured
            }

        }



        public static void f1()
        {

            f2();
        }
        public static void f2()
        {
            f3();

        }

        public static void f3()
        {

            int x = 10, y = 0;
            Console.WriteLine("x/y = "+x/y);

        }
    }
}
