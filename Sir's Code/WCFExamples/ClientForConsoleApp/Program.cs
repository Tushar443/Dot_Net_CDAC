using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientForConsoleApp
{
    class Program
    {
        static void Main()
        {
            ServiceReference1.ServiceClient sc = new ClientForConsoleApp.ServiceReference1.ServiceClient();
            Console.WriteLine(sc.Hello());
            sc.Hello2();
            Console.WriteLine("done");
            Console.ReadLine();

        }
        static void Main1()
        {
            ServiceReference1.ServiceClient sc = new ClientForConsoleApp.ServiceReference1.ServiceClient();

            Console.WriteLine(sc.Hello());



            sc.HelloCompleted += new EventHandler<ClientForConsoleApp.ServiceReference1.HelloCompletedEventArgs>(sc_HelloCompleted);
            sc.HelloAsync();




            sc.BeginHello(new AsyncCallback(Callback), sc);
            Console.WriteLine("done");
            Console.ReadLine();

        }
        static void Callback(IAsyncResult ar)
        {
            ServiceReference1.ServiceClient sc = (ServiceReference1.ServiceClient)ar.AsyncState;
            Console.WriteLine(sc.EndHello(ar));
        }
        static void sc_HelloCompleted(object sender, ClientForConsoleApp.ServiceReference1.HelloCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }
    }
}
