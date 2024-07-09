using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_Example2
{delegate void add_delegate(int x,int y);
    class Program
    {
        public static void  add(int x,int y)
        {
            Console .WriteLine ("x+y =" +(x+y));
        }
        public static void substract(int x,int y)
        {
            Console .WriteLine ("x-y = "+(x-y));
        }
        public static void multiply(int x,int y)
        {
            Console .WriteLine ("x * y =" +( x*y));
        }
        public static void division(int x, int y)
        {
            Console.WriteLine("x / y =" + (x / y));
        }

        static void Main(string[] args)
        {
            add_delegate opt = new add_delegate(add);
            opt += new add_delegate(substract);
            opt += new add_delegate(multiply);
            opt += new add_delegate(division);
            opt(80, 40);
            Console.ReadKey();

        }
    //        delegate [] dellist = opt.GetInvocationList ();
    //            for (int i=0; i < dellist.length;i++)
    //{
    //    ((add_delegate )(dellist [i])).invoke (80,40);
    //}

        }
    }

