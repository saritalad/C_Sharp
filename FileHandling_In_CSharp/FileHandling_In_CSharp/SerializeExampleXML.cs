using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace FileHandling_In_CSharp
{
    class SerializeExampleXML
    {
        public static void Main()
        {
            Tutorial T = new Tutorial();
            T.Id = 1;
            T.Name = ".NET";
            Type mytype =T.GetType();//
            //Console.WriteLine("GetType ="+T.GetType());
            //Console.WriteLine("typeOf ="+(mytype));
            FileStream strmtoWrite = new FileStream(@"D:\\Example.xml", FileMode.Create, FileAccess.Write);
            // BinaryFormatter b = new BinaryFormatter();
            XmlSerializer xs = new XmlSerializer(typeof(Tutorial));
            try
            {
                using (strmtoWrite)
                {
                    xs.Serialize(strmtoWrite, T);
                    Console.WriteLine("Object Serialized");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured" + ex.Message);
            }

            XmlSerializer Xs = new XmlSerializer(typeof(Tutorial));


            //FileStream strmtoRead = new FileStream(@"D:\\Example.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            //try
            //{
            //    Tutorial T1 = new Tutorial();
            //    using (strmtoRead)
            //    {
            //        T1 = (Tutorial)Xs.Deserialize(strmtoRead);
            //        Console.WriteLine("Object Deserialized is  Id :" + T1.Id + " Name:" + T1.Name);


            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
