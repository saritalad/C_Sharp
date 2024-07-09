using System;
namespace RectangleApplication
{
    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public virtual void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle  
    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double c,double l, double w)
            : base(l, w)
        { cost = c; }
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
       public override void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 70.5,10.5);
            t.Display();
            Console.ReadLine();
        }
    }
}