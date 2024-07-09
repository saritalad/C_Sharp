using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
          //  string str = "hello@123:*&^789'!@#$*()_+=";
            string str = "h$$$%7";
            int count = 0;
            foreach (char c in str)
            {
             // char.IsLetterOrDigit(string ,int ))returns boolean output
                 
                if (!char.IsLetterOrDigit(c.ToString(), 0))
                {
                    count++;
                }
            }
            Console.WriteLine("count ="+count);
        }
    }
}
