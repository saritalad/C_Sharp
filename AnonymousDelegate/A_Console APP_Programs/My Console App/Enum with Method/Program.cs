using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum_with_Method
{
    using System;
   
    // extension methods for the Colors enum
    public static class ColorsExtensions
    {
        public static bool IsWhite(this Colors c)
        {
            return c == Colors.Violet ;
        }
        public static bool IsRedOrBlue(this Colors c)
        {
            return c == Colors.Red || c == Colors.Blue;
        }
    }
    public enum Colors
    {
        Violet,
        Indigo,
        Blue,
        Green,
        Yellow,
        Orange,
        Red
    }
    public enum months { January, February, March, April, May, June, July, August, September, October, November, December }
    class Test
    {
        static void Main()
        {
            Colors c = Colors.Violet;

            Console.WriteLine("Selected Colour is" + c);
            //Colors c = Colors.Red;
            //Console.WriteLine(c.IsWhite()); // False
            //Console.WriteLine(c.IsRedOrBlue());  // True

            //Console.WriteLine(months.April);
            //months m=months .February ;
            //Console.WriteLine("Is this month February " + IsFeb(m));


            Console.ReadKey();
        }

        public static bool IsFeb(months m)
        {
            return m == months.February;
        }


    }
}
