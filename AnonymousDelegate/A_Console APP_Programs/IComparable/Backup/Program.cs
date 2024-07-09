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
            Student s1 = new Student(2, "Utkarsh");
            Student s2=new Student (5,"Umesh");
            IComparable I = s1;
            int result = I.CompareTo(s2);

            if (result == 1)
                Console.Write("S1 is greater");
            else
                Console.Write("S2 is greater");
            ArrayList list = new ArrayList();
            list.Add(new Student(15,"Rock"));
            list.Add(new Student(2,"Hardy"));
            list.Add(new Student(39,"Tom"));

            list.Sort();

            Console.WriteLine("\nStudents Information\n");
            foreach (Student s in list)
            {
                Console.WriteLine(s.Id  + "\t" + s.Name);
            }

            Console.ReadLine();
        }
    }
}
