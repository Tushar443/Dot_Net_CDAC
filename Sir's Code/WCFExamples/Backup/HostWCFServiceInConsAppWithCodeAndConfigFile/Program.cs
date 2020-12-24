using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HostWCFServiceInConsAppWithCodeAndConfigFile
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Hello();
        [OperationContract(IsOneWay = true)]
        void Hello2();
    }
    public class HelloService : IService
    {

        #region IService Members

        public string Hello()
        {
            return "Hello World";
        }
        public void Hello2()
        {
            System.Threading.Thread.Sleep(3000);
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
    }

}
