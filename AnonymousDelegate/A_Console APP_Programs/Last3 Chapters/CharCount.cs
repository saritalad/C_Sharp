using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
  
namespace FindCountCharOccurance  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            string strOccur,strChar = null;  
            Console.WriteLine("Enter the string in which you need to find the count of a char occurance");  
            strOccur = Console.ReadLine();  
              
            Console.WriteLine("Enter the char to be searched..");  
            strChar = Console.ReadLine();  
            int intCnt =strOccur.Length- strOccur.Replace(strChar, string.Empty).Length;  
            Console.WriteLine("Count of occurance is "+intCnt);  
            Console.ReadLine();  
        }  
    }  
}  