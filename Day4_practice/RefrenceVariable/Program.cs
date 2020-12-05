using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrenceVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 100;
            //int j = 200;
            int i = 100;
            int j = 200;
            //Swap(ref i, ref j);
            //Console.WriteLine(i);
            //Console.WriteLine(j);


            int p;
            int q;
            Init(out p, out q);
            Swap(ref p, ref q);
            Console.WriteLine(p);
            Console.WriteLine(q);
        }

        public static void Init(out int p,out int q)
        {
            p = 700;
            q = 800;
        }
        public static void Swap(ref int i,ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine("@@@@@@@@@@@@@@@@");
        }
    }

    class DemoRefence
    {
       
    }
}
