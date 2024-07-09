using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_to_handle_event
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            int m;
            Console.WriteLine("Pls enter marks of student");
            m = Convert.ToInt32(Console.ReadLine());
            s1.Pass += new Markdel(Showmessage.GoodResult);
            s1.Fail += new Markdel(Showmessage.BadResult);
            s1.showmarks(m);
            Console.ReadKey();
        }
    }
}
