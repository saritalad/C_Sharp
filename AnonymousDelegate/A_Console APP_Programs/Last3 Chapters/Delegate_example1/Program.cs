using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_example1
{   //step1 to declare delegate 
    delegate void strdel(string x);

   delegate void arithmeticdel(int a,int b);
    class Program
    {// step 2 define methods to provide their addressto delegate
        public static void ConvetoUpper(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        public static void ConvertoLower(string s)
        {
            Console.WriteLine(s.ToLower());
        }

        static void Main(string[] args)
        {// step 3 :create obj of strdel delegate and pass method name to constructor
            // Unicast delegate : delegate which executes single method
            // Multicaste delegate : delegate which executes multiple methods
          
            
            strdel mydel = new strdel(ConvetoUpper);
            
            mydel += new strdel (ConvertoLower );

          //  ConvertoLower("Mihir Argade");
            mydel ("Swati Wankhade");
            Console .ReadKey ();
        }
    }
}
