using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDelegate
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employeelist = new List<Employee>()
                {new Employee{Id=101,Name="Bill"},
                    new Employee{Id=102,Name="Mill"},
                    new Employee{Id=103,Name ="Gill"}
                };

            Func<Employee,string > selector = employee => "Name :" + employee.Name;
            IEnumerable<string> names = employeelist.Select(selector);
           // IEnumerable<string> names =employeelist.Select( employee => "Name :" + employee.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}
