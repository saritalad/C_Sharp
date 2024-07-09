using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenetHandlingExample
{
    delegate void Markdel();
    class Student // Publisher class 
    {
        public int Id;
        public string Name;
        public int marks;
       public    event Markdel  Pass;
       public    event Markdel  Fail;
        public void EnterMarks(int m)
        {
            if (m >= 50)
                Pass();
            else

                Fail();


        }


    }
}
