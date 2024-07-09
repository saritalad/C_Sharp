using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ComparisonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList Mylist = new ArrayList();
            //Car mycar = new Car("Maruti", 2010);
            //Mylist.Add(12);
            //Mylist.Add('y');
            //Mylist.Add("Seed");
            //Mylist.Add(25.0009f);
            //Mylist.Add(25.0m);
            //Mylist.Add(mycar);
            //foreach (object o in Mylist)
            //{
            //    Console.WriteLine(o.ToString());
            //}

            //stack example
            //Stack mystack = new Stack();
            //mystack.Push(10);
            //mystack.Push(30);
            //mystack.Push("Seed");
            //Console.WriteLine(" Total stack element are " + mystack.Count);
            //Console.WriteLine("Item removed is  {0}" + mystack.Pop());
            //Console.WriteLine("last Item observed is  {0} ", mystack.Peek());
            //Console.WriteLine("last Item removed is  {0} ", mystack.Pop());
            Car c1 = new Car("Honda", 1988);
            Car c2 = new Car("Ford", 1992);
            IComparable I = c1;
        int result= I.CompareTo(c2);
        Console.WriteLine("Comparison of c1 and c2 gives " + result);
            ArrayList mycars = new ArrayList();
            mycars.Add(new Car("Ford", 1992));
            mycars.Add(new Car("Fiat", 1988));
            mycars.Add(new Car("Buick", 1932));
            mycars.Add(new Car("Dodge", 1999));
            mycars.Add(new Car("Honda", 1977));
            mycars.Add(new Car("Hyundai", 1999));

            foreach (Car car in mycars)
                Console.WriteLine(car.Make + "\t\t" + car.Year);

            Console.WriteLine("\nArray - Sorted by Year(Ascending - IComparable)\n");
            mycars.Sort();
            foreach (Car cr in mycars)
                Console.WriteLine(cr.Make + "\t\t" + cr.Year);
            //Car mycar = new Car("B", 1990);
            //Car yourcar = new Car("A", 2000);
            //IComparable i1;
            //i1 = mycar;
            //int response = i1.CompareTo(yourcar);
            //Console.WriteLine("response =" + response);
            //           Console.ReadKey();
        }
    }
}
