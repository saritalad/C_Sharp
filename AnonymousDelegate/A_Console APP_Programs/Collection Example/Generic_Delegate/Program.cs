using System;
using System.Collections.Generic;

delegate T NumberChanger<T>(T n);
namespace GenericDelegateAppl
{
    class TestDelegate
    {
        static int num = 10;
        static float NUM = 10.5f;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        public static float getfloat(float p)
        {
            NUM += p;
            return NUM;
        }

        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);
            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());


            NumberChanger<float> nc3 = new NumberChanger<float>(getfloat);
            nc3(20.5f);
            Console.WriteLine(NUM);
            Console.ReadKey();
        }
    }
}