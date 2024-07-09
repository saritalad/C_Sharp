using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod_Example
{
    delegate void SumDel(int a, int b);
    delegate void SquareDel(int a);
    class Program
    {
        static void Main(string[] args)
        {
            // SumDel obj = delegate (int a, int b) {Console.WriteLine("Sum = " + (a + b));};
               SumDel obj = (a, b) => { Console.WriteLine("sum =" + (a + b)); };
            obj(5, 7);
            obj.Invoke(6, 7);
            SquareDel obj1 = (a) => { Console.WriteLine("Square = " + (a * a)); };
            obj1(5);


            IList<int> marks = new List<int>();

            marks.Add(12);
            marks.Add(34);
            marks.Add(90);
            marks.Count(x => x > 30);

        }

        //public void Sum(int a,int b)
        //{

        //    Console.WriteLine("Sum = "+(a+b));
        //}

    }
}
