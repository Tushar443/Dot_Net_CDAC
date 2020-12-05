using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int[] arr1 = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Value is {0} ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine()); //Retrun String
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Value is {0} ", i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine()); //Retrun String
            //}

            // Array.Clear(arr, 0, 5);
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //int i = Array.IndexOf(arr, 10);
            //int j = Array.IndexOf(arr, 10);
            //Console.WriteLine("Value of 10 " + j);

            //int pos = Array.LastIndexOf(arr, 10);
            int pos = Array.BinarySearch(arr, 10);

            Console.WriteLine(pos);
            //Array.ConstrainedCopy(arr,0,arr1,1,arr.Length);// copies from 1st to 2nd, but  rolls back all copied elemnts if there was an error  

            // Array.Copy(arr, arr1, arr.Length);

            int[] newArray = (int[])Array.CreateInstance(typeof(int), 10);
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine("Value is {0}", item);
            //}

            foreach (var item in newArray)
            {
                Console.WriteLine("Value is {0}", item);
            }
        }
    }
}
