using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_with_Student_Delegate
{
//    Declare an Event
//   An event can be declared in two steps:

//Declare a delegate.
//Declare a variable of the delegate with event keyword.
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() { Id = 123, Name = "Joy" };
            s.Pass += new Markdel(GoodResult);
            s.Fail += new Markdel(BadResult);
            s.DeclareResult(34);

        }

        public static void GoodResult()
        {
            Console.WriteLine("Wel Done ! You are Pass");
        }
        public static void BadResult()
        {
            Console.WriteLine("Oh No ! You are Fail");
        }
    }
}
