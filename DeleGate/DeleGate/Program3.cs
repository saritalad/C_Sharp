using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleGate
{
   
        delegate int delsum(int x, int y);
        delegate void PrintDel(string a, string b);
        delegate void SumDel(int a, int b);
        delegate int RSumdel(int a, int b);
        public class Program3
        {
            public delegate string GreetingsDelegate(string name);

          static void Main(string[] args)
            {  PrintDel Print=delegate(string a,string b)
                {
                    Console.WriteLine("Full Name "+a+ " "+b);
                };

        Print("Sarita", "lad");
        SumDel sumObj = delegate (int a, int b)
        {
            Console.WriteLine("Sum = " + (a + b));
        };
        sumObj(23, 33);
        RSumdel Robj = delegate (int a, int b)
        { return a + b; };
        int ans = Robj(2, 4);
        Console.WriteLine(ans);
            //   
            }
        }
    }
}
