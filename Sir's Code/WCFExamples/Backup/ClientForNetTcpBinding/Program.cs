using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientForNetTcpBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiceClient sc = new ClientForNetTcpBinding.ServiceReference1.ServiceClient();
            Console.WriteLine(sc.Hello());
            Console.ReadLine();
        }
    }
}
