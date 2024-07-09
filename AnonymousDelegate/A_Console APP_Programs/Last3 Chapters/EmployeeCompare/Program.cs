using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1989, "Zee");
            Employee e2 = new Employee(2003, "Rakhi");
            Employee e3 = new Employee(1987, "Milton");
            Employee e4 = new Employee(1905, "Sam");
            //IComparable i = e1;
            //int response;
            //response = i.CompareTo(e2);
            //          if (response <0)
            //    Console.WriteLine("e1 is less than e2");
            //else if (response > 0)
            //    Console.WriteLine("e1 is greater than e2");
            //else
            //    Console.WriteLine("equal");
          Employee[] ar = new Employee[4];
            ar[0] = e1;
            ar[1] = e2;
            ar[2] = e3;
            ar[3] = e4;
            Array.Sort(ar);
            foreach (Employee e in ar)
            Console.WriteLine(e);
            Console.ReadKey();

        }
    }
}
