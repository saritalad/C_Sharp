using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unicast_Example
{   //  delegate int Adddelegate (int x,int y);
    delegate void strdelegate(string str);
    public class myclass
    {
        public void ChangetoCaps(string s)
        {
            Console.WriteLine("Üpper case " + s.ToUpper());
            Console.WriteLine("=========");
        }

        public void ChangetoLower(string s)
        {
            Console.WriteLine("Lower case " + s.ToLower());
            Console.WriteLine("=========");
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
             myclass mdl = new myclass();

            strdelegate sd = new strdelegate(mdl.ChangetoCaps );
            sd("seed");
            
            
            
            sd += new strdelegate(mdl.ChangetoLower);
            //sd("ENJOY");
            sd("SeEd");
            sd("ShEeta");
            //Adddelegate add_del = new Adddelegate(Add);
            //int z = add_del(5, 10);
            //Console.WriteLine("x + y = " + z);
            Console.ReadLine();

        
        }

        //public static int Add(int a, int b)
        //{
        //    return (a + b);
        //}
    }
}
