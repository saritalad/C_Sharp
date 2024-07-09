using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_Invoke_Example
{delegate void strdel(string x);
    delegate void add_delegate(int x, int y);
    class Program
    {
        public static void add(int x, int y)
        {
            Console.WriteLine("x + y =" + (x + y));
        }
        public static void subtract(int x, int y)
        {
            Console.WriteLine("x - y =" + (x - y));
        }
        public static void ConvertoUpper(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        public static void Convertolower(string s)
        {
            Console.WriteLine(s.ToLower());
        }

        static void Main(string[] args)
        {
            add_delegate opt = new add_delegate(add);
            opt += new add_delegate(subtract);
            Delegate[] dellist = opt.GetInvocationList();
            for (int i = 0; i < dellist.Length; i++)
            {
                ((add_delegate)(dellist[i])).Invoke(80, 40);
            }

            strdel mydel = new strdel(ConvertoUpper);
            mydel += new strdel(Convertolower);
            mydel("Sarita Lad");


            Console.ReadKey();

        }
    }
}
 