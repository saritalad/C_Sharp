using System;
using System.Collections.Generic;

namespace GenericMethod_GenericClass
{//https://www.dotnetperls.com/generic
    class Test<T,Q>
    {
        T _value;
        Q _value1;
             public Test(T t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }

        public void Write()
        {
            Console.WriteLine(this._value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> obj = new MyGenericClass<int>(10,20);
            obj.Write();

            MyGenericClass<string > obj1 = new MyGenericClass<string>("Sarita", "Lad");
            obj1.Write();


        }
        public static void  swap(int x,int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
       }

        // generic method 1 
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        // generic method 2
        //     return T Name of Function <T>( parameter 1 T type , parameter 2 of int type )  
        static List<Q> GetInitializedList<Q>( Q value, int count)
        {
            // This generic method returns a List with ten elements initialized.
            // ... It uses a type parameter.
            // ... It uses the "open type" T.
            List<Q> list = new List<Q>();
            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }
            return list;
        }
      

        public static void Shownames(int n , params string [] name)
        {
            for(int i=0;i<n;i++)
                Console.WriteLine("Name "+name[i]);
        }
//        List<bool> list1 = GetInitializedList(true, 5);
//        List<string> list2 = GetInitializedList<string>(null, 3);
//            foreach (bool value in list1)
//            {
//                Console.WriteLine(value);
//            }
//            foreach (string value in list2)
//            {
//                Console.WriteLine(value);
//            }

//int a = 100, b = 200;
//Swap(ref a, ref b);
//List<int> numbers = new List<int>();

//Shownames(4, "Akash", "Seema", "Gita","XXX");
        

    }
}
