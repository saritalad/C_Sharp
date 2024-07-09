using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread th = Thread.CurrentThread;
            //th.Name = "MainThread";
            //Console.WriteLine("This is {0}", th.Name);
           // ThreadStart childref = new ThreadStart(CallToChildThread);// it is delegate Threadstart 
           // Console.WriteLine("In Main: Creating the Child thread");
          //  Thread childThread = new Thread(childref);
          //  childThread.Start();


            Thread t1 = new Thread(Function);
          Thread t2=new Thread(CallToChildThread);
            
               t1.Start();
              t2.Start();
             t1.Join();
            t2.Start();
            t2.Join();
           t1.Start();
            Console.ReadKey();
        }




        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
        }


        public static void Function()
        {
            for(int i=0;i<10;i++)
            {
                Thread.Sleep(300);
                Console.WriteLine(i);
            }
            Console.WriteLine("End");

        }




    }
}
