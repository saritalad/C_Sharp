using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEnumerable_Example
{
    class Student
    {
        int id;
        string name;
        public Student(int i, string s)
        {
            id = i;
            name = s;
        }
        public override string ToString()
        {
            return id+"\t"+name ;
        }
        
    }
}
