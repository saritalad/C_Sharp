using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Params_Example
{
    class Program
    {
        static void viewnames(Char x, int n, params string[] names)
        {
            Console.WriteLine("Are they girls {0} How many girls{1} Names:{2},{3},{4}",x, n, names[0], names[1],names[2],names[3]);
        }
          static int countproducts(params int[] productsprice)
        {
            int sum = 0;
            for (int i = 0; i < productsprice.Length; i++)
                sum += productsprice[i];
            return sum;
        }
         static void Main(string[] args)
        {
            viewnames('y', 4, "Smita", "Gita", "Rita", "Mita");
                 
             int count = countproducts(12, 23, 34, 45);
            Console.WriteLine("Total products are" + count);
        
        }
    }
}
