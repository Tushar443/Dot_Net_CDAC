using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LINQ_DataSet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DataSet ds;
        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Employee";

            ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(ds, "Emp");
            cmd.CommandText = "select * from Departments";
            da.SelectCommand = cmd;
            da.Fill(ds, "Dep");
            //primary Key Validation
            DataColumn[] arrCol = new DataColumn[1];
            arrCol[0] = ds.Tables["Emp"].Columns["EmpNo"];
            ds.Tables["Emp"].PrimaryKey = arrCol;

            //Foregin Key Validation
            ds.Relations.Add(ds.Tables["Dep"].Columns["DeptNo"], ds.Tables["Emp"].Columns["DeptNo"]);

            //Column level Contraint

            ds.Tables["Emp"].Columns["EmpName"].Unique = true;

            lstGrid.ItemsSource = ds.Tables["Emp"].DefaultView;

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var records = ds.Tables["Emp"].AsEnumerable();

            var query = from emp in records
                        where emp.Field<decimal>("Basic") > 1000
                        select emp;

            DataTable dt = query.CopyToDataTable();


            lstGrid.ItemsSource = dt.DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int deptno = Convert.ToInt32(txtDeptNo.Text);
            var records = ds.Tables["Emp"].AsEnumerable();

            var query = from emp in records
                        where emp.Field<int>("DeptNo")==deptno
                        select emp;

            DataTable dt = query.CopyToDataTable();


            lstGrid.ItemsSource = dt.DefaultView;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var records = ds.Tables["Emp"].AsEnumerable();

            var query = from emp in records
                        where emp.Field<decimal>("Basic") > 1000
                        select new {number=emp.Field<int>("EmpNo"),basic=emp.Field<decimal>("Basic")};

            // var dt = query.CopyToDataTable();
            DataTable dt = new DataTable();
            dt.Columns.Add("Basic", Type.GetType("System.Decimal"));
            dt.Columns.Add("EmpNo", Type.GetType("System.Int32"));


            foreach (var item in query)
            {
                dt.Rows.Add(item.number, item.basic);
            }
            

            lstGrid.ItemsSource = dt.DefaultView;
        }


    }
    public static class ListHelper
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> list)
        {
            DataTable dt = new DataTable();
            Type listType = list.ElementAt(0).GetType();
            //get element properties nad datatable columns 
            PropertyInfo[] properties = listType.GetProperties();

            foreach (PropertyInfo property in properties)
                dt.Columns.Add(new DataColumn() { ColumnName = property.Name });
            foreach (object item in list)
            {
                DataRow dr = dt.NewRow();
                foreach (DataColumn col in dt.Columns)
                    dr[col] = listType.GetProperty(col.ColumnName).GetValue(item, null);
                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
