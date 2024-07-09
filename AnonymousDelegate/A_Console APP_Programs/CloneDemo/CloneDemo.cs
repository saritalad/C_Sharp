using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShallowCloneDemo
{
    class Employee : ICloneable
    {
        public int EmpNo{get;set;}
        public string Name {get; set;}
        public float salary { get; set; }
//shallow cloning
        //public object Clone()
        //{
        //    Employee emp= new Employee();
        //    emp.EmpNo=this.EmpNo;
        //    emp.Name=this.Name;
        //    emp.salary=this.salary;
        //    return emp;
        //}
        //Deep Cloning
        public object Clone()
        {
            return this;
        }



    }
}
