using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ArrayException
{

    class Program
    {
        static void Main(string[] args)
        { int temp;
           int []marks={12,6,45,3 };
                Array.Sort(marks);

            Array.Reverse(marks);

            var x=10;


            //int[] marks = new int[5];
            //try
            //{
            //    for (int i = 0; i < 15; i++)
            //    {
            //        Console.WriteLine("enter a number ");
            //        marks[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine("Given Array is ");
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(marks[i]);
            //    }
            //    Stack s = new Stack();
                
            //}
            //catch (System.FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //catch (System.IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    throw;
            //}

        }
    }
}
