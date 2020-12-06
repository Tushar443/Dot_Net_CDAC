using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myClass = new Myclass();
            //myDell dellObj = new myDell(myClass.Add);
            //dellObj += new myDell(myClass.sub);
            //Console.WriteLine(dellObj(3,5));

            Console.WriteLine(myClass.callMethod(myClass.Add, 3, 6));
            Console.WriteLine(myClass.callMethod(myClass.sub, 3, 6)) ;
            Console.WriteLine(myClass.callMethod(myClass.mul, 3, 6)) ;
            Console.WriteLine(myClass.callMethod(myClass.Add, 3, 6));

        }
    }

    public delegate int myDell(int x ,int y);
    class Myclass
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }

        public int mul(int a, int b)
        {
            return a * b;
        }
        public int callMethod(myDell objDell,int a,int b)
        {
            return objDell(a, b);
        }
    }
}
