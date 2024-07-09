using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
//namespace ExceptionHandlingDemo
//{
//    class Program1
//    {
//     public static   SqlConnection con;
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        try
        //        {
        //            con = new SqlConnection("Data Source =ABCCOMPUTER;Initial Catalog=MYDB;Integrated Security=true");
        //            con.Open();
        //            Console.WriteLine("Enter first number");
        //            int FirstNumber = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("Enter second number");
        //            int SecondNumber = Convert.ToInt32(Console.ReadLine());
        //            int Result = FirstNumber / SecondNumber;
        //            Console.WriteLine(Result);
        //        }
        //        catch (DivideByZeroException ex)
        //        {
        //            string path = @"E:\Test\InnerExceptionLog1.txt";
        //            if (File.Exists(path))
        //            {
        //                StreamWriter sw = new StreamWriter(path);
        //                sw.WriteLine(ex.GetType().Name);
        //                sw.WriteLine(ex.Message);
        //                sw.WriteLine(ex.StackTrace);
        //                sw.Close();
                       

        //            }
        //            else
        //            {
        //                throw new FileNotFoundException("File not found", ex);
                       
        //            }
        //        }
        //    }
        //    catch (Exception exx)
        //    {
        //        Console.WriteLine("Exception occurred in the catch block  =>" + exx.GetType().Name);
        //        //to get the inner exception type and name, use the InnerException property present in the Exception class  
        //        Console.WriteLine("Exception occurred in the catch block  =>" + exx.InnerException.GetType().Name);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
//        }
//    }
//}
