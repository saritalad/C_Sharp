using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethod_GenericClass
{
    class MyGenericClass<T>
    {
        T  a;
        T  b;
        public MyGenericClass(T x, T y)
       {
            a=x;
            b=y;
            }
        public void Write()
        {
            Console.WriteLine(" a = "+a + " b = "+b);
        }


    }
}
