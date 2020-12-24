using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNo1
{
    class Program
    {
        static void Main()
        {
            ServiceReference1.ServiceClient O = new ServiceReference1.ServiceClient();
            Console.WriteLine(O.Hello());
            Console.ReadLine();
        }
    }
}
