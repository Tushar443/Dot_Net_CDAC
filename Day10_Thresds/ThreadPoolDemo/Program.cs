using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(poolFun1), "Tushar");
            ThreadPool.QueueUserWorkItem(poolFun2, "Thunder");


            int workerthreads, iothreads;
            //ThreadPool.GetAvailableThreads(out workerthreads, out iothreads);
            //Console.WriteLine(workerthreads);
            //Console.WriteLine(iothreads);

            //ThreadPool.SetMaxThreads;
            //ThreadPool.SetMinThreads;
            //ThreadPool.GetMaxThreads;
            //ThreadPool.GetMinThreads;
           


            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main "+ i);
            }
        }
        public static void poolFun1(Object o)
        {
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("Pool Fun 1"+ i + " "+ o.ToString());
            }
        }
        public static void poolFun2(Object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Pool Fun 2 "+o.ToString());
            }
        }
    }

}
