using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections ;
//Value 
// Condition 
 
//Less than zero 
// strA is less than strB. 
 
//Zero 
// strA equals strB. 
 
//Greater than zero 
// strA is greater than strB. 
 

namespace EmployeeCompare
{
    class Employee:IComparable 
    {
        int year;
        string empname;
         public int Year
        {
            get { return year; }
            set { year = value; }
        }
       public string Empname
        {
            get { return empname; }
            set { empname = value; }
        }
        public Employee(int y, string nm)
        {
            year = y;
            empname = nm;
        }
        int IComparable.CompareTo(Object obj)
        {
            Employee e = (Employee)obj;
            return String.Compare(this.Empname, e.Empname);
        }

        public override string ToString()
        {
            return "name: "+empname +"  year :"+year ;
        }

         //int IComparer.Compare(object o1, object o2)
        //{
        //    Employee e1 = (Employee)o1;
        //    Employee e2 = (Employee)o2;
        //    return string.Compare(e1.empname, e2.empname);
        //}

        //int IComparable.CompareTo(Object obj)
        //{
        //    Employee e = (Employee)obj;
        //    if (this.year < e.year)
        //        return -1;
        //    else if (this.year > e.year)
        //        return 1;
        //    else
        //        return 0;


        //}
        //int IComparer.Compare(Object o1, Object o2)
        //{
        //    Employee e1 = (Employee)o1;
        //    Employee e2 = (Employee)o2;
        //    if (e1.year < e2.year)
        //        return 1;
        //    else if (e1.year > e2.year)
        //        return -1;
        //    else
        //        return 0;
        //}

    }

    }
