using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStart_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            // Thread t1 = new Thread(new ThreadStart(PrintNumbers));
            // Thread t1 = new Thread(delegate () { PrintNumbers(); });
           // Thread t1 = new Thread(() =>number.PrintNumbers());
            
           // t1.Start();
        }
           
        }
   
    class number
    { public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
      
        }
    } 
}
