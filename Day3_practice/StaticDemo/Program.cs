using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            demo.s1 = 13;
            Console.WriteLine(demo.s1);
            demo.staticMethod();
            //demo d = new demo();
            //Console.WriteLine(d.);

            //demoStatic ds = new demoStatic(); // error
        }
    }

    class demo
    {
        public static int s1;
        public int s2;

        public static void staticMethod()
        {
            
            //Console.WriteLine(s2);
            Console.WriteLine(s1);
        }
    }

   static class demoStatic
    {
        public static int s1;
        //public int s2;  //Error

        public static void staticMethod()
        {

            //Console.WriteLine(s2);  // Error
            Console.WriteLine(s1);
        }
    }
}
