using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Delegate_Sample
{
    class Program
    {
        public delegate string GenericDelegateNumber<T1, T2>(T1 a, T2 b);  
        static void Main(string[] args)
        {
            
            
            GenericDelegateNumber<int, int> gdInt = new GenericDelegateNumber<int, int>(AddInt);  
	Console.WriteLine(gdInt(3, 6));  
	GenericDelegateNumber<double, double> gdDouble = new GenericDelegateNumber<double, double>(AddDoubles);  
	
            
            Console.WriteLine(gdDouble(3.2, 6.9));
            GenericDelegateNumber<int, int> getmax = new GenericDelegateNumber<int, int>(Max); 
            Console .WriteLine (getmax (45,54));

	Console.ReadKey();  
	}  
	  
	// Generic Delegate takes generic types and returns a string  

  
	public static string AddDoubles(double a, double b)  
	{  
	return (a + b).ToString();    
	}  
	  
	public static string AddInt(int a, int b)  
	{    
	return (a + b).ToString();    
	}
    public static string Max(int a, int b)
    {
        if (a > b)
            return a+ " is greater";
        else
            return b + " is greater";
    }
        }
    }

