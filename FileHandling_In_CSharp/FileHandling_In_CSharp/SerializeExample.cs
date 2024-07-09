//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;

//namespace FileHandling_In_CSharp
//{
//    class SerializeExample
//    {
//        public static void Main()
//        {List <string mylist = new List<string>();
//            Tutorial T = new Tutorial();
//            T.Id = 1;
//            T.Name = ".NET";
//            FileStream strmtoWrite = new FileStream(@"D:\\Example.txt", FileMode.Create, FileAccess.Write);
//            BinaryFormatter b = new BinaryFormatter();
//            try
//            {
//                using (strmtoWrite)
//                {
//                    b.Serialize(strmtoWrite, T);
//                    Console.WriteLine("Object Serialized");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("An error has occured" + ex.Message);
//            }



//            BinaryFormatter bf = new BinaryFormatter();

//            FileStream strmtoRead = new FileStream(@"D:\\Example.txt", FileMode.Open, FileAccess.Read, FileShare.None);
//            try
//            {
//                Tutorial T1 = new Tutorial();
//                using (strmtoRead)
//                {
//                    T1 = (Tutorial)bf.Deserialize(strmtoRead);
//                    Console.WriteLine("Object Deserialized is  Id :" + T1.Id + " Name:" + T1.Name);
//                }
//            }

//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}