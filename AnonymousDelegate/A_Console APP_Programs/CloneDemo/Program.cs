using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloneDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.EmpNo = 1;
            e1.Name = "Ashu";
            e1.salary = 15000;
            Console.WriteLine("{0} {1} {2}", e1.EmpNo, e1.Name, e1.salary);
            Employee e2 = new Employee();
            e2 =(Employee)e1.Clone();
            e2.salary = 20000;
            Console.WriteLine("{0} {1} {2}", e1.EmpNo, e1.Name, e1.salary);
            Console.WriteLine("{0} {1} {2}", e2.EmpNo, e2.Name, e2.salary);
            Console.ReadKey();

        }
    }
}
