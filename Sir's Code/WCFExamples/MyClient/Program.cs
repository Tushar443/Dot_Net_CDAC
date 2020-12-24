using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main()
        {
            ServiceReference1.ServiceClient objService = new ServiceReference1.ServiceClient();
            Console.WriteLine(objService.Hello());
            Console.ReadLine();
        }
        static void Main2()
        {
            ServiceReference1.ServiceClient objService = new ServiceReference1.ServiceClient();
            objService.HelloCompleted += ObjService_HelloCompleted;
            objService.HelloAsync();
            Console.ReadLine();
        }

        private static void ObjService_HelloCompleted(object sender, ServiceReference1.HelloCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }

        static void Main3()
        {
            ServiceReference1.ServiceClient objService = new ServiceReference1.ServiceClient();
            objService.BeginHello(
                delegate (IAsyncResult ar)
                {
                    Console.WriteLine(objService.EndHello(ar));
                }
            , null);
            Console.ReadLine();
        }
    }
}
