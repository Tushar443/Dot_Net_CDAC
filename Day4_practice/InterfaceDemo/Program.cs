using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            demoInterface d = new InterfaceImple();
            d.display();
            d.dispaly1();
        }
    }

    interface demoInterface
    {
         void display();
         void dispaly1();
    }

    class InterfaceImple : demoInterface
    {
        public void dispaly1()
        {
            Console.WriteLine("Display 1");
        }

        public void display()
        {
            Console.WriteLine("Display 2");
        }
    }
}
