//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FileHandling_In_CSharp
//{
//    class Program5
//    {
//        public static void Main()
//        {
//            string path = @"D:\ABCOMPUTER.txt";
//            //    This text is added only once to the file.
//            //if (!File.Exists(path))
//            //{
//            //    // Create a file to write to.
//            //    using (StreamWriter sw = File.CreateText(path))
//            //    {
//            //        sw.WriteLine("Hello");
//            //        sw.WriteLine("And");
//            //        sw.WriteLine("Welcome");
//            //    }
//            //}

//            //     This text is always added, making the file longer over time
//            //   if it is not deleted.
//            using (StreamWriter sw = File.AppendText(path))
//            {
//                sw.WriteLine("New text is  ");
//                sw.WriteLine("Written Hers");
//                sw.WriteLine("Can you see?");
//            }

//            //    Open the file to read from.
//            using (StreamReader sr = File.OpenText(path))
//            {
//                string s = "";
//                while ((s = sr.ReadLine()) != null)
//                {
//                    Console.WriteLine(s);
//                }

//            }
//        }
//    }
//}

