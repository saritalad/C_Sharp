using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_with_Student_Delegate
{ delegate void Markdel();
        class Student  // publisher class
    {

        public int Id;
        public string Name;
        public int Marks;
        public event Markdel Pass;
        public event Markdel Fail;
        public void DeclareResult(int m)
        {
            if (m >= 50)
                Pass();
            else
                Fail();
        }

    }
}
