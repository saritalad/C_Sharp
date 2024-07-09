using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            Console.WriteLine(d1);
            Date d2 = new Date(15, 8, 2012);
            Console.WriteLine(d2);
          //  Employee e1 = new Employee();
            Employee e2 = new Employee(1234, "Mr Bill Clinton", new Date(14, 5, 2012), 34000.0M);
         //   Employee e3 = new Employee(34, "Mr Bush", d2, 5000);
            Manager m1 = new Manager(2000, 1560,125,"Mr Rao",d1,12000);
            Employee.Display_salary(m1);
          //  Employee[] emp = new Employee[3];
            Console.WriteLine("GetType :" + e2.GetType());
            if (typeof(Manager) == m1.GetType())
                Console.WriteLine(m1.EmpName + "is Manager ");
            else
                Console.WriteLine(m1.EmpName + " is simply a Employee ");


            //emp[0] = e1;
            //emp[1] = e2;
            //emp[2] = e3;
            //Console.WriteLine("ëmployees before sorting ");
            //foreach (Employee e in emp)
            //    Console.WriteLine(e);
            //Array.Sort(emp);
            //Console.WriteLine("  ëmployees After sorting ");
            //foreach (Employee e in emp)
            //    Console.WriteLine(e);
            
            
            
            // as EmpName is readonly Property ,can not assign new value
          //  e1.EmpName = "SSS";
            //Console.WriteLine(e1.Empid);
            // Console.WriteLine(e1);
            //Console.WriteLine(e2);
            //e1.Empid = 3;
            //Console.WriteLine(e3);
            //Console.WriteLine(e1);  
            //Employee.Display_salary(e1);
            //Employee.Show_empCount();
            //Manager m1 = new Manager();
            //Manager m2 = new Manager(2000, 570, 111, "Mr Bush", d2, 45000.99M);
            //Console.WriteLine(m1);
            //Console.WriteLine(m2);
            //Employee e1 = new Employee();
            //e1.calculate_sal();
            //Console.Write("Employee Sal = ");
            //e1.display_sal();
            //m1.calculate_sal();

            //Console.Write("Manager  m1 Sal = ");
            //m1.display_sal();
           
            //m2.calculate_sal();
            //Console.Write("Manager m2 Sal = ");
            //m2.display_sal();
            //Console.WriteLine(d1.ToString ());


            Console.ReadLine();
        }
    }
}
