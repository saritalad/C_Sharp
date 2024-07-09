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

        int IComparable.CompareTo(object obj)
        {
            Student s = (Student)obj;
            if (this.id > s.id)
                return (1);
            if (this.id < s.id)
                return (-1);
            else
                return (0);
        }

        public override string ToString()
        {
            return Id + "\t" + Name;
        }
    }
}
