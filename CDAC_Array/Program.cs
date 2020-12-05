using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDAC_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Batches : ");
            int batch = Convert.ToInt32(Console.ReadLine());

           
            Student[][] arr = new Student[batch][];

            for(int i = 0; i < batch; i++)
            {
                Console.Write("Enter the number of student for {0}th batch : ",i+1);
                int student = Convert.ToInt32(Console.ReadLine());
               
                for (int j = 0; j < student; j++)
                {
                    Console.Write("Enter Marks for batch = {0} and student = {1} ",i+1,j+1);
                    int marks = Convert.ToInt32(Console.ReadLine());
                    arr[i][j] = new Student();
                    arr[i][j].MARKS = marks;
                   
                    
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <arr[i].Length ; j++)
                {

                    Console.WriteLine(arr[i][j].MARKS);

                }
            }
        }
    }

    class Student
    {
       // public int stu_id;
        //public string name;
        public int marks;

        //public int STU_ID
        //{
        //    set
        //    {
        //        stu_id = value;
        //    }
        //    get
        //    {
        //        return stu_id;
        //    }
        //}

        //public string NAME
        //{
        //    set
        //    {
        //        name = value;
        //    }
        //    get
        //    {
        //        return name;
        //    }
        //}

        public int MARKS
        {
            set
            {
                marks = value;
            }
            get
            {
                return marks;
            }
        }

    }
}
