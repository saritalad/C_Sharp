using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyException:Exception 
    {
        public MyException(string msg)
            : base(msg)
        {
        }
        

    }

    



}