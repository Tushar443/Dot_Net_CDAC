using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Exception
{
    class Program
    {
        static void Main1(string[] args)
        {
            Object o = null;
           int i = 0;
            try
            {
                // o.ToString();
                int j = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(12 / i);

            }
           catch(ArithmeticException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(" Atrithmatic Exception");
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Null Referance exception");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Other Excetion");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine("Remaininig code");
            Console.WriteLine("Remaininig code");
            Console.WriteLine("Remaininig code");


            Console.ReadLine();
        }
        static void Main()
        {
            MyClass myClass = new MyClass();
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                myClass.P = i;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Works!!!!!");
            }

            Console.WriteLine(myClass.P);
        }
    }
    class MyClass
    {
        private int p;

        public int P
        {
            get { return p; }
            set
            {
                if (value < 100)
                {
                    p = value;
                }
                else
                {
                    Exception ex;
                    ex = new Exception();
                    //ex = new Exception("Please Enter less than 100");

                    ex = new InvalidPVale("Invalid P");
                    throw ex;

                }
            }
        }
    }

    class InvalidPVale : Exception
    {
        public InvalidPVale(string message) : base(message)
        {
            
        }
    }
}
