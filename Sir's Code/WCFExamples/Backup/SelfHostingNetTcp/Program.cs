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
    }
}
