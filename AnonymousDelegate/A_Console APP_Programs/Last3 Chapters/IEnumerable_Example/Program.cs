using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IEnumerable_Example
{
    class Program
    {
        static void Main(string[] args)
        {  Batch Afternoonbatch=new Batch ();


           IEnumerator en =Afternoonbatch.GetEnumerator();
        en.MoveNext();
        Student s1 = (Student)en.Current;
        Console.WriteLine(s1);
        en.MoveNext();
        Student s2 = (Student)en.Current;
        Console.WriteLine(s2);
        foreach (Student s in Afternoonbatch)
            Console.WriteLine(s);
        //// reset method is to shift pointer to first position
        //en.Reset();
            Console.Read();    
        }
    }
}
