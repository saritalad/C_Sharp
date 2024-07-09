using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simplearray
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte[] m;
            m = new sbyte[10];
            for (int i = 0; i < 5; i++)
            { m[i] = -2; }
            foreach (sbyte x in m)
            {
                Console.WriteLine(" element {0}", x);
            }
            float[] f;
            f = new float[10];
            for (int i = 0; i < 5; i++)
            { f[i] = i * 2.5f; }
            foreach (float x in f)
            {
                Console.WriteLine(" element float {0}", x);
            }
            int[,] ia = new int[2, 2];
            int lb1 = ia.GetLowerBound(0); // dimension 1
            int lb2 = ia.GetLowerBound(1); // dimension 2
            Console.WriteLine(lb1); // 0
            Console.WriteLine(lb2); // 0
            Console.ReadKey();


        }
    }
}
