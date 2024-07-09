using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate_to_handle_event
{public delegate void Markdel();
    class Student
    {
        public int marks;
        //public Student()
        //{
        //    marks = 10;
        //}

        public event Markdel Pass;
        public event Markdel Fail;
        public void Entermarks(int marks)
        {
            if (marks >= 40)
            {
                Pass();
            }
            else
            {
                Fail();
            }

        }

    }
} 
