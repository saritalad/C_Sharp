using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CloneProject
{
    class Complex:ICloneable 
    {
        int real;

        public int Real
        {
            get { return real; }
            set { real = value; }
        }
        int imaginary;

        public int Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }
        public Complex()
        {
            real = 1;
            imaginary = 1;
        }
        public Complex(int r, int i)
        {
            real = r;
            imaginary = i;
        }

        public Complex (Complex c)
        {
            real = c.real;
            imaginary = c.imaginary;
        }
        public override string  ToString()
       {
    return (real + "+ i " + imaginary);
            
        }
        //deep Cloning
        public object Clone()
        {
            return this.MemberwiseClone();// object class 
        }

        


    }
}
