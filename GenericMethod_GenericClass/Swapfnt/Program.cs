using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapfnt
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a = 100, b = 200;
            swap1(a, b);// call by value 
            Console.WriteLine(" call by value a= "+a+" b ="+b);
            swap2(ref a, ref b);// call by value 
            Console.WriteLine(" call by ref a= " + a + " b =" + b);
            Swapfnt(ref a, ref b);
            Console.WriteLine(" call by ref a= " + a + " b =" + b);
            float x = 2.5f, y = 7.5f;
            Swapfnt(ref x, ref y);
            Console.WriteLine(" call by ref x= " + x + " y =" + y);
        }

        public static void swap1(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("inside function swap1 a ="+a+"b="+b);
        }

        public static void swap2(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //  generic function
        public static void  Swapfnt<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

        }

    }
}
