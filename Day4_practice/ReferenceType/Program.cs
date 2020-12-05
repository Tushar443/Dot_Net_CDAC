using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            demoClass d1 = new demoClass();
            demoClass d2 = new demoClass();
            d1.i = 100;
            d2.i = 200;
            d1 = d2;
            d2.i = 300;

            //Console.WriteLine(d1.i);
            //Console.WriteLine(d2.i);

            int x = 100;
            int y = 200;
            x = y;

            y = 300;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //demoClass o1 = new demoClass();
            //o1.i = 100;
            //demoReferance(ref o1);
            //Console.WriteLine(o1.i);


            demoClass o1;
            demoOUT(out o1);
            Console.WriteLine(o1.i);
        }

        public static void demoReferance(ref demoClass obj1) //  obj1=o1
        {
           obj1 = new demoClass();
            obj1.i = 300;
        }

        public static void demoOUT(out demoClass obj2)
        {
            obj2 = new demoClass();
            obj2.i = 100;
        }
        
    }

    class demoClass
    {
        public int i;
    }
}
