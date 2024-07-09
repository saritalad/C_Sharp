using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod_Example
{
    class Program
    {
        static void Main(string[] args)
        {
             Manager m1 = new Manager(10, 300, 123, "Bill", 10000);
            Employee e1 = new Employee(123, "Bill", 10000);
            Employee.ShowGrossSalary(m1);// late binding , dynamic , runtime 
            Employee.ShowGrossSalary(e1);// eary binding ,static 
        }
    }
}
