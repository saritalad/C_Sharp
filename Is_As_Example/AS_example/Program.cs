using System;

namespace AS_example
{
    public class Student
    {
    }
    public class Teacher
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            object[] MyObjects = new object[4];
            MyObjects[0] = new Student();
            MyObjects[1] = new Teacher();
            MyObjects[2] = "Student";
            MyObjects[3] = "Teacher";
            for (int i = 0; i < 4; i++)
            {
                string s = MyObjects[i] as string;
                Console.Write($"Inspecting element: {MyObjects[i]}");
                if (s == null)
                { Console.Write(" ->> Incompatible type"); }
                else
                { Console.Write(" ->> Compatible type"); }
                Console.WriteLine(", with string!");
            }
        }
    }

}