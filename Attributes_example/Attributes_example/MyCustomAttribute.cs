using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection ;

namespace Attributes_example
{
    [AttributeUsage(AttributeTargets.All)]
    class MyCustomAttribute : System.Attribute
    {
        string developername;

        public virtual string Developername
        {
            get { return developername; }

        }
        double version;

        public double Version
        {
            get { return version; }

        }
         public MyCustomAttribute(string D, double v)
        {
            this.developername=D;
            this.version=v;
           
        }
    }
}

