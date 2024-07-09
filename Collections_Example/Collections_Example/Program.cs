using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collections_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 34, 67, 89, 90 };
            int[] a = new int[3];
            a[0] = 90;
            a[1] = 8;
            a[2] = 4;
            Array.Sort(myarray);
         //declaration no size no data type  req
            ArrayList myarraylist = new ArrayList(); //boxing  
            myarraylist.Add(67.9);
            myarraylist.Add(DateTime.Now.ToShortDateString());
            myarraylist.Add(Math.PI);
            myarraylist.Add(23.89f);
            myarraylist.Add(45.90m);
            myarraylist.Add("Sarita");
            myarraylist.Add(100);

            Console.WriteLine(" index position of 45.90m is :"+myarraylist.IndexOf(45.90m));
            myarraylist.AddRange(myarray);
            myarraylist.RemoveAt(3);
            
            foreach(object o in myarraylist)// unboxing  coverting from object to its original value type
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("......................");
            // Stack non generic class   LIFO 
            Stack mystack = new Stack();
            mystack.Push(45);
            mystack.Push("Sarita");
            mystack.Push(new Student() { rollno = 10, Name = "Bill" });
            mystack.Push(78.90m);
            mystack.Push(45.90m);
           Console.WriteLine(" contains 45 or not :"+ mystack.Contains(45));
            Console.WriteLine("  count of stack element "+mystack.Count); 
            Console.WriteLine("Stack output Last in First Out ");
            Console.WriteLine(mystack.Pop());
            Console.WriteLine("  count of stack element " + mystack.Count);
            Console.WriteLine(mystack.Pop());

            //Console.WriteLine(mystack.Pop());
            //Console.WriteLine(mystack.Peek());
            //Console.WriteLine(mystack.Pop());
            //Console.WriteLine(mystack.Pop());
            
            Console.WriteLine("....................................................");
            // Queue is FIFO  FIRST IN FIRST OUT 
            Queue myQ = new Queue();
            myQ.Enqueue(100);
            myQ.Enqueue("ABC");
            myQ.Enqueue(87.90m);
            myQ.Enqueue("12/2/2021");

            Console.WriteLine(myQ.Dequeue());

            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);


           









        }
    }

        }
}
