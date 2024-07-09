using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections ;
namespace Nested_Car_Class
{
    class car:IComparable 
    { // Beginning of nested classes.

      // Nested class to do ascending sort on year property.
      private class sortYearAscendingHelper: IComparer
      {
         int IComparer.Compare(object a, object b)
         {
            car c1=(car)a;
            car c2=(car)b;

            if (c1.year > c2.year)
               return 1;

            if (c1.year < c2.year)
               return -1;

            else
               return 0;
         }
      }

      // Nested class to do descending sort on year property.
      private class sortYearDescendingHelper: IComparer
      {
         int IComparer.Compare(object a, object b)
         {
            car c1=(car)a;
            car c2=(car)b;

            if (c1.year < c2.year)
               return 1;

            if (c1.year > c2.year)
               return -1;

            else
               return 0;

    }
}
    }
