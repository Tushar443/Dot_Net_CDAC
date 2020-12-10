using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeoThread
{
    class Program
    {
        static void Main1(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);
            t1.Priority = ThreadPriority.Highest;
           // t1.IsBackground = true;
            //t2.IsBackground = true;
            t1.Start();
           // t1.Join();
           // Console.WriteLine(t1.IsAlive);
            t2.Start();
            //t2.Join();
           // t1.Abort();
           // Console.WriteLine(t1.IsAlive);
            // Func1();
            //Func2();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
            }
            
            //Console.ReadLine();
        }
        public static void Func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("First : "+i);
            }
        }
        public static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("second : "+i);
            }
        }
    }
}

namespace DeoThread2
{
    class Program
    {
        static void Main3(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);
            //t1.Priority = ThreadPriority.Highest;
            t1.IsBackground = false;
           // Console.WriteLine(t1.ThreadState == ThreadState.Background);
            //Console.WriteLine(t1.ThreadState == ThreadState.Unstarted);
            t1.Start();
            //Console.WriteLine(t1.ThreadState == ThreadState.WaitSleepJoin);

            //Console.WriteLine(t1.ThreadState == ThreadState.Running);
            t2.Start();


            //instead of using suspend and Resume we used set and waitone
            WaitHandle wh = new AutoResetEvent(false);
            wh.WaitOne();
            ((AutoResetEvent)wh).Set();
            for (int i = 0; i < 10; i++)
            {
               // Console.WriteLine("Main : " + i);
                //Thread.Sleep(1000);

            }
            //Console.WriteLine(t1.ThreadState == ThreadState.Aborted);
            //Console.WriteLine(t1.ThreadState == ThreadState.AbortRequested);
            //Console.WriteLine("@@@@@@ Stopeee");
            //Console.WriteLine(t1.ThreadState == ThreadState.StopRequested);
            //Console.WriteLine(t1.ThreadState == ThreadState.Stopped);
            
            //Console.WriteLine("@@@@ Suspended");
            //Console.WriteLine(t1.ThreadState == ThreadState.SuspendRequested);
            //Console.WriteLine(t1.ThreadState == ThreadState.Suspended);
      


            Console.ReadLine();
        }
        public static void Func1()
        {
            for (int i = 0; i < 10; i++)
            {
                

                Console.WriteLine("First : " + i);
                Thread.Sleep(1000);
            }
        }
        public static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
               // Console.WriteLine("second : " + i);
                //Thread.Sleep(1000);

            }
        }
    }
}


namespace DeoThread3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            // Thread t2 = new Thread(Func2);
            Employee e = new Employee();
            e.id = 1;
            e.name = "THunder";
            t1.Start(e);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
            }

            //Console.ReadLine();
        }
        public static void Func1(Object o)
        {
            Employee e = (Employee)o;
            for (int i = 0; i < 100; i++)
            {
                
                Console.WriteLine("First : " + i + " "+e.name);
            }
        }
        public static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("second : " + i);
            }
        }
    }
    class Employee
    {
        public int id;
        public string name;
    }
}