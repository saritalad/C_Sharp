using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_example1
{delegate void strdel(string x);
    class Program
    {
        public static void ConvetoUpper(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        public static void ConvertoLower(string s)
        {
            Console.WriteLine(s.ToLower());
        }
        static void Main(string[] args)
        {
            strdel mydel = new strdel(ConvetoUpper);
            mydel += new strdel (ConvertoLower );
            mydel ("Swati Wankhade");
            Console .ReadKey ();
        }
    }
}
