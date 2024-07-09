using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_to_handle_event
{
    public delegate void Markdel();
    class Student
    {
        public int marks;
        public Student()
        {
            marks = 10;
        }
        public event Markdel Pass;
        public event Markdel Fail;
        public void showmarks(int marks)
        {
            if (marks >= 40)
            {
                Pass();
            }
            else 
            {
                Fail ();
            }
       
    }
    }
}
    