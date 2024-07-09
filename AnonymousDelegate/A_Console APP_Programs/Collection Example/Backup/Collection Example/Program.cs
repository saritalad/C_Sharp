using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Collection_Example
{
    class Program
    {
       static void Main(string[] args)
        {
            int x1 = 12,x;
            int[] m = new int[3];
            m[0] = 100;
            m[1] = 200;
            m[2] = 300;
            float y = 20.5f;
            Car mycar = new Car(1978, "Maruti 800");
            ArrayList mylist = new ArrayList();
          //  mylist.Add(x1);
            mylist.Add(y);
            mylist.Add("Seed Infotech");
            mylist.Add(300);
            mylist.Add(x = 10);
            mylist.AddRange(m);
            mylist.Add(new Car(1990, "Maruti K10"));
            mylist.Add(mycar);
            mylist.Insert(0, x1);

            foreach (object o in mylist)
            {
                Console.WriteLine(o);
            }
         Console.WriteLine("count of element in mylist "+mylist.Count);
         SortedList mysortedlist = new SortedList();
         mysortedlist.Add("one", 1);
         mysortedlist.Add("two", 2);
         IDictionaryEnumerator e = mysortedlist.GetEnumerator();
         e.MoveNext();
          
         Console.WriteLine(e.Key );
         Console.WriteLine(e.Value );
         e.MoveNext();

         Console.WriteLine(e.Key);
         Console.WriteLine(e.Value);
         Console.WriteLine(mylist.Capacity);
         Car c1 = new Car(1980, "Fiat");
         //ArrayList myobjects = new ArrayList();
         //myobjects.Add(c1);
         //m yobjects.Add(new Car(2000, "Maruti"));
         //myobjects.Add(new Car(2010, "Ford"));
         //myobjects.Add(200.50);
         //myobjects.Add("Indian Cars");
         //foreach (Object o in myobjects)
         //    Console.WriteLine(o);
         // //  // Generic class example 
         //   Console.WriteLine("Generic List<Car> Example");
         // List<T> NameOflist = new List<T>();
         //List<Car> IndianCars = new List<Car>();
         //Car C1 = new Car(2000, "Maruti");
         //IndianCars.Add(C1);
         //IndianCars.Add(new Car(2010, "Ford"));
         //IndianCars.Add(new Car(1980, "Fiat"));

         //foreach (Car c in IndianCars)
         //    Console.WriteLine(c);
         // Stack non generic Example
         //Stack mystack = new Stack();
         //Car c1 = new Car(1980, "Fiat");
         //mystack.Push(c1);
         //mystack.Push(new Car(2000, "Maruti"));
         //mystack.Push(new Car(2010, "Ford"));   
         //mystack.Push(25.30);
         //Console.WriteLine("Non Generic Stack class");
         //try
         //{
         //    Console.WriteLine("Count is" + mystack.Count);
         //    Console.WriteLine("Pop Output{0}", mystack.Pop());
         //    Console.WriteLine(mystack.Peek());

         //    Console.WriteLine(mystack.Pop());

         //    Console.WriteLine("Peek Output{0}", mystack.Peek());

         //    Console.WriteLine(mystack.Pop());
         //    Console.WriteLine(mystack.Pop());
         //    Console.WriteLine(mystack.Pop());
         //}
         //catch (Exception ex)
         //{
         //    Console.Write(ex.Message);
         }
           //// Generic Stack class Example
            Stack<int> Launchyear = new Stack<int>();
            Launchyear.Push(1990);
            // Launchyear.Push("Maruti"); error
            Launchyear.Push(2003);
            Launchyear.Push(2005);
            Launchyear.Push(2006);
            Launchyear.Pop();
            Console.WriteLine(Launchyear.Peek());
            Launchyear.Pop();
               
           // //// nongeneric queue example
           //Queue myq = new Queue();
           //myq.Enqueue(new Car(1990, "Fiat"));
           //myq.Enqueue(1980);
           //myq.Enqueue("Tata");
           //Console.WriteLine("Number of elements in Queue are" + myq.Count);
           //Console.WriteLine("First object removed First " + myq.Dequeue());
           //Console.WriteLine("Second object removed Second " + myq.Dequeue());
           //Console.WriteLine("Search object " + myq.Contains("Fiat"));
            
          
           ////// Generic Queue class Example
   //        Queue<int> year = new Queue<int>();
   //        year.Enqueue(1980);
   //        year.Enqueue(2010);
   //        year.Enqueue(2012);
   //        year.Enqueue(2010);
   //Console.WriteLine("Number of elements in Queue are" + year.Count);
   //Console.WriteLine("First object removed First " + year.Dequeue());
   //      //  year.First();
   //         // hashtable nongeneric class
   //        Hashtable h = new Hashtable();
   //        h.Add("Mon", "Monday");
   //        h.Add(1, "Friday");
   //        h.Add("Tue", null);
   //        h.Add("India", "Criket");
   //        IDictionaryEnumerator e = h.GetEnumerator();
   //        e.MoveNext();

   //        while (e.MoveNext())
   //        Console.WriteLine(e.Key + "\t" + e.Value);
                     
           Console.ReadLine();
        }
    }
}
