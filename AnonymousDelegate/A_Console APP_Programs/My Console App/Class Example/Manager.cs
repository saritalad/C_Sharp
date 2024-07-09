using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Example
{
    class Manager:Employee
    {
        Decimal foodallowance;

        public Decimal Foodallowance
        {
            get { return foodallowance; }
            set { foodallowance = value; }
        }
        Decimal otherallowance;

        public Decimal Otherallowance
        {
            get { return otherallowance; }
            set { otherallowance = value; }
        }
        // default constructor
        public Manager():base()
        {
            foodallowance = 1000;
            otherallowance = 500;
        }
        public Manager(decimal f,decimal o,int id,string empnm,Date doj,decimal b_sal):base(id,empnm,doj,b_sal)
        {
            foodallowance = f;
            otherallowance = o;
        }
        public override void calculate_sal()
        {
            Basic_sal =  Basic_sal +foodallowance + otherallowance;
         Console .WriteLine ("Salary Of Manager is {0:c}",Basic_sal);     
        }
        public override string ToString()
        {
            return Empid + "\t" + EmpName + "\t" + Doj;
        }

    }
}
