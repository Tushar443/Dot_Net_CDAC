using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

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
        public void display(int i, int j)
        {
            Console.WriteLine("Dervied 2 paeram Display");
        }

        public override void display1()
        {
            Console.WriteLine("Derived Display 1 ");
        }

        public new void display2()
        {
            Console.WriteLine("Derived Dispaly 2");
        }
    }
}
