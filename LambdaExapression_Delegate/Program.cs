using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExapression_Delegate
{delegate string mylambdadel(string name);
    delegate void mylambdadel1(string name);
    delegate void mydelegate(int x);
    delegate int delsum(int a, int b);
    delegate void mydel(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {  

            
            delsum obj1 = (int a, int b) => { return a + b; };
            Console.WriteLine("sum = " + obj1(24, 36));
            mydel obj2 = (int a, int b) => { Console.WriteLine("multiplication of 2 no. = "+a*b); };

            obj2(2, 4);


        //    Func<int, int> Square = n => n * n;
        //int ans=    Square(5);
        //    Console.WriteLine("Ans = "+ans);
        //    Func<int, int, int, int> Sum = (a, b, c) => a + b + c;
        //    ans = Sum(1, 2, 3);
        //    Console.WriteLine("Ans = " + ans);
        //    Func<int, int, int, string> SUM = (a, b, c) => (a + b + c).ToString();
        //    Console.WriteLine(SUM(2,3,4));
        }
       
        public static void Square(int s)
        {
            Console.WriteLine("Square ="+s*s);
        }
    }
}
