using System;
using System.Reflection;
namespace Assembly_Loader_Application
{
    static class MyClass
    {
        public static void Inform(string parameter)
        {
            Console.WriteLine("Inform:parameter={0}", parameter);
        }
    }
    class Program1
    {
        static void Main()
        {
           
           
            // Call it with each of these parameters.  
            string[] parameters = { "Raj", "Test" };
            // Get MethodInfo.  
            Type type = typeof(MyClass);// 
            MethodInfo info = type.GetMethod("Inform");// MyClass.Inform(parameter)
          //  MethodInfo info = "Inform";
            // Loop over parameters.  
            foreach (string parameter in parameters)
            {
                info.Invoke(null, new object[] { parameter });
                
            }
        }
    }
}
