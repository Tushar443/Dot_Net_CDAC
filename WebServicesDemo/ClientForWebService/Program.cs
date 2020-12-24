using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService1 objService = new localhost.WebService1();
            Console.WriteLine(objService.HelloWorld());
            objService.Add(34, 45);
            Console.ReadLine();
        }
    }
}
