using System;

namespace HelloDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            demo1 d = new demo1();
            d.P1=14;
            
            Console.WriteLine(d.P1);
        }
       // static void Main(string [] args)
       // {

       // }
    }
    class demo1
    {
        private int p1 ;
            public int P1
        {
            set
            {
                if(value< 100)
                {
                    p1 = value;
                }
                else
                {
                    Console.WriteLine( "Invalid ");
                }
            }
            get
            {
                return p1;
            }
        }
    }
}


namespace PravinAndAnjaliAndKishor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pravin cha Lagna");
        }
    }
}
