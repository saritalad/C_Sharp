using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Enter a Character instead of a number(Causes Format Exception)
//Or Enter a very big number that an integer cannot hold(Causes Over Flow Exception)
//Or Enter Zero for Second Number(Causes Divide By Zero Exception)

    using System.IO;
namespace ExceptionHandlingDemo
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter first number");
                int FirstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int SecondNumber = Convert.ToInt32(Console.ReadLine());
                int Result = FirstNumber / SecondNumber;
                Console.WriteLine(Result);
            }
            catch (Exception ex)
            {
                string path = @"E:\Test\InnerExceptionLog.txt";
                StreamWriter sw = new StreamWriter(path);
                sw.Write(ex.GetType().Name);
                sw.WriteLine(ex.Message);
                sw.WriteLine(ex.StackTrace);
                sw.Close();
                Console.WriteLine("Unkown error!!");
            }
        }

    }
}



