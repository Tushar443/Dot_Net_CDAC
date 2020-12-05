using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoAbs d = new DemoAbs();
            DemoAbs d = new derivedClass();
            d.display();
            d.display1();
            d.display2();
            d.display3(23);
            d.S = 34;
            Console.WriteLine(d.S);
        }
    }

    abstract class DemoAbs
    {
        protected  int s;
        public abstract int S
        {set;
         get;}
        public abstract void display();
        public virtual void display1()
        {
            Console.WriteLine("Abs Dispaly 1");
        }

        public  void display2()
        {
            Console.WriteLine("Abs Dispaly 2");
        }

        public void display3(int i)
        {
            Console.WriteLine("Abs Display 3");
        }
    }

    class derivedClass : DemoAbs
    {
        public override int S
        {
            get
            {
                return s;

            }
            set
            {
                s = value;

            }
        }

        public override void display()
        {
            Console.WriteLine("Derived Display");    
        }

        public override void display1()
        {
            Console.WriteLine("Derived Dispaly 1");
        }

        //  method hinding
        public new void display2()
        {
            Console.WriteLine("Derived Dispaly 2");
        }

        public void display3(int i ,int j)
        {
            Console.WriteLine("Dervied display 3");
        }

    }
}
