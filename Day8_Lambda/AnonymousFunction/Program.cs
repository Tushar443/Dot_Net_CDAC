using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunction
{
    class Program
    {
        // public int MyProperty { get; set; }public int MyProperty { get; set; }
        static void Main1(string[] args)
        {
            int i = 10;
            Action o = delegate
            {
                ++i;
                Console.WriteLine("Display" + i);
            };

            o();
            //o();
            //o();
            //o();
            //o();

            Action<int, int> add = delegate (int p, int j)
              {
                  int k = p+ j;
                  Console.WriteLine("Addition is : " + k);
              };
            
            add(34, 56);


            Func<int, int, int> o1 = delegate (int p, int j)
              {
                  return p + j;
              };


            Console.WriteLine(o1(45, 67));

            Func<int> o2 = delegate

            {
                return i;
            };

            Console.WriteLine(o2());
        }

    }

}

namespace LamdaFunction
{
    class Program
    {
        // public int MyProperty { get; set; }public int MyProperty { get; set; }
        static void Main(string[] args)
        {
            int i;
            Func<int, int> o = (j) =>
            {
                if (j > 100)
                {
                    return j;

                }
                return 100;
            };
            Console.WriteLine(o(108));

            Func<int, int, int, int> o1 = (a, b, c) =>
            {  
                return a+b+c;
            };

            Console.WriteLine(o1(4, 5, 6));
        }

    }

}
