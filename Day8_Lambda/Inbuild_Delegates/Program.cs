using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbuild_Delegates
{
    class Program
    {
        static void Main1(string[] args)
        {
            Action o = Display;
            //o();
            Action<int,int> o1 = Display;
            o1(2,6);
            
        }
        static void Display(int i, int j)
        {
            Console.WriteLine("Dispaly " + i + " " + j);
        }
        static void Display()
        {
            Console.WriteLine("Display");
        }
    }


}

namespace Func_Delegate
{
    class Program
    {
        static void Main2(string[] args)
        {
            Func<int, int, int> o = Display;
            Console.WriteLine(o(34, 56));

            Func<int> o1 = Display;
            Console.WriteLine(o1());


        }
        static int Display(int i, int j)
        {
            return i + j;
        }
        static int Display()
        {
            Console.WriteLine("Display");
            return 1;
        }

    }


}


namespace Predict_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> o = Display;
            Console.WriteLine(o(3));
          //  Predicate<> o1 = Display;  //error we need to pass atleast 1 parameter

        }
        static bool Display(int i)
        {
            
            return true;
        }
        static bool Display()
        {
            Console.WriteLine("Display");
            return false;
        }

    }


}