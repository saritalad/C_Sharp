using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Delegates Overview

//Delegates have the following properties:

//   Delegates are similar to C++ function pointers, but are type safe.
//    *
//      Delegates allow methods to be passed as parameters.
//    *
//      Delegates can be used to define callback methods.
//    *
//      Delegates can be chained together; for example, multiple methods
//can be called on a single event.
//    *
//      Methods don't need to match the delegate signature exactly. 


namespace DelegateExamples
{ delegate int mydelegate(int a ,int b); // step 1 declaration

    class Program
    {
       

        static void Main(string[] args)
        {
           mydelegate do_operation = new mydelegate(Sum);//step 2 instantiation 
        
          int z= do_operation(20, 5);//step 3 execution of method passing param
          Console.WriteLine("Sum =" + z);
          
            Console.ReadLine();  
        }
        public static int Sum(int x,int y)
        {
            
            return(x+y);
        }


        public static void Subtract(int x, int y)
        {

            Console.WriteLine("x-y =" + (x - y));
        }
       
    }
}
