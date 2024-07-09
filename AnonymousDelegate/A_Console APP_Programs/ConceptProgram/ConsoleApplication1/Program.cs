using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        abstract class myclass
        {
            public void mymethod()
            {
                Console.Write("Hello");
            }

            public abstract void myabmethod();
            public virtual void  newmethod()
            { Console .WriteLine ("Parent method");
            }

        }

        class childclass : myclass
        {
            public  override void myabmethod()
            {
                Console.Write(" derived ab method");
            }

            public new  void  newmethod()
            {
                Console.WriteLine("Child method with new");
            }
        }
        static void Main(string[] args)
        {
            myclass c1;
            childclass c2 = new childclass();
            c1 = c2;
            c1.myabmethod();
            c2.mymethod();
            c2.newmethod();
            c1.newmethod();


        }
    }
}
