using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] TwoArray = new int[5, 3];
            //1-123
            //    2-123
            //    3-123
            //    4-123
            //    5-123

            //    12345
            //    123
            //Console.WriteLine(TwoArray.Length);

            //Console.WriteLine(TwoArray.GetLength(0));
            //Console.WriteLine(TwoArray.GetLength(1));

            //Console.WriteLine(TwoArray.GetUpperBound(0));
            //Console.WriteLine(TwoArray.GetLowerBound(0));

            //Console.WriteLine(TwoArray.GetUpperBound(1));
            //Console.WriteLine(TwoArray.GetLowerBound(1));


            int[][] arr = new int[5][];

            arr[0] = new int[3]; 
            arr[1] = new int[4];
            arr[2] = new int[2];
            arr[3] = new int[3];
            arr[4] = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter value for subscript [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("value for subscript {0},{1} is {2}  ", i, j, arr[i][j]);

                }

            }
            Console.ReadLine();
        
    }
    }
}
