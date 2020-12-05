using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();

            
            m.dispaly(MyClass.TimeDay.afternoon);
            m.dispaly1(0);

            MyClass.Mystruct st = new MyClass.Mystruct();
            st.k=67;
        }
        
    }

    class MyClass
    {
        public enum TimeDay
        {
            morning,
            afternoon,
            evening,
            night
        }

        public struct Mystruct
        {
            public int k;
        }
        public void dispaly(TimeDay t)
        {
            if (t == TimeDay.morning)
            {
                Console.WriteLine("Good Morning");
            }
            else if (t == TimeDay.afternoon)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (t == TimeDay.evening)
            {

                Console.WriteLine("Good Evening");
            }
            else if (t == TimeDay.night)
            {
                Console.WriteLine("Good Nigt");
            }

        }
        public  void dispaly1(int t)
        {
            if (t == 0)
            {
                Console.WriteLine("Good Morning");
            }
            else if (t == 1)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (t == 2)
            {

                Console.WriteLine("Good Evening");
            }
            else if (t == 3)
            {
                Console.WriteLine("Good Nigt");
            }

        }
    }
    
}
