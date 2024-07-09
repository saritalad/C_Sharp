using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formatedoutput
{
    class Program
    {
        static void Main(string[] args)
    {
        Decimal amt ;
        Decimal interest = 0.12M;
        Console.Write("Please enter amount");
        amt = Convert.ToDecimal(Console.ReadLine());
        decimal totamt = amt * interest;
        Console.WriteLine("Total Amount with 12 perent interest ={0:C}", totamt);





        float r, A;
        // Math .Pi is Double Data type type cast it to float
      // Type casing from Double to float use (float)
            r =(float) Convert.ToDouble(Console.ReadLine());

            A = (float)Math.PI * r * r;
        Console.WriteLine("Radius = {0:F3}Area of Circle ={1:F}", r, A);
            Console.ReadLine();

        }
    }
}
