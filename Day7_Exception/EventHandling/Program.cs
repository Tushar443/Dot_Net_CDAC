using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class Program
    {
        static void Main1()
        {
            MyClass myClass = new MyClass();
            myClass.InvalidId += ObjectIdInvalide;
            myClass.ID = 111111;
        }

        static void ObjectIdInvalide()
        {
            Console.WriteLine("Invalide ID please Enter Again");
        } 
    }

    public delegate void InvalidIdEventHandler();
    class MyClass
    {
        public event InvalidIdEventHandler InvalidId;
        private int id;
        public int ID
        {
            get { return id; }
            set
            {
                if(value < 100)
                {
                    id = value;
                }
                else
                {
                    
                    InvalidId();     
                }
            }
        }
    }
}


namespace EventHandling2
{
    class Program2
    {
        static void Main2()
        {

            MyClass2 myClass = new MyClass2();
            myClass.InvalidId += ObjectIdInvalide;
            
            myClass.InvalidId += AnotherMethos;
            myClass.ID = 111111;
        }
            static void ObjectIdInvalide()
            {
                Console.WriteLine("Invalide ID please Enter Again");
            }
        static void AnotherMethos()
        {
            Console.WriteLine("Another Exception");
            Console.WriteLine("Another Exception");
        }
        }
    public delegate void InvalidIdEventHandler();
    class MyClass2
    {
        public event InvalidIdEventHandler InvalidId;
        private int id;
        public int ID
        {
            get { return id; }
            set
            {
                if (value < 100)
                {
                    id = value;
                }
                else
                {

                    InvalidId();
                }
            }
        }
    }
}


namespace EventHandling3
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.InvalidId += ObjectIdInvalide;
            myClass.ID = 45;
            myClass.paramEvent += MyClass_paramEvent;
            myClass.ID = 111111;
        }

        private static int MyClass_paramEvent(int value)
        {
            Console.WriteLine("PAram Event Call "+ value);
            return 0;
        }

        static void ObjectIdInvalide()
        {
            Console.WriteLine("Invalide ID please Enter Again");
        }
    }

    public delegate void InvalidIdEventHandler();
    public delegate int ParamEventHAlnder(int value);
    class MyClass
    {
        public event InvalidIdEventHandler InvalidId;
        public event ParamEventHAlnder paramEvent;
        private int id;
        public int ID
        {
            get { return id; }
            set
            {
                if (value < 100)
                {
                    id = value;
                }
                else
                {
                    paramEvent(ID);
                    InvalidId();
                }
            }
        }
    }
}
