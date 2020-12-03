using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //  InherMethods i = new InherMethods();
            // i.S = 23;  //error

            //BaseClass b = new BaseClass();
            //b.display();
            //b.display1();
            //b.display2();

            //DerivedClass b1 = new DerivedClass();
            //BaseClass b1 = new DerivedClass();
            //b1.display();
            //b1.display1();
            //b1.display2();

            //BaseClass b = new BaseClass();
           // BaseClass b = new DerivedClass();
            //DerivedClass b = new DerivedClass();
            //b.display(23,34);
            //b.display1();
            //b.display2();



            DerivedClass b = new DerivedClass();
            b.display(23, 34);
            b.display1();
            b.display2();


            Console.ReadLine();
        }
    }

    // Read Only Properties
    class InherMethods
    {
        private int s;
        public int S
        {
           private set
            {
                s = value;
            }
            get
            {
                return s;
            }
        }
    }

    // overriding 
    class BaseClass
    {
        public void display(int i)
        {
            Console.WriteLine("Base Display1 param ");
        }

        public virtual void display1()
        {
            Console.WriteLine("Base Display 1 ");
        }

        public void display2()
        {
            Console.WriteLine("Base Display 2 ");
        }
    }

    class DerivedClass : BaseClass
    {
        public void display(int i,int j)
        {
            Console.WriteLine("Dervied 2 paeram Display");
        }

        public override void display1()
        {
            Console.WriteLine("Derived Display 1 ");
        }

        public  new void display2()
        {
            Console.WriteLine("Derived Dispaly 2");
        }
    }
}
