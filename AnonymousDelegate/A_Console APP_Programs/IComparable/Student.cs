using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparable_Demo
{
    public class Student:IComparable
    {
        int id;
        string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // s1.CompareTo(s2);
        //int IComparable.CompareTo(object obj)
        //{                               // int sum; typecast
        //    Student s = (Student)obj;   //float avg=(float)sum/7;
        //    if (this.id > s.id)
        //        return (1);     
        //    if (this.id < s.id)
        //        return (-1);
        //    else
        //        return (0);
        //}
        int IComparable.CompareTo(object obj)
        {
            Student s = (Student)obj;
       return     String.Compare(this.Name, s.Name);

        }



        public override string ToString()
        {
            return Id + "\t" + Name;
        }
    }
}
