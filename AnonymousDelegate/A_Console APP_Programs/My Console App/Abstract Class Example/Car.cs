using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class_Example
{
    class Car : Vehicle,IDisplayable ,IPrintable
    {
        string brand,model,color;
        int capacity;
        public static bool geared;
        
        public Car()
        {
            brand = "Maruti";
            model = "VXI";
            capacity = 4;
            color = "Ölive Green";
            geared = true;
        }
        public Car(string b, string m, int c, string clr, bool g)
        {
            brand = b;
            model = m;
            capacity = c;
            color = clr;
            geared = g;
        }
        public int GetSpeed(int sp)
        {
            return this.Speed = sp;
        }

        public override void show_speed()
        {
            Console.WriteLine("This Car has Average speed of :" 
                + this.Speed + " Km/h");
        }

              void IPrintable.show_details()
        {
            Console.WriteLine("The Car Brand Name :" + this.brand
                + "\n" + "The Model Name :" + this.model + "\n"
                + "Color :" + this.color);
            Console.WriteLine("................................");
        }
        void IDisplayable.show_details()
        {
            Console.WriteLine("The Car speed is " + this.Speed
                + "\n" + " It is " + this.capacity + "Seater Car");
            Console.WriteLine("Gear System :");
            Car.Show_TypeOf_Gears();
            Console.WriteLine("...............");
        }

        public static void Show_TypeOf_Gears()
        {
            if (geared == true)
                Console.WriteLine("Car is Auto Geared Driven");
            else
                Console.WriteLine("Car is Manually Geared Driven");
        }


    }

}
