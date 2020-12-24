using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingService1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiceClient objClient = new ServiceReference1.ServiceClient();

            Console.WriteLine(objClient.Hello());

            Console.ReadLine();
        }
    }
}
