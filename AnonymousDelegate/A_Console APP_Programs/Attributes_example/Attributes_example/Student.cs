﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace Attributes_example
{[MyCustomAttribute("Seed",1.1)]
    class Student
    {
        int id;
        string name;
        char grade;
        public Student()
        {
            id = 1;
            name = "Mr Bill";
            grade = 'A';

        }
        public Student(int i, string s, char g)
        {
            this.id = i;
            this.name = s;
            this.grade = g;
        }

        public void ShowResult()
        {
            if (this.grade == 'A')
            {
                Console.WriteLine("Student is passed with first class");
            }
            else if (this.grade == 'B')
            {
                Console.WriteLine("Student is passed with second class");
            }
            else if (this.grade == 'C')
            {
                Console.WriteLine("Student is passsed with pass class");
            }
            else if (this.grade == 'F')
            {
                Console.WriteLine("Student is fail");
            }
            else
            {
                Console.WriteLine("Please enter valid grade...");
            }
        }

    }
}