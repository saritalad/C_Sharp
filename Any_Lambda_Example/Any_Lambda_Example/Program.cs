using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Any_Lambda_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.All(n => n.EndsWith("y"));// true  at least one 

           Console.WriteLine("Does any of the names start with the letter 'B'?:");
           Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
