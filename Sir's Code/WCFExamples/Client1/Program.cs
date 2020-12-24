using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client1
{
    class Program
    {
       
        static void Main1()
        {
            ServiceReference1.ServiceClient obj = new ServiceReference1.ServiceClient();
            //Console.WriteLine(obj.Hello() );
            Console.WriteLine("B");
            obj.Hello2(); //IsOneWay=True
            Console.WriteLine("A");
            Console.ReadLine();
        }

        //async code with events
        static void Main2()
        {
            ServiceReference1.ServiceClient obj = new ServiceReference1.ServiceClient();
            //Console.WriteLine(obj.Hello() );
            Console.WriteLine("B");

            obj.HelloCompleted += Obj_HelloCompleted;
            obj.HelloAsync();
            Console.WriteLine("A");
            Console.ReadLine();
        }

        private static void Obj_HelloCompleted(object sender, ServiceReference1.HelloCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }
        //async code with BeginMethodName and EndMethodName
        static void Main3()
        {
            ServiceReference1.ServiceClient obj = new ServiceReference1.ServiceClient();
            Console.WriteLine("B");

            obj.BeginHello( delegate(IAsyncResult ar)
            {
                string s = obj.EndHello(ar);
                Console.WriteLine(s);
            }, null);


            Console.WriteLine("A");
            Console.ReadLine();
        }
        static void Main4()

        {
            ServiceReference2.Service1Client obj = new ServiceReference2.Service1Client();
            Console.WriteLine(obj.Hello());
        }
        static void Main5()
        {
            BasicHttpBinding myBinding = new BasicHttpBinding();

            EndpointAddress myEndpoint = new EndpointAddress("http://localhost:8000/HelloService");
            ChannelFactory<IService> myChannelFactory = new ChannelFactory<IService>(myBinding, myEndpoint);
            
            IService wcfClient1 = myChannelFactory.CreateChannel();
            Console.WriteLine(wcfClient1.Hello());
            Console.ReadLine();
        }
       
    }
    //can be generated from .... svcutil.exe http://localhost:8000/HelloService
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Hello();
    }
}
