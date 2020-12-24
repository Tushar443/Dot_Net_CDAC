using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForWS
{
    class Program
    {
        static void Main1()
        {
            localhost.WebService1 objService = new localhost.WebService1();
            Console.WriteLine(objService.HelloWorld());
            Console.WriteLine(objService.Add(10, 20));
            Console.ReadLine();
        }
        static void Main()
        {
            localhost.WebService1 objService = new localhost.WebService1();
            Console.WriteLine("Before");
            //Console.WriteLine(objService.LomgRunningMethod());

            objService.LomgRunningMethodCompleted += ObjService_LomgRunningMethodCompleted;
            objService.LomgRunningMethodAsync();

            Console.WriteLine("After");
            Console.ReadLine();
        }

        private static void ObjService_LomgRunningMethodCompleted(object sender, localhost.LomgRunningMethodCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }

        static void Main3()
        {
            localhost.WebService1 objService = new localhost.WebService1();
            Console.WriteLine("Before");
            Func<string> oDel = objService.LomgRunningMethod;

            oDel.BeginInvoke(delegate (IAsyncResult ar) 
            {
                Console.WriteLine(oDel.EndInvoke(ar));    
            }, null);

            Console.WriteLine("After");
            Console.ReadLine();

        }
    }
}
