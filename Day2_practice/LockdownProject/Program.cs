using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass baseClass = new BaseClass();
            //baseClass.A = 12;
            // baseClass.display();
            subClass sub = new subClass();
            sub.A = 12;
            sub.B = 45;
            sub.display();

            Console.WriteLine("@@@@@@@@@@@@@@@@@@");

            BaseClass sub1 = new subClass();  //Complie time polymorphism
            subClass d2 = (subClass)sub1;

            d2.A = 134;
            d2.B = 45455;
            d2.display();

            
           
        }
    }
    class BaseClass
    {
        private int a;

        public int A
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }

        public virtual void display()
        {
            Console.WriteLine("A value is :" +a);
        }
    }

    class subClass : BaseClass
    {
        private int b;
        public int B
        {
            set
            {
                b = value;
            }
            get
            {
                return b;
            }
        }
        public override void  display()
        {
            base.display();
            Console.WriteLine("B value is : " + B);
        }
    }

    class DefaultProperties
    {
        private int P
        {
            get;set;
        }
    }
}
