using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ComparisonExample
{
    class Car:IComparable
    { private int year;
      private string make;
        
      public Car(string Make,int Year)
      {
         make=Make;
         year=Year;
      }

      public int Year
      {
         get  {return year;}
         set {year=value;}
      }

      public string Make
      {
         get {return make;}
         set {make=value;}
      }
      //int IComparable.CompareTo(object obj)
      //{
      //    Car c = (Car)obj;
      //    return String.Compare(this.make, c.make);
      //}
   int IComparable.CompareTo(object o)
 {
     Car newcar = (Car)o;
     if (this.year > newcar.year)
         return -1;
     else if (this.year < newcar.year)
         return +1;
     else
         return 0;
 }
     
        //Ascending Sort on year of make
      //int IComparer.Compare(object a, object b)
      //{
      //    Car c1 = (Car)a;
      //    Car c2 = (Car)b;

      //    if (c1.year > c2.year)
      //        return 1;

      //    if (c1.year < c2.year)
      //        return -1;

      //    else
      //        return 0;
      //}
//Descending Sort on Year of model
      //int IComparer.Compare(object a, object b)
      //{
      //    Car c1 = (Car)a;
      //    Car c2 = (Car)b;

      //    if (c1.year < c2.year)
      //        return 1;

      //    if (c1.year > c2.year)
      //        return -1;

      //   else
      //        return 0;
      //}

     



    }
}
