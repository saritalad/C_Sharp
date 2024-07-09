using System;
using System.Collections.Generic;
using System.Linq;

//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        delegate void transformer(int x);
        delegate int CubeMaker(int x);
        static void Main(string[] args)
        {
            //  transformer t;
            //  int x;
            //  Console.WriteLine("Enter a number to find square of that number ");
            //  x = Convert.ToInt32(Console.ReadLine());
            ////  t = new transformer(Square);
            //  //  t = Square;// name of 
            //  //(1) let us use the anaonymous method , here parameter is given , body of method is also here but name of method is missing
            //  t = delegate (int s) { Console.WriteLine("Square of  " + s + " = " + s * s); };
            //  // (2) let us use lambda operator =>( read as goes to) to invoke the body of anonymous method 
            //  t =  (s) => { Console.WriteLine("Square of  " + s + " = " + s * s); };
            //  t(x);
            // // t.Invoke(x);// this will execute Square(x) method 

            //  // CubeMaker c = delegate (int s) { return s * s * s; };// this is a anonymous method 
            //  CubeMaker c=( s)=> { return s * s * s; };
            //  int Ans = c(x);
            //  Console.WriteLine(" Cube of  "+ x + " = "+ Ans);

            List<int> list = new List<int>();
            list.Add(0);// element == index list[0]=0
            list.Add(2);
            list.Add(2);// element == indexlist[2]=2
            list.Add(1);
            list.Add(4); //element == index list[4]=4
            list.Add(3);
            //.............................................................
            Console.WriteLine("sublist using lambda expression is ");
            var sublist = list.Where((i, ix) => i == ix);
            //..........................................................
            foreach(int n in sublist)
                Console.WriteLine(n);
            Console.WriteLine("sublist using code is ");
            var newlist = new List<int>();
            int jx = 0;
            foreach (int j in list)
            { if (jx++ == j)
                    newlist.Add(j);
                        }
            foreach(int n in newlist)
                Console.WriteLine(n);
            Console.ReadKey();

        }



        //public static void Square(int s)
        //{
        //    Console.WriteLine("Square of  "+ s +" = "+ s*s);
        //}


        //public static int Cube(int s)
        //{
        //    return s * s * s;

        //}
        //public static void FullName(string fname,string lname)
        //{
        //    Console.WriteLine();
        //}


    }
}
