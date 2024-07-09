//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FileHandling_In_CSharp
//{
//    class Program1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter a name for the new directory:");
//            try
//            {
//                string DirName = Console.ReadLine();

//                // Checking if string is empty or not
//                if (DirName != null)
//                {
//                    // Creating the Directory
//                    Directory.CreateDirectory(DirName);
//                    Console.WriteLine("The directory was created!");
//                    // Checking Directory is created
//                    // Successfully or not
//                    if (Directory.Exists(DirName))
//                    {
//                        Console.WriteLine("Yes !The directory exists!");

//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            }

//            }
//        }


