//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FileHandling_In_CSharp
//{
//    class Program6
//    {
//        public static void Main()
//        {
//            string path = @"c:\temp\MyTest.txt";

//            try
//            {
//                if (File.Exists(path))
//                {
//                    File.Delete(path);
//                }

//                using (StreamWriter sw = new StreamWriter(path))
//                {
//                    sw.WriteLine("This");
//                    sw.WriteLine("is some text");
//                    sw.WriteLine("to test");
//                    sw.WriteLine("Reading");
//                }

//                using (StreamReader sr = new StreamReader(path))
//                {
//                    //This allows you to do one Read operation.
//                    Console.WriteLine(sr.ReadToEnd());
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("The process failed: {0}", e.ToString());
//            }
//        }
//}
