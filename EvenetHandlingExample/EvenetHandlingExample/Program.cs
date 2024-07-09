using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenetHandlingExample
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Id = 1, Name = "Bill" };
            s1.Pass += new Markdel(ShowMessage.GoodResult);
            s1.Fail += new Markdel(ShowMessage.BadResult);
            Console.WriteLine("Enter marks ");
            int m = Convert.ToInt32(Console.ReadLine());
            s1.EnterMarks(m);
          
        }
    }
}
