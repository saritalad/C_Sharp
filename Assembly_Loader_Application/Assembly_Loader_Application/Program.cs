//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection;
//namespace Assembly_Loader_Application
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // int x;

          
//          //  MethodInfo method;
//            MethodInfo[] methods;

//            Type[] types = new Type[2];
//            try
//            {
//                Assembly asm = Assembly.LoadFrom(@"D:\\myMath.dll");

//                types = asm.GetTypes();// all classes in mymath get into types array 
//                foreach (Type t in types)
//                {
//                    Console.WriteLine("class Names " + t.FullName);
//                    foreach(MethodInfo m in t.GetMethods())
//                    {
//                        Console.WriteLine("Method Name :"+m.Name);
//                    }
                  
//                }

               
//            }

//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//        }
//    }
//}
