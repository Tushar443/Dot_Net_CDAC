using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollection
{
    class Program
    {
        static void Main1(string[] args)
        {
            Stack<string> s = new Stack<string>();
            //s.Push(10); //error
            s.Push("Tushar");
            s.Push("Kishor");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Queue q = new Queue();
            q.Enqueue(34);
            q.Enqueue(44);
            Console.WriteLine(q.Dequeue());


        }
        static void Main2()
        {
            SortedList<int ,Employee> sortList = new SortedList<int,Employee>();

            sortList.Add(100, new Employee { Id=1,Name="TUshar"});
            sortList.Add(200, new Employee(2, "kishor"));

            foreach (KeyValuePair<int,Employee> e in sortList)
            {
                Console.WriteLine(e.Key);
                Console.WriteLine(e.Value.id);
                Console.WriteLine(e.Value.name);
            }
        }

        static void Main()
        {
            Employees eList = new Employees();
            eList.Add(6, new Employee { Id = 2000, Name = "Thunder" });
            eList.Add(7, new Employee { Id = 3000, Name = "rohit" });
            eList.Add(8, new Employee { Id = 4000, Name = "pravin" });


            foreach (KeyValuePair<int,Employee> e in eList)
            {
                Console.WriteLine(e.Value.Name);
                Console.WriteLine(e.Value.Id);
                Console.WriteLine(e.Key);
            }
        }
    }

    class Employees : SortedList<int ,Employee>
    {

    }
    class Employee
    {
        public int id;
        public string name;

        public Employee()
        {

        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Employee(int id ,string name)
        {
            this.id=id;
            this.name = name;
        }
    }
}

