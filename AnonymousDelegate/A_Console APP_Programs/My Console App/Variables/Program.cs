using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            var num = 10;
            var fnum = 20.5f;
            var name = "Seed";
           
            Console.WriteLine(" num " + num + " fnum =" + fnum + "name :" + name);

            //num = 50.6f;
            //fnum = 3;
            //name = 5;
// error generated because datatype is decided by initial value assigned to variables

            Console.ReadLine();
        }
    }
}
