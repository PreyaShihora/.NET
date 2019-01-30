using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p2
{
    public class Car
    {
        public virtual void display()
        {
            Console.WriteLine("This is Car class");
        }
    }
    public class Mahindra : Car
    {
        public override void display()
        {
            Console.WriteLine("This is Mahindra");
        }
    }
    public class Maruti : Car
    {
        public override void display()
        {
            Console.WriteLine("This is Maruti");
        }
    }
    class Inheritance
    {
        static void Main(String[] args){
        Maruti m1 = new Maruti();
        Mahindra m2 = new Mahindra();
        m1.display();
        m2.display();
        }
    }
}
