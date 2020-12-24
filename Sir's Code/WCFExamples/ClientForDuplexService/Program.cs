using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ClientForDuplexService
{
    public class CallBackHandler : ServiceReference1.IServiceCallback
    {

        #region IServiceCallback Members

        public void GetData(string value, string value2)
        {
            Console.WriteLine(value);
            Console.WriteLine(value2);
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext site = new InstanceContext(new CallBackHandler());
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient(site);
            Console.WriteLine("Press enter to call method");
            Console.ReadLine();
            Console.WriteLine("Method called");
            proxy.RegisterForCallBack("hello");
            Console.WriteLine("Method call ended");
            Console.ReadLine();

        }
    }
}
