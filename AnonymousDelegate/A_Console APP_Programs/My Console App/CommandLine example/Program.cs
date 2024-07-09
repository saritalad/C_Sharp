using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLine_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum = sum + Convert.ToInt32(args[i]);
            }
            Console.WriteLine("Sum of arguments =" + sum);
        
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }




          
        
        
        }
    }
}
