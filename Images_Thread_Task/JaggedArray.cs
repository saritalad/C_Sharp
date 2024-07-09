using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jArray = new int[3][]{
                new int[3]{1, 2, 3},

                new int[4]{4, 5, 6, 7},
                new int[2]{7,8}

            };


            // to take number of teams   outer array dimension
          


             


            for (int i = 0; i < jArray.Length; i++)
            {
                for (int j = 0; j < (jArray[i]).Length; j++)//  jArray[0] name of first arry  jArray[0][0] jArray[0][1]jArray[0][2] 
                { Console.Write(jArray[i][j]+" "); }          //jArray[1]--->jArray[1][0] jArray[1][1]jArray[1][2] jArray[1][3]
                Console.WriteLine();

            }



        }
    }
}
