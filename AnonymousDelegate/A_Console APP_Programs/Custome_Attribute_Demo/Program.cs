using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
+----------------------------------------------------------------------+
| Objective: Creating custom attribute class, apply it on Student class| 
|            and then performing reflection                            |                                 
+----------------------------------------------------------------------+
*/

namespace Custome_Attribute_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Type t = s.GetType();
            //Invoking Attributes in Student class 
            foreach (Attribute a in t.GetCustomAttributes(true))
            {
                CreateCustomAttribute cca = (CreateCustomAttribute)a;
                Console.WriteLine("\nDeveloper name is::" + cca.DevName);
                Console.WriteLine("\nVersion number is::" + cca.VerNum + "\n");
            }

            Console.ReadLine(); 
        }
    }
}
