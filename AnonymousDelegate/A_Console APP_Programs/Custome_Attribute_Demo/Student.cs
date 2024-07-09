using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custome_Attribute_Demo
{
    [CreateCustomAttribute("SEED", 1.1)]
    public class Student
    {
        int id;
        string name;
        char grade;

        //no parameters constructor 
        public Student()
        {
            this.id = 0;
            this.name = "";
            this.grade = ' ';
        }

        //parameterized constructor
        public Student(int id, string name, char grade)
        {
            this.id = id;
            this.name = name;
            this.grade = grade;
        }

        //property for accessing id
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        //property for accessing name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //property for accessing grade
        public char Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }

        //display grade 
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

        //diplay student information
        public void DisplayStudentInformation()
        {
            Console.WriteLine("Student ID::" + Id);
            Console.WriteLine("Student Name:" + Name);
            Console.WriteLine("Student Grade:" + Grade);
        }
    }
}
