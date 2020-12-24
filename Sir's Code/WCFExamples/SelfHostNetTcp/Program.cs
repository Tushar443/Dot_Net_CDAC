using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace SelfHostNetTcp
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Hello();
    }
    public class HelloService : IService
    {

        #region IService Members

        public string Hello()
        {
            return "Hello World";
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(HelloService));
            host.Open();
            Console.ReadLine();
            host.Close();
        }
        static void Main1()
        {
            using (ServiceHost host = new ServiceHost(typeof( SelfHostNetTcp.HelloService)))
            {
                host.AddServiceEndpoint(typeof(
                   SelfHostNetTcp.IService), new NetTcpBinding(),
                   "net.tcp://localhost:9000/SelfHostNetTcp");
                host.Open();
                Console.WriteLine("Press <Enter> to terminate " +
                   "the Host application.");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
