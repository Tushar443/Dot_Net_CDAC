using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    sealed class staticClass
    {
        void dispaly()
        {
            Console.WriteLine("Static Diplay");
        }
        
    }

    //class impleStatic : staticClass   //error
    // {

    //}
}
