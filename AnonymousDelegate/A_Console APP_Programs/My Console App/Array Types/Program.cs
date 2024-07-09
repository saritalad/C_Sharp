using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Types
{
    class Program
    {
        static void Main(string[] args)
        {// multidimensional array
            //rectangular Array
            //int[,] matrix = new int[2, 3];
            //// // initialize rectangular Array  
            //int[,] numbers = new int[3, 3] { { 2, 3, 7 }, { 2, 4, 6 }, { 5, 8, 8 } };
            //float[,] floats = new float[2, 2] { { 3.0f, 4.5f }, { 6.0f, 7.0f } };

            //Console.WriteLine("Enter 6 numbers ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("\t" + matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

           //declaration of Array
           // data type[] arrayname= new datatype [size]
            int[] marks = new int[10];
            string[] fruits = {"Grapes" , "Banana","Äpple", "Orange", "Mango" };
            string[] students = new string[5];
            Console.WriteLine("Enter 10 numbers ");
            for (int i = 0; i < 10; i++)
            {marks [i] =Convert.ToInt32 (Console .ReadLine ());
            }
            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine ("Position {0} Element {1}",i, marks[i]) ;
            }
            Console.WriteLine("My Choice of Fruits is(unsorted) ");
            foreach (string s in fruits)
                Console.Write("\t" + s + ",");
            Console.WriteLine("Sorted List Of Fruits");
            Array.Sort(fruits);
            foreach (string s in fruits)
                Console.Write("\n" + s + ",");
            Console.WriteLine("Enter 5 names of students \n");
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }
            foreach (string s in students)
                Console.Write(s + "\t");
            Array.Sort(students);
            Console.WriteLine("Sorted names of Students");
            foreach (string s in students)
                Console.Write(s + "\t");
            Console.WriteLine("Array of marks displayed using foreach Loop \n");
            foreach (int x in marks)
                Console.Write("\t" + x);

            Console.ReadLine();
        }
    }
}
