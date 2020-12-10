using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1st
{
    class Program
    {
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();

        //Basic Query 
        static void Main1(string[] args)
        {
            AddRecs();
            //var employeeList = from emp in lstEmp select emp;
            //IEnumerable<Employee> employeeList = from emp in lstEmp select emp;
            //List<Employee> employeeList = (List<Employee>)from emp in lstEmp select emp;
            //List<Employee> emps = (List<Employee>)(from emp in lstEmp select emp);
            //foreach (Employee e in emps)
            //{
            //    Console.Write(e.EmpNo + " ");
            //    Console.Write(e.Name + " ");
            //    Console.WriteLine(e.Basic);
                
            //}

            //var employeeName = from emp in lstEmp select emp.Name;
            //foreach (var name in employeeName)
            //{
            //    Console.WriteLine(name);
            //}

            //var employeeName = from emp in lstEmp select emp.Basic;
            //foreach (var basic in employeeName)
            //{
            //    Console.WriteLine(basic);
            //}


        }

        //Multiple column using Anonymous Class
        static void Main2(string[] args)
        {
            AddRecs();
            //var employeeList = from emp in lstEmp select new { emp.Name, emp.Basic,};

            //foreach (var e in employeeList)
            //{
            //    Console.Write(e.Name + " ");
            //    Console.WriteLine(e.Basic + " ");
            //}

            //var employeeList = from emp in lstEmp
            //                   where emp.Basic>= 10000 && emp.Basic<=12000
            //                   select emp;
            //var employeeList = from emp in lstEmp
            //                   where emp.Name.StartsWith("V")
            //                   select emp;

            var employeeList = from emp in lstEmp
                                   // orderby emp.Basic descending
                               orderby emp.Basic ascending
                               select emp;

            foreach (var e in employeeList)
            {
                Console.Write(e.Name + " ");
                Console.WriteLine(e.Basic + " ");
            }


        }

        //join
        static void Main3(string[] args)
        {
            AddRecs();
            var employeeList = from emp in lstEmp 
                               join dept in lstDept 
                               on emp.DeptNo equals dept.DeptNo
                               select emp;

            foreach (Employee e in employeeList)
            {
                Console.Write(e.EmpNo + " ");
                Console.Write(e.Name + " ");
                Console.WriteLine(e.Basic);

            }




        }

        public static Employee getEmployee(Employee obj)
        {
            return obj;
        }

        //lambda
        static void Main4(string[] args)
        {
            AddRecs();


            //var employeeList = lstEmp.Select(getEmployee);
            //var employeeList = lstEmp.Select(e=>e);
            var employeeList = lstEmp.Select(delegate (Employee obj){ return obj; });



            foreach (Employee e in employeeList)
            {
                Console.Write(e.EmpNo + " ");
                Console.Write(e.Name + " ");
                Console.WriteLine(e.Basic);

            }




        }


        //lambda methods
        static void Main(string[] args)
        {
            AddRecs();
            //var employeeList = lstEmp.Select(e=>e);
            //var employeeList = lstEmp.Select(emp => emp).Where(emp=>emp.Basic>10000);
            var employeeList = lstEmp.Select(e => e);


            foreach (Employee e in employeeList)
            {
                Console.Write(e.EmpNo + " ");
                Console.Write(e.Name + " ");
                Console.WriteLine(e.Basic);
            }
        }
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vikas", Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }
    }

    
    public class Department
{
    public int DeptNo { get; set; }
    public string DeptName { get; set; }
}
public class Employee
{
    public int EmpNo { get; set; }
    public string Name { get; set; }
    public decimal Basic { get; set; }
    public int DeptNo { get; set; }
    public string Gender { get; set; }
}


}
