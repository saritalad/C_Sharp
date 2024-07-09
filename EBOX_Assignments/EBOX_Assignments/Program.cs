using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void del(int a, int b);
delegate void mydel();
delegate int urdel();


namespace EBOX_Assignments
{
    using System;
    //class Event
    //{
    //    public Event()
    //    {
    //        Console.Write("In Event ");
    //    }
    //}

    //class StageShow : Event
    //{
    //    public StageShow():base()
    //    {
    //        Console.Write("In StageShow ");
    //    }
    //}
    //class User
    //{
    //    public string _username;
    //    protected string _password;
    //    public User()
    //    {
    //        _username = "xxx";
    //        _password = "yyy";
    //        Console.WriteLine("User obj" + _username);
    //    }
    //    public User(string u,string p)
    //    {
    //        _username = u;
    //        _password = p;
    //    }
    //}
    //class Owner : User
    //{
    //    public string _hallName;
    //    public Owner(string u, string _password, string _hallName):base()
    //    {
    //        base._username = u;
    //        base._password = _password;
    //        this._hallName = _hallName;
    //        Console.WriteLine("Owner obj"+_username);
    //    }
    //}
    //class User
    //{
    //    public string _name;
    //    public string _username;
    //    public string _password;
    //    public void show()
    //    {
    //        Console.WriteLine(this._name + " " + this._username);
    //    }
    //}

    //class HallOwner : User
    //{
    //    public string _hallName = "The Great Hall";
    //    public void show()
    //    {
    //        Console.WriteLine(this._hallName);
    //    }
    //}
    public sealed class Generic<T>
    {
        Stack<T> stk = new Stack<T>();// data member
        public void push(T obj)
        {
            stk.Push(obj);
        }
        public T pop()
        {
            T obj = stk.Pop();
            return obj;
        }
    }
   

    class Program
    {
        //static void Main(string[] args)
        //{
            //string a="10";
            //a.GetType();
            //a.GetTypeCode();
            //Console.WriteLine(a.GetHashCode());
            //int[,] arr = { { 23, 85 }, { 32, 50 }, };
            //Console.WriteLine(arr[0, 0]);
            //Console.WriteLine(arr[0, 1]);
            //Console.WriteLine(arr[1, 0]);
            //Console.WriteLine(arr[1, 1]);
            //    int s, n;
            //Loop:
            //    try
            //   { 
            //        Console.WriteLine("enter no of dys");
            //        n = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("enter cost of dys");
            //        s = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("per day cost ="+s/n);

            //    }
            //    catch(DivideByZeroException d)
            //    {
            //        Console.WriteLine(nameof(DivideByZeroException));
            //        goto Loop;
            //    }

            //HallOwner e = new HallOwner();
            //e._name = "Cassandra";
            //e._username = "cassandra";
            //e._password = "cassandra123";
            //e.show();


            //Owner o = new Owner("Cassandra", "cassandra", "The Great hall");
            //  Console.WriteLine(o._password);


            //new StageShow();
            //Generic<string> g = new Generic<string>();
            //g.push("40");
            //Console.WriteLine(g.pop());
            //Console.ReadLine();

            //Console.ReadKey();

        }
      //  public static void MySum(int a, int b) { Console.WriteLine(a + b); }
    }
//}
