using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethod_GenericClass
{
    class TestClass<T>
    {
        T[] obj = new T[5];
        int count = 0;
        public void Add(T item)
        {
            if (count + 1 < 6)
            {
                obj[count] = item;

            }
            count++;

        }
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }




    }
}
//TestClass<int> intObj = new TestClass<int>();

////adding integer values into collection
//             intObj.Add(1);
//            intObj.Add(2);
//            intObj.Add(3);     //No boxing
//            intObj.Add(4);
//            intObj.Add(5);

//            //displaying values
//            for (int i = 0; i< 5; i++)
//            {
//                Console.WriteLine(intObj[i]);   //No unboxing
//            }




