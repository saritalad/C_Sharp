using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace GenericDictionary_example
{
    // Example of Intialization 
    //Dictionary<int, StudentName> students = new Dictionary<int, StudentName>()
    //{
    //    { 111, new StudentName {FirstName="Sachin", LastName="Karnik", ID=211}},
    //    { 112, new StudentName {FirstName="Dina", LastName="Salimzianova", ID=317}},
    //    { 113, new StudentName {FirstName="Andy", LastName="Ruth", ID=198}}
    //};





    class Program
    {
        static void Main(string[] args)
        {
            // Hashtable h = new Hashtable();
            // h.Add(1, "Monday");
            // h.Add(2, "TuesDay");
            // h.Add(3, "Wednesday");
            // h.Add("Thus", "ThusDay");
            // h.Add("Fri", "FriDay");
            // h.Add("Sat", "SaturDay");
            // h.Add("num", null);
            // // h.Add(null, "x");// key can not be null
            // IDictionaryEnumerator e = h.GetEnumerator();
            //// e.Reset();
            // e.MoveNext();

            // Console.WriteLine(e.Key + "\t" + e.Value);
            // while (e.MoveNext())
            // {
            //     e.MoveNext();
            //     Console.WriteLine(e.Key + "\t" + e.Value);
            // }


            Dictionary<string, string> openwith = new Dictionary<string, string>();
            openwith.Add("txt", "notepad.exe");
            openwith.Add("Bmp", "paint.exe");
            openwith.Add("rtf", "Wordpad.exe");
            openwith.Add("pdf", "acrobatreader.exe");
            Console.WriteLine(openwith.ElementAt(2));
            Console.WriteLine("{0}", openwith.First());
            Console.WriteLine("{0}", openwith.Last());


            int x = 9, y = 80;
            Swap(ref x, ref y);
            Console.WriteLine("x= {0} y={1}", x, y);
            float m = 12.3f, n = 23.45f;
            Swap(ref m, ref n);
            Console.WriteLine("m = {0} n={1}", m, n);
            Console.ReadKey();
        }
       //generic method
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        

    }
}
