using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCircle
{
    class Program
    {                                                                                             
        static void Main(string[] args)
        {
            //int i;
            //int[] myarray = new int[5];
            //Console.Write("Pls enter 5 numbers");
            //for (i = 0; i < 5; i++)
            //{
            //    myarray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(myarray[i]);
            //}  
            int[,] myarray = new int[2,3];
           int i,j;

           Console.WriteLine("Please enter 6 numbers"); 
            for( i=0;i<2;i++)
            {
                for( j=0;j<3;j++)
                { 
                myarray[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(" {0}  ", myarray[i, j]);
                }
                Console.WriteLine();
            }
           // //Double radius, area, pi = 3.14;
           // //Console.WriteLine ("Ënter radius ");
           // //    radius =Convert.ToDouble(Console.ReadLine ());
           // //    area = pi * radius * radius;
           // //    Console.WriteLine("area of Circle ={0:F3}", area);
           //    Console.ReadLine();
        }
    }
}
