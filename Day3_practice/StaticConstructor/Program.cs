using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            demoCont dc = new demoCont();
            
            demoCont dc1 = new demoCont();
            demoCont dc2 = new demoCont();
            demoCont dc3 = new demoCont();
            demoCont dc4 = new demoCont();
            demoCont dc5 = new demoCont();
            demoCont dc6 = new demoCont();
            demoCont dc7 = new demoCont();
            Console.WriteLine(dc.NS);
            Console.WriteLine(demoCont.S);






        }
    }

    class demoCont
    {
        private int ns;
        private static int s;

        public int NS
        {
            get
            {
                return ns;
            }
            set
            {
                ns = value;
            }
        }

        public static int S
        {
            set
            {
                s = value;
            }
            get
            {
                return s;
            }
        }

        public demoCont()
        {
            ns=1;
            s++;
           // Console.WriteLine("0 param constructor");
        }
        static demoCont()
        {
            s=1;
            //Console.WriteLine("static consturctor");

        }

    }
}
