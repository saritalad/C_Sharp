using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_As_Example
{
    public class Student
    { }
    public class Teacher
    { }
    class itisas
    {
        static void testClass(object o)
        {
            if (o is Student)
            { Console.WriteLine($"The instance: {nameof(o)} we recieved as argument is from Student class!"); }
            else if (o is Teacher)
            { Console.WriteLine($"The instance: {nameof(o)} we recieved as argument is from Teacher class!"); }
            else
            { Console.WriteLine($"The instance: {nameof(o)} we recieved as argument is from neither Teacher nor Student class!"); }
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            Teacher t = new Teacher();
            int i = 0;
            testClass(s);
            testClass(t);
            testClass(i);
            Console.ReadKey(); ;
        }
    }
}