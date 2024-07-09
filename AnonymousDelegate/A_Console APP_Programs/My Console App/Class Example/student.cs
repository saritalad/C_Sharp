using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Example
{
    class student
    {
        int Rollno=1;
        string name = "Seed Student";
          
                  public void Display()
        {
            Console.WriteLine("Roll No "+Rollno +"\t"+"Name :"+name);
         }
                  public void GetData(int r, string n)
                  {
                      Rollno = r;
                      name = n;
                  }

                  }


    }

