using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attributes_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Type t = s.GetType();
            foreach (Attribute a in t.GetCustomAttributes(true))
            {
                MyCustomAttribute c = (MyCustomAttribute)a;
                Console.WriteLine("Custom Attribute " + c.Developername);
                Console.WriteLine("Custom Attribute " + c.Version);
            }
        }
    }
}
