using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void del1();
    public delegate int delAdd(int i, int j);
    class Program
    {
        static void Main(string[] args)
        {
            del1 objDell = new del1(Dispaly);
            //objDell();

            objDell += new del1(Show);
            objDell();

            Console.WriteLine();
            Console.WriteLine();


            //objDell = Dispaly;
            objDell += Show;
            //objDell -= Dispaly;

            //objDell -= Show;
            // objDell();
            //objDell += new del1(Show);

            //objDell();
            //delAdd ibjAdd = new delAdd(Addition);
            //int sum = ibjAdd(5, 8);
            //Console.WriteLine(sum);

            del1 objectNew = (del1)Delegate.Combine(new del1(Show), new del1(Dispaly), new del1(Dispaly), new del1(Show));
            // objectNew();
            //objectNew = (del1)Delegate.Remove(objectNew, new del1(Dispaly));
            objectNew = (del1)Delegate.RemoveAll(objectNew, new del1(Dispaly));

            objectNew();

        }
        public static void Dispaly()
        {
            Console.WriteLine("Display");
        }

        public static void Show()
        {
            Console.WriteLine("Show");
        }
        public static int Addition(int x, int y)
        {
            return x + y;
        }
    }
}
