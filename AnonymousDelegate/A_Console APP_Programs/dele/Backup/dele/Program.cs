using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate_to_handle_event
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            int m;
            Console.WriteLine("please enter marks of student ");
            m = Convert.ToInt32(Console.ReadLine());

         //s1 is object on which Pass event is fired or Fail event is fired
         // and if Pass event is fired Markdel delegate handles it with GoodResult Method
            s1.Pass += new Markdel(showmessage.GoodResult);
            s1.Fail += new Markdel(showmessage.BadResult);
            s1.showmarks(m);
            Console.ReadLine();

        }
    }
}
