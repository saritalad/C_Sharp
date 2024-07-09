//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////namespace FileHandling_In_CSharp
////{
//class Program4
//{ // Main Method
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the directory name you want to delete:");

//        string DirName = Console.ReadLine();

//        // Checking if Directory Exist or not
//        if (Directory.Exists(DirName))
//        {

//            // This will delete the
//            // Directory if it is empty
//            Directory.Delete(DirName);

//            // checking if directory if
//            // deleted successfully or not
//            if (Directory.Exists(DirName) == false)
//                Console.WriteLine("Directory deleted successfully...");
//        }
//        else
//            Console.WriteLine("Directory {0} does not exist!", DirName);
//        Console.ReadKey();
//    }
//}
