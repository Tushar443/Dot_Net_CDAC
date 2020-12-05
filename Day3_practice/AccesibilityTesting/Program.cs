using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesibilityTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrivedClass d = new DrivedClass();
            //Console.WriteLine(d.PUBLIC);
            //Console.WriteLine(d.PROTECTED_INTERNAL);
            //Console.WriteLine(d.INTERNAL);
        }
    }
    public class BaseClass
    {
        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
    }

    class DrivedClass : AccessModifires.BaseClass               //: BaseClass
    {
        public DrivedClass()
        {
            
            //this.PUBLIC;
            Console.WriteLine(this.PUBLIC);

            Console.WriteLine(this.PROTECTED);
            //Console.WriteLine(this.INTERNAL); // error not access
            Console.WriteLine(this.PROTECTED_INTERNAL);

        }
    }
}
