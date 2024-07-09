using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ananymousdel
{delegate void mydelegate();
    delegate int Sqrdelegate(int num);
    class Program
    {
        static void Main(string[] args)
        {
            mydelegate delobj = delegate()
            {

                Console.WriteLine("My anonymous Body");
            };
            delobj();
            Sqrdelegate sqtdelobj = delegate(int  num)
            {

                return (num * num);
            };
            Sqrdelegate cubedel = delegate(int num)
            {
                return (num * num * num);
            };


            Console.WriteLine("Cube of number " + cubedel(3));
          Console .WriteLine ("Square with delegate ananymous method "+  sqtdelobj(5));
        }
    }
}
