using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethod_Example
{
    class Employee
    {
        public int Id;
        public string name;
        public decimal salary;

        public Employee(int id, string nm, decimal sal)
        {
            Id = id;
            name = nm;
            salary = sal;

        }
        protected virtual decimal getGrossSalary()
        {
            return salary;
        }


        public static void ShowGrossSalary(Employee emp)
        {

            decimal gross = emp.getGrossSalary();
            Console.WriteLine("Gross Salary =" + gross);


        }



    }
}
