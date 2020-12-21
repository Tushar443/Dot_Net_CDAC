using DotNetExam.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetExam.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam;Integrated Security=True;Pooling=False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ShowData";
            SqlDataReader dr = cmd.ExecuteReader();
            



            List<Product> objList = new List<Product>();

            foreach (var item in dr)
            {
                Product prod = new Product();
                prod.ProductId = (int)dr["ProductId"];
                prod.ProductName = (string)dr["ProductName"];
                prod.Rate = (decimal)dr["Rate"];
                prod.Description = (string)dr["Description"];
                prod.CatergoryId = (int)dr["CategoryId"];
                objList.Add(prod);
            }

            cn.Close();

            return View(objList);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int ProductId)
        {
            Product prod = new Product();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam;Integrated Security=True;Pooling=False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Show";
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                prod.ProductId = (int)dr["ProductId"];
                prod.ProductName = (string)dr["ProductName"];
                prod.Rate = (decimal)dr["Rate"];
                prod.Description = (string)dr["Description"];
            }
            dr.Close();

            List<SelectListItem> objCategory = new List<SelectListItem>();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Categories";
            
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                objCategory.Add(new SelectListItem { Text = (string)dr["CategoryName"], Value = (string)dr["CategoryId"].ToString() });
            }
            prod.Categories = objCategory;
            cn.Close();
            return View(prod);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int ProductId, Product prod)
        {
            try
            {
                
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam;Integrated Security=True;Pooling=False";
                cn.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "InsertProduct";
                cmd.Parameters.AddWithValue("@ProductId", prod.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", prod.ProductName);
                cmd.Parameters.AddWithValue("@Rate", prod.Rate);
                cmd.Parameters.AddWithValue("@Description", prod.Description);
                cmd.Parameters.AddWithValue("@CategoryId", prod.CatergoryId);
                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
