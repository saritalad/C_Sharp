using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray_ToFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[4] { 1, 2, 3, 4 };
            int[] list2 = new int[4] { 5, 6, 7, 8 };
            int[] list3 = new int[4] { 1, 3, 2, 1 };
            int[] list4 = new int[4] { 5, 4, 3, 2 };
            int[][] lists = new int[][] { list1, list2, list3, list4 };
             GetSize(lists);
            int n;
           
            string teamname = "team";
            
            int attempts;
            Console.WriteLine("Enter number of teams");
            n = Convert.ToInt32(Console.ReadLine());// length of outer array is number of team
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter attempts of team " + i);
                attempts = Convert.ToInt32(Console.ReadLine());
                int[] team = new int [i];
                 
              
            }





        }


        public static void GetSize(int[][] items)
        {
            for (int i=0;i<items.Length;i++)

                Console.WriteLine(items[0].Length);
        }
    }
}
