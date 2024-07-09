using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExapression_Delegate
{delegate string mylambdadel(string name);
    delegate void mylambdadel1(string name);

    class Program
    {
        static void Main(string[] args)
        {
            mylambdadel delobj = name => { return "Hello " + name; };
            Console .WriteLine ("Output : "+delobj("Sarita "));
            mylambdadel1 delobj1 = name => { Console .WriteLine ( "Hello " + name); };

            delobj1.Invoke("Samiksha");    
        }
    }
}
