
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attributes_example
{
    //public class MyContainer<T> where T:IComparable
    //{
    //    T x;
    //    public MyContainer()
    //    {
    //        Console.WriteLine(x);
    //    }
    //}
    delegate void DeleItem();
    delegate void DeleItemType();
    class Program1
    { 
    static void method(DeleItem d, DeleItemType e, System.Delegate f)
    {
        Console.WriteLine(d == e);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            //  float y = 8.9f;
            //  int x = 10;
            //Student s = new Student();
            //Type t = s.GetType();//  t= Student
            //Console.WriteLine("Name of class from obj s "+ s.GetType());
            //Console.WriteLine("Name of class from obj s " + t);
            //foreach (Attribute a in t.GetCustomAttributes(true))
            //{
            //    MyCustomAttribute c = (MyCustomAttribute)a;
            //    Console.WriteLine("Custom Attribute " + c.Developername);
            //    Console.WriteLine("Custom Attribute " + c.Version);
            //}
            ////int a, b;
            //if (a < b)
            //    c = a;
            //else
            //    c = b;

            //int c = (a < b) ? a : b;
            //c = (a < b) ? 2 + a + 5 : b * b + 5;
            //c = (a < b) ?( (b < 5) ? b : 2 * b): a;
            //int i, j = 1;
            //switch (1)
            //{
            //    case i:
            //        Console.WriteLine("Case i");
            //        break;
            //    case j:
            //        Console.WriteLine("Case j");
            //        break;
            //    default:
            //        Console.WriteLine("Enter valid choice");
            //        break;
            //}

            //do
            //{
            //    Console.WriteLine("CSharp");
            //} while (0 != 1 ? true : false);
            //int i = 2, j = 1;
            // switch (i + j * 2)
            // {
            //     case 1:
            //     case 2:
            //         Console.WriteLine("1 and 2");
            //         break;
            //     case 3:
            //     case 4:
            //     case 5: Console.WriteLine("3 to 5");

            //         break;


            // }

            //char color='v';// char,int, enum,string  
            ////  float,decimal,double not permitted
            //switch( color)
            //{
            //    case 'v':
            //    case 'V': Console.WriteLine("Violet");
            //                   break;

            //    case 'I':
            //    case 'i':
            //              Console.WriteLine("Bye");
            //                   break;
            //    case 'r':  Console.WriteLine("Bye");
            //                     break;

            //    default:break;


            //}

            //string str = "Welcome";
            //Console.WriteLine(string.IsNullOrEmpty(str));
            //int n;
            ////int[] m = new int  [n];
            //Console.WriteLine(m.Length);
            //int row = 3, column = 3,total=0;

            //int [ , ] num = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        if (i == j)
            //        {
            //            total += num[i, j];
            //          //  Console.WriteLine(total);
            //        }

            //    }
            //    Console.WriteLine(total);
            //}
            //int[] marks = new int[5] { 99, 98, 92, 97, 95 };

            ////  public bool EndsWith(string input_string);

            //string str = "Sarita";
            //Console.WriteLine(str.EndsWith("ta").ToString());
            MyContainer<Student> m = new MyContainer<Student>();

        }
    }
}
