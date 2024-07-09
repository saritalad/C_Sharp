using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> openwith = new Dictionary<string, string>();
            openwith.Add("txt", "notepad.exe");
            openwith.Add("bmp", "paint.exe");
            openwith.Add("rtf", "wordpad.exe");
            openwith.Add("pdf", "acrobatreader.exe");
            Console.WriteLine("{0}", openwith.ElementAt(2));
            Console.WriteLine("{0}", openwith.First());
            Console.WriteLine("{0}", openwith.Last());
            Console.ReadKey();
        }
    }
}
