using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleGate
{
  public   delegate void transformer(int x);
    class Program2
    {
        //static void Main(string[] args)
        //{ int x=10; transformer t;
        // t = Square;
        //      t.Invoke(x);
        //    //2  delegate declared with anonymous method 
        //    t = delegate (int s) { Console.WriteLine("Anonymous method square  =" + s * s); };
        //    t.Invoke(5);
        //    // lambda expression
        //    t = (int s) => { Console.WriteLine("Lambda expression square  =" + s * s); };
        //    t.Invoke(9);
        //}
        //// 1 named method 
        //public static void Square(int s)
        //{
        //    Console.WriteLine("named method  square  =" + s * s);
        //}
    }
}
