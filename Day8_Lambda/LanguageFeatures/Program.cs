using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//implicit variables and Object Initializer
namespace LanguageFeatures
{
    class Program
    {
        static void Main1(string[] args)
        {
            //int i = 0;
            //var i1 = 100;
            //var i2 = "String";
            // var i = 45; //error

            MyClass o1= new MyClass() { p = 123,q=345 };
            MyClass o2 = new MyClass { p = 999,q=333 };
            MyClass o3 = new MyClass(1,2) {};

            Console.WriteLine(o3.q);
            Console.WriteLine(o2.q);
            Console.WriteLine(o1.q);
        }
    }
    class MyClass
    {
        public int p;
        public int q;

        public MyClass(int p ,int q)
        {
            this.p = p;
            this.q = q;
        }
        public MyClass()
        {
            this.p = 100;
            this.q = 100;
        }
    }
}

// Anonymous Type or anonymous class
namespace LanguageFeatures2
{
    class Program
    {
        static void Main4()
        {               
            var myClass = new {  id=1, name="Tushar"};
            var myClass1 = new { id = 2, name = "kishor" ,num=34};
            Console.WriteLine(myClass.name);

            Console.WriteLine(myClass.GetType().ToString());
            Console.WriteLine(myClass1.GetType().ToString());

        }
    }
}


namespace ExtensionMethod
{
    class Program
    {
        static void Main6(string[] args)
        {
            int i=0;
            i.Diaplay();
            String o="";
            Console.WriteLine(o.Display(4,"Tushar"));

        }
    }

    static class MyClass
    {
        public static void Diaplay(this int i)
        {
            Console.WriteLine("Display");
        }
        public static int Display(this string name ,int id,string name2)
        {
            Console.WriteLine("88"+ name+"88");
            Console.WriteLine(name2 + " "+ id);
            return 0;
        }
    }
}


//with Interface and Classes
namespace ExtensionMethod2
{
    class Program
    {
        static void Main6(string[] args)
        {
            IMyInterface obj = new MyClass();
            Console.WriteLine(obj.div(20, 4));
        }
    }

    public interface IMyInterface
    {
        int add(int a, int b);
        int multiple(int x, int y);
    }

    public static class DemoExtension
    {
        public static int div(this IMyInterface myInterface,int a,int b)
        {
            return a / b;
        }
    }

    class MyClass : IMyInterface
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int multiple(int x, int y)
        {
            return x * y;
        }
    }


}


namespace PartialClasses
{
    class Program
    {
        static void Main6(string[] args)
        {
            MyClass o = new MyClass();
            o.Display();
            o.Display(4, 6);
           

        }
    }
    public partial class MyClass
    {
        public int i;
        public void Display()
        {
            Console.WriteLine(i + " " + j);
        }
        
    }

    public partial class MyClass
    {
        public int j;
        public void Display(int i,int j)
        {
            Console.WriteLine(i + " " + j);
        }
        


    }
}


namespace PartialMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           Class1 o = new Class1();
            Console.WriteLine(o.check());


        }
    }
    public partial class Class1
    {
        partial void validate();
        public bool check()
        {
            validate();
            return true;
        }
    }
    public partial class Class1
    {
        partial void validate()
        {
            Console.WriteLine("Validate call");
        }
    }
}



