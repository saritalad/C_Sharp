using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomiedException
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            try
            {
                //Console.WriteLine("Enter a number ");
                //x = Convert.ToInt32(Console.ReadLine());
                //if (x % 5 != 0)

                //    throw new MyException("Number should  be multiple of 5 ");
                //  new Manager(iid,name);

                Stack<int> Numbers = new Stack<int>();
                Numbers.Push(89);
                Numbers.Push(100);
                Numbers.Push(9);
                Numbers.Push(70);


                Console.WriteLine(Numbers.Pop());

                Console.WriteLine(Numbers.Pop());

                Console.WriteLine(Numbers.Pop());

                Console.WriteLine(Numbers.Pop());

                Console.WriteLine(Numbers.Pop());



            }
            //Employee E     Exception  ex=new MyException(msg)
            //catch (MyException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //catch (FormatException e)
            //{ 

            //}

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
