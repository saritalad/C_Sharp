using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IEnumerable_Example
{
    class Batch:IEnumerable 
    {
        Student[] students;
        public Batch()
        {
            students = new Student[6];
            students[0] = new Student(1, "Ajinkya");
            students[1] = new Student(2, "Shruti");
            students[2] = new Student(3, "Pranoti");
            students[3] = new Student(4, "Minakshi");
            students[4] = new Student(5, "Utkarsh");
            students[5] = new Student(6, "Umesh");
      
           
        }


        public IEnumerator GetEnumerator()
        {
            foreach (Student s in students)
            {
                yield return s;
            }
        }


    }
   




}
