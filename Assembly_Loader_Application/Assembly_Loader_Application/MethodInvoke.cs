using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Assembly_Loader_Application
{
    class MethodInvoke
    {
        static void Main()
        {
            object result = new object();
            object[] Args = new object[] { 100, 200 };
            MethodInfo method;
            Type[] types = new Type[2];
            try
            {
                Assembly asm = Assembly.LoadFrom(@"D:\\MyclassLibrary.dll");

                types = asm.GetTypes();
                foreach (Type t in types)
                {
                    Console.WriteLine("class Names " + t.FullName);
                    method = t.GetMethod("Add");

                    if (method != null)
                    {
                        String typeName = t.FullName;
                        object obj = asm.CreateInstance(typeName);
                     //   MyClass obj = new MyClass();
                        result = method.Invoke(obj, Args);
                     //   int result = obj.Add(100, 200);
                        break;
                    }

                }

                String res = result.ToString();
                Console.WriteLine("Addition is: {0}", res);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
