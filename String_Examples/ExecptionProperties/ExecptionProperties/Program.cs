using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] s)
        {
          //  int x = 10,y;// type safe  code
          //  var z = 56;
          //  var name = "Sarita";// not type safe 
          ////  var lname;//no 
          //  try
          //  {
          //      Console.WriteLine("enter a number ");
          //      y = Convert.ToInt32(Console.ReadLine());

          //      Console.WriteLine("x/y =" + x / y);
            
          // }
                         
          //  catch (System.FormatException p)
          //  {
          //      Console.WriteLine(p.Message + " please enter a number not a word");

          //  }
          //  catch (System.DivideByZeroException e)
          //  {
          //      Console.WriteLine(e.Message);
          //  }

          //  finally
          //  {
          //      Console.WriteLine("Bye Bye ");
          //  }


            //try
            //{
            //    int x = 25, y = 4;
            //    if (y % 5 != 0)
            //        throw new MyException("Multiple of 5");
            //    Console.WriteLine(x / y);
            //}
            //catch (MyException ex)
            //{
            //    Console.WriteLine(ex.Message );
            //}


            //Console.WriteLine(s[0]);
            //Console.WriteLine(s.Length);

            A a = new B();
            C c =new C();
            A x = (A)c;




            Console.ReadKey();

                    }



      





    }

    class A
    {
    }
    class B : A { }
    class C : A { }

       




}
