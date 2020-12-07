using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssinment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] arr = new Student[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].RollNo = Convert.ToInt32(Console.ReadLine());
                arr[i].Name = Convert.ToString(Console.ReadLine());
                arr[i].Marks = Convert.ToDecimal(Console.ReadLine());
            }

            foreach (Student i in arr)
            {
                Console.WriteLine(i.RollNo);
                Console.WriteLine(i.Name);
                Console.WriteLine(i.Marks);
            }

           
        }
    }
    public struct Student
    {
        private int rollNo;
        private string name;
        private decimal marks;

        public int RollNo
        {
            set
            {rollNo = value;}
            get { return rollNo; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        public Student(int rollNo,string name,decimal marks)
        {
            this.marks = marks;
            this.name = name;
            this.rollNo = rollNo;
        }
    }
}
