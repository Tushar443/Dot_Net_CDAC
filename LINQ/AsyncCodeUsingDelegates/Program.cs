using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AsyncCodeUsingDelegates
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("before");
            Action o = Display;
            o.BeginInvoke(null, null);
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static void Display()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display class");
        }
    }
}


namespace AsyncCodeUsingDelegates2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("before");
            Action<string> o = Display;
            o.BeginInvoke("Tushar",null,null);
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static void Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display " + s);
        }
    }
}

namespace AsyncCodeUsingDelegates3
{
    class Program
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("before");
            Func<string,string> o = Display;
            o.BeginInvoke("Tushar", delegate(IAsyncResult ar)
        {
                Console.WriteLine("Call Back Call");
            string result=  o.EndInvoke(ar);
            Console.WriteLine("Output : "+result);
            }, null);
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display " + s);
            return s.ToUpper();
        }

        //static void callBack(IAsyncResult ar)
        //{
        //    Console.WriteLine("Call Back Call");
        //}
    }
}

namespace AsyncCodeUsingDelegates4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("before");
            Func<string, string> o = Display;
            //o.BeginInvoke("kishor", delegate (IAsyncResult ar)
            //{
            //    string extra = ar.AsyncState.ToString();
                
            //    string result = o.EndInvoke(ar);
            //    Console.WriteLine("Output : " + result + " " + extra);
            //}, "Extra Data send to IAsyncResult");
           
            
             IAsyncResult ar =  o.BeginInvoke("Tushar",callBackfun,o);
            while (!ar.IsCompleted) ;
            ar.AsyncWaitHandle.WaitOne(); //waiting call 
            Console.WriteLine("After");
            Console.ReadLine();
        }

        private static void callBackfun(IAsyncResult ar)
        {
            AsyncResult result = (AsyncResult)ar;

            //Func<string, string> o=(Func<string, string>) ar.AsyncState;
            Func<string, string> o=(Func<string, string>) result.AsyncDelegate;
            string result2 = o.EndInvoke(ar);
            Console.WriteLine("Output : " + result2);

        }

        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display " + s);
            return s.ToUpper();
        }

        //static void callBack(IAsyncResult ar)
        //{
        //    Console.WriteLine("Call Back Call");
        //}
    }
}

