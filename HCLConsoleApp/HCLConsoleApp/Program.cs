using System;



namespace HCLConsoleApp // logical folder to keep classes separately
{
    class Program
    {
        static void Main()
        { 
            string name;
            int x = 10;
            char reply = 'y';
            double r = 5.675678;
            decimal price = 60.00m;// m money 
            float y = 12.9f;
            // string format of number data 
          
            Console.WriteLine("x = "+x+"  r = "+r + " price ="+ price+" reply is"+ reply);
            //wel formated output for numbers
            Console.WriteLine("x  ={0} r = {1:F3} price ={2:C}+ y ={3:f2}",x,r,price,y);
            Console.WriteLine("x = "+(++x));
            Console.WriteLine("x = " + x);
            Console.WriteLine("y= " + (--y));

            x--;// unary operator   acting on only single operand
            x = 100;
            x %=50;  // assignment operator +=    x = x+50  
            Console.WriteLine("x = " + x);
            // -=
            //*=
            ///=
            //%=



            //Console.WriteLine("Enter your name ");
            //name = Console.ReadLine();
            //Console.WriteLine("Hi This is  \"" + name + "\' Working in HCL ");
            //Console.Write("**********************");


            Console.ReadKey();


        }
    }
}
