using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloneProject
{
    class Program
    {
        class Student
        {
            public string RollID { get; set; }
        }
        class Person
        {
            public Student student { get; set; }
            public string Address { get; set; }
            public string Name { get; set; }

            public Person ()
            {
                Address = "bombay";
                Name = "foo";
            }
          public Person (Person p)
            {
                p = this;
            }

            public Person Clone()
            {
                return (Person)this.MemberwiseClone();
            }
            //The MemberwiseClone method creates a shallow copy by creating a new object,
            //    and then copying the nonstatic fields of the current object to the
            //    new object. If a field is a value type, a bit-by-bit copy of the field is performed.
            //    If a field is a reference type, the reference is copied but the referred object is not; therefore,
            //    the original object and its clone refer to the same object.
            //In a shallow clone, any reference values in the copy refer to the
            //same objects as those in the original object. In a deep clone, the new object's reference values are set to new objects. 
            //To make a deep clone implement the ICloneable interface a return a New Person object.
            //

        }


        // object class has 4 methods common forv all our user classes 
        // 1 ToString()
        // 2 Equals()
        // GetType()
        // GetHashCode()

        static void Main(string[] args)
        {
            int x=9,z;
            z = x;
            char y;
            bool t;
            string n;
            int [] b;
            List<int> mylist;
            object obj;

            Complex c1 = new Complex(10, 5);  
            Complex c2 = (Complex)c1.Clone();
            Console.WriteLine("c1  is "+c1);
            Console.WriteLine("c2  is " + c2);
            c1.Real = 35;
            c2 = c1; Console.WriteLine("type of x is "+x.GetType());
            Console.WriteLine(c2.GetType());
            Console.WriteLine("c1  is " + c1);
            Console.WriteLine("c2  is " + c2);
        }
    }
}











//  Student s1 = new Student();
//  s1.RollID = "151";
//  Person p1 = new Person();
//  p1.Address = "bombay";
//  p1.Name = "foo";
//  p1.student = s1;

//  Person p2 =(Person ) p1.Clone();
////  p2.student.RollID = "1558";

//  Person p3 = p2.Clone();
//  p3.student.RollID = "454";
// // p2.Address = "Pune";
//  p3.Address = "Nagpur";
//  Console.WriteLine("p1 address "+p1.Address +p1.student .RollID );
//  Console.WriteLine("p2 address " + p2.Address + p2.student.RollID);
//  Console.WriteLine("p3 address " + p3.Address + p3.student.RollID);