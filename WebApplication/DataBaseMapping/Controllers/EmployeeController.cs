using Model_Mapping_AND_DB_code.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Model_Mapping_AND_DB_code.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
           
            List<Employee> objEmp = new List<Employee>();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Employee";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                objEmp.Add(new Employee{ EmpNo=(int)dr["EmpNo"], Name = (string)dr["EmpName"], Basic = (decimal)dr["Basic"], DeptN = (int)dr["DeptNo"]});
            }
            cn.Close();
            return View(objEmp);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id=0)
        {
            Employee emp = new Employee();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Employee where EmpNo="+id;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                
                emp.EmpNo = id;
                emp.Basic = (decimal)dr["Basic"];
                emp.DeptN = (int)dr["DeptNo"];
                emp.Name = (string)dr["EmpName"];
            }
            cn.Close();

            return View(emp);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Employee values(" + emp.EmpNo + ",'"+emp.Name+"'," + emp.Basic + "," + emp.DeptN+")";
                //cmd.Parameters.Add(new SqlParameter {ParameterName="@Name",SourceColumn="EmpName", SourceVersion = DataRowVersion.Current });
                //cmd.Parameters.Add(new SqlParameter {ParameterName="@DeptN",SourceColumn="DeptNo", SourceVersion = DataRowVersion.Current });
                //cmd.Parameters.Add(new SqlParameter {ParameterName="@Basic",SourceColumn="Basic" ,SourceVersion= DataRowVersion.Current});
                //cmd.Parameters.Add(new SqlParameter {ParameterName="@EmpNo",SourceColumn="EmpNo" ,SourceVersion= DataRowVersion.Original});

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    cn.Close();
                    return RedirectToAction("Index");

                }
                cn.Close();
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                ViewBag.Excp = e.Message; 
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id = 0)
        {
            Employee emp = new Employee();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Employee where EmpNo=" + id;

            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {

                emp.EmpNo = id;
                emp.Basic = (decimal)dr["Basic"];
                emp.DeptN = (int)dr["DeptNo"];
                emp.Name = (string)dr["EmpName"];
            }
            cn.Close();

            return View(emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id,Employee emp)
        {
            try
            {
               
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Employee set EmpName='"+emp.Name+"',DeptNo="+emp.DeptN+",Basic="+emp.Basic+" where EmpNo="+emp.EmpNo;
                //cmd.Parameters.Add(new SqlParameter {ParameterName="@Name",SourceColumn="EmpName", SourceVersion = DataRowVersion.Current });
                //cmd.Parameters.Add(new SqlParameter {ParameterName="@DeptN",SourceColumn="DeptNo", SourceVersion = DataRowVersion.Current });
                //cmd.Parameters.Add(new SqlParameter {ParameterName="@Basic",SourceColumn="Basic" ,SourceVersion= DataRowVersion.Current});
                //cmd.Parameters.Add(new SqlParameter {ParameterName="@EmpNo",SourceColumn="EmpNo" ,SourceVersion= DataRowVersion.Original});

                int i =cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    cn.Close();
                    return RedirectToAction("Index");

                }
                cn.Close();
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                ViewBag.Excp = e.Message; 
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employee emp = new Employee();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Employee where EmpNo=" + id;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                emp.EmpNo = id;
                emp.Basic = (decimal)dr["Basic"];
                emp.DeptN = (int)dr["DeptNo"];
                emp.Name = (string)dr["EmpName"];
            }
            cn.Close();

            return View(emp);

        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee emp)
        {
            try
            {

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Employee where EmpNo=" + id;

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    cn.Close();
                    return View();
                }
                cn.Close();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
