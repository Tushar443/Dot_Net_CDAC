using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    class Program
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Tushar");
            ht.Add(2, "kishor");
            ht.Add(3, "rohit");
            ht.Add(4, "pravin");
            ht.Add(5, "subham");

            //Hashtable ht2 = new Hashtable();
            //Console.WriteLine(ht.Equals(ht2));

            //Console.WriteLine(ht.Contains(1));
            //Console.WriteLine(ht.ContainsKey(6));
            //Console.WriteLine(ht.ContainsValue("Subham"));


            //Console.WriteLine(ht.Count);


            //foreach (DictionaryEntry de in ht)
            //{
            //    Console.Write(de.Key);
            //    Console.WriteLine(" " +de.Value);
            //}

            //IDictionaryEnumerator htEmu= ht.GetEnumerator();
            //while (htEmu.MoveNext())
            //{
            //    Console.Write(htEmu.Value+" ");
            //    Console.WriteLine(htEmu.Key);
            //}


            // Console.WriteLine(ht.IsReadOnly) ;

            //Console.WriteLine(ht.IsFixedSize);
            //Console.WriteLine(ht.IsSynchronized);
            //ICollection KeyCollection = ht.Keys;

            //IDictionaryEnumerator key=(IDictionaryEnumerator) KeyCollection.GetEnumerator();
            //while (key.MoveNext())
            //{
            //    Console.WriteLine(key.Key);
            //}


            //ht.Remove(1);

            //Console.WriteLine(ht.Values);

            //foreach (DictionaryEntry de in ht)
            //{
            //    Console.Write(de.Key);
            //    Console.WriteLine(" " + de.Value);
            //}


            HashSet<Employee> hashEmp = new HashSet<Employee>();

            Employees listEmp = new Employees();

            listEmp.Add(new Employee { ID = 3, Name = "kishor" });
            listEmp.Add(new Employee { ID = 1, Name = "Tushar" });
            listEmp.Add(new Employee { ID = 2, Name = "Rohit" });
            hashEmp.Add(new Employee { ID = 1, Name = "Tushar"});
            hashEmp.Add(new Employee { ID = 2, Name = "Rohit" });
            foreach (Employee e in listEmp)
            {
                Console.Write(e.ID+ " ");
                Console.WriteLine(e.Name);
            }
        }
    }

    class Employees : List<Employee>
    {

    }

    class Employee
    {
        private int id;
        private string name;

        public int ID
        {
            set { id = value; }
            get
            {return id;}
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

    }
}
