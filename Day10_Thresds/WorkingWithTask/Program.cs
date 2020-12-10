using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


 
//  return Type is void 
namespace WorkingWithTask
{
    class Program
    {
        static void Main1(string[] args)
        {
            Action objAction = Func1;
            Task t1 = new Task(objAction);
            //Task t1 = new Task(Func1);
            //Task t1 = new Task(new Action(Func1));

            Task t2 = new Task(Func2);

            t1.Start();
            t2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main function {0} call {1}",Thread.CurrentThread.ManagedThreadId,i);

            }
            Console.ReadLine();
        }

        private static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("second function {0} call {1}",Thread.CurrentThread.ManagedThreadId,i);
            }
        }

    private static void Func1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First function {0} call {1}",Thread.CurrentThread.ManagedThreadId,i);
            }
        }
    }
}

// 2 differnt way of writting
namespace WorkingWithTask2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Action obj = Func1;
            Task t1 = Task.Run(obj);

            Action obj1 = Func2;
            Task t2 = Task.Factory.StartNew(obj1);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main function {0} call {1}", Thread.CurrentThread.ManagedThreadId, i);

            }
            Console.ReadLine();
        }

        private static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("second function {0} call {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }

        private static void Func1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First function {0} call {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}

// Void Return type with parameters
namespace WorkingWithTask3
{
    class Program
    {
        static void Main3(string[] args)
        {
            Action<object> obj = Func1;
            Task t1 = new Task(obj, "Tushar");
            //string s = "Tushar";
            //Task t1 = Task.Run(delegate () { Console.WriteLine(s); }); 

            Action<object> obj1 = Func2;
            Task t2 = new Task(obj1, "Thunder");
            //Task t2 = Task.Factory.StartNew(obj1,"Thunder");

            t1.Start();
            t2.Start();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main function {0} call {1}", Thread.CurrentThread.ManagedThreadId, i);

            }
            Console.ReadLine();
        }

        private static void Func2(Object o )
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("second function {0} call {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }

        private static void Func1(Object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First function {0} call {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}


// Calling method with return type
namespace WorkingWithTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> obj = Func1;
            Task<int> t1 = new Task<int>(obj);
             

            Func<object,int> obj1 = Func2;
            Task<int> t2 = new Task<int>(obj1, "Thunder");
          

            t1.Start();
            t2.Start();

            if (!t1.IsCompleted)
            {
                t1.Wait();
            }
            else
            {
                Console.WriteLine(t1.Result);
            }

            if (!t2.IsCompleted)
            {
                t2.Wait();
            }
            else
            {
                Console.WriteLine(t2.Result);
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main function {0} call {1}", Thread.CurrentThread.ManagedThreadId, i);

            //}
            Console.ReadLine();
        }

        private static int Func2(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("second function {0} call {1} {2}", Thread.CurrentThread.ManagedThreadId, i,o.ToString());
            }
            return 1;
        }

        private static int Func1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First function {0} call {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
            return 1;
        }
    }
}
