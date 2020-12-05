using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FileIO file = new ImpleDemoClass();
            file.delete();
            DBFunction db = new ImpleDemoClass();
            db.delete();
        }
    }

    interface DBFunction
    {
        void insert();
        void update();
        void create();
        void delete();
    }

    interface FileIO
    {
        void open();
        void close();
        void delete();
    }

    class ImpleDemoClass : DBFunction,FileIO
    {
        public void close()
        {
            Console.WriteLine("file closed");
        }

        public void create()
        {
            Console.WriteLine("db Created");
        }

        void FileIO.delete()
        {
            Console.WriteLine("file deleted");
        }

        public void delete()
        {
            Console.WriteLine("db deleted");
        }

        public void insert()
        {
            Console.WriteLine("db inserted");
        }

        public void open()
        {
            Console.WriteLine("file open");
        }

        public void update()
        {
            Console.WriteLine("db updated");
        }
    }
}
