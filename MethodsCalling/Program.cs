using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsCalling
{
    class Program
    {
        static void Main(string[] args)
        {
            //demoMethods d = new demoMethods();   //error

        }
    }

    static class demoMethods
    {
        private int a;
        private static int b;

        public static int B
        {
            set
            {
                b = value;
            }
            get
            {
                return b;
            }
        }

        public int A
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }

       

    }


    class tusharMore
    {
        private int a;
        private static int b;

        public static int B
        {
            set
            {
                b = value;
            }
            get
            {
                return b;
            }
        }

        public int A
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }

        public int methodStatic
        {

        }
    }
}
