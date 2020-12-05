using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            short? s = 23;
            //short s1 = null; //error

            s = null;
            //Console.WriteLine(s+ "null");

            Nullable<int> j = 100;

            j = 0;

            //if (j != null)
            //{
            //    Console.WriteLine("not Null");
            //}
            //else {
            //    Console.WriteLine(  "Null");
            //       }
            //Console.WriteLine(j);



            //int? ak = null; 
            //if (ak.HasValue)
            //{
            //    j = ak.Value;
            //}
            //else
            //{
            //    ak = 0;
            //}
            //Console.WriteLine(j);
            //Console.WriteLine(ak);


            int? p = null;

            int? q = p.GetValueOrDefault();
            //q = p.GetValueOrDefault(1);

            q = p ?? 10; //null coalescing operator

            Console.WriteLine(q);

        }
    }
}
