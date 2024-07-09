using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //string studentDetails;
            //Console.WriteLine("enter student details ");
            //studentDetails = Console.ReadLine();
              
            //string[] data = studentDetails.Split(',');
            //foreach (string s in data)
            //    Console.WriteLine(s);

            String str = "ABC Computers";

            Console.WriteLine("String    : " + str);

            // retrieve the substring from index 5
            Console.WriteLine("Sub String1: " + str.Substring(5));

            // retrieve the substring from index 8
            Console.WriteLine("Sub String2: " + str.Substring(8));
            string Name = "Sarita";
            Console.WriteLine(Name.Substring(3));
            if (Name.StartsWith("Sa"))
               
            Console.WriteLine("Yes");

            Console.WriteLine("Index of " + Name.IndexOf("ar"));
            Console.WriteLine(String.Format("{0,15}{1,20}",Name,str));

        }
    }
}
