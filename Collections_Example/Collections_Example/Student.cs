using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Example
{
    class Student
    {public int rollno { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return rollno + " " + Name;
        }
    }
}
