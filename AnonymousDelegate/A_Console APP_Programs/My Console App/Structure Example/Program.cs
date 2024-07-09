using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure_Example
{
    class Program
    {
        struct Point
        {
            int x;

            public int X
            {
                get { return x; }
                set { x = value; }
            }
            int y;

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

         public void Display()
            {
                Console.WriteLine("Point Co-Ordinates are (" + X + "," + Y + ")");
            }


        }

        static void Main(string[] args)
        {
            Point P = new Point();
            P.X = 10;
            P.Y = 5;
            P.Display();
            DateTime date = new DateTime();
            date = DateTime.Now;
            string m = date.ToLongDateString();
            Console .WriteLine ("Date is "+m);
            string month = m.Substring(3, 8); 
            Console.WriteLine(month);
            // When you assign a DateTime, a separate copy is created.
            DateTime dateCopy = date;

            // The two structs have the same values.
            Console.WriteLine(date);
            Console.WriteLine(dateCopy);

            //// The copy is not affected when the original changes.
            //date = DateTime.MinValue;
        
            //Console.WriteLine(dateCopy);










        }
    }
}
