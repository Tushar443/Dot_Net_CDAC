using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(10);
            arrList.Add("Tushar");
            arrList.Add(1341.5);
            arrList.Add(true);


            arrList.Remove("Tushar");
            arrList.RemoveAt(0);

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

            // Console.WriteLine("Size of ArrayList " +arrList.Count);
            
        }
    }
}
