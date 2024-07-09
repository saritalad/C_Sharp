using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethod_Example
{
    class Manager:Employee 
    {
        public int salqty;
        public decimal commision;
        public Manager(int s, decimal c, int id, string name, decimal sal) : base(id, name, sal)
        {
            salqty = s;
            commision = c;
        }
        protected override decimal getGrossSalary()
        {
            return salary + salqty * commision;
        }
    }
}
