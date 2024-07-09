using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

/* 
+---------------------------------------------------------------------------+
| Objective: Implement IComparable interface and use CompareTo method       |                                                                        
+---------------------------------------------------------------------------+
*/

namespace IComparable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           //Student s1 = new Student(15, "Rock");
           //Student s2 = new Student(16, "Mike");
           //s1.CompareTo(s2);
            ArrayList list = new ArrayList();
            list.Add(new Student(15, "Ajay"));
            list.Add(new Student(2, "Hardy"));
            list.Add(new Student(39, "Tom"));

              list.Sort();

            Console.WriteLine("\nStudents Information\n");
            foreach (Student s in list)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
