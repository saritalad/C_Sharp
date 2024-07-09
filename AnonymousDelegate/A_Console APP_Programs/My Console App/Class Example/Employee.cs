using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Example
{
    class Employee : IComparable 
    {
        int empid;

        public int Empid
        {
            get { return empid; }
            set { empid = value; }
        }
        string empName;
        public string EmpName
        {
            get { return empName; }

        }

        Date doj;

        internal Date Doj
        {
            get { return doj; }
            set { doj = value; }
        }
        decimal basic_sal;

        public decimal Basic_sal
        {
            get { return basic_sal; }
            set { basic_sal = value; }
        }
        public static int empcount = 0;
        public Employee()
        {
            empid = 1;
            empName = "Mr Bill Gates";
            doj = new Date();
            basic_sal = 10000.00M;
            empcount++;
        }

        public Employee(int e,string s,Date dt,decimal sal)
        {
            empid = e;
            empName =s;
            doj = dt;
            basic_sal = sal;
            empcount++;
        }
        public override string ToString()
        {
            return empid + "\t" + empName + "\t" + doj + "\t Rs" + basic_sal;
        }

        public static void Show_empCount()
        {
            Console.WriteLine("Total Employee objects created" + empcount);
        }
        public virtual void calculate_sal()
        {
           Console.WriteLine ("Salary of Employee :{0:c}", basic_sal);
        }
        public void display_sal()
        {
            Console.WriteLine(basic_sal);
        }

        public static void Display_salary(Employee emp)
        {//Console.WriteLine ("Salary is "+emp.ComputeSalary());
           emp. calculate_sal();
        }
        //int IComparable.CompareTo(object obj)
        //{
        //    Employee other = (Employee)obj;
        //    if (this.basic_sal < other.basic_sal)
        //        return -1;
        //    else if (this.basic_sal > other.basic_sal)
        //        return 1;
        //    else return 0;

        //}
        //sorting of employee array will be on empName
        int IComparable.CompareTo(Object obj)
        {
            Employee other = (Employee)obj;

            return string.Compare(this.EmpName, other.EmpName);

        }




    }
}
