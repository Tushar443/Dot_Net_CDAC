using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

namespace DataSetDemo
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
            cmd.CommandText = "select * from Dept";
            da.SelectCommand = cmd;
            da.Fill(ds, "Dep");
            //primary Key Validation
            DataColumn[] arrCol = new DataColumn[1];
            arrCol[0] = ds.Tables["Emp"].Columns["EmpId"];
            ds.Tables["Emp"].PrimaryKey = arrCol;

            //Foregin Key Validation
            ds.Relations.Add(ds.Tables["Dep"].Columns["DeptNo"], ds.Tables["Emp"].Columns["DeptNo"]);

            //Column level Contraint

            ds.Tables["Emp"].Columns["EmpName"].Unique = true;

            lstGrid.ItemsSource = ds.Tables["Emp"].DefaultView;

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            //Delete
            SqlCommand cmdDelte = new SqlCommand();
            //cmdDelte.Connection = cn;
            //cmdDelte.CommandType = CommandType.Text;
            //cmdDelte.CommandText = "Delete from Employee where EmpId=@EmpId";
            //cmdDelte.Parameters.Add(new SqlParameter { ParameterName = "@EmpId", Value = "EmpId", SourceVersion = DataRowVersion.Original });

            //Update
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = cn;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = "update Employee set EmpBasic=@EmpBasic,DeptNo=@DeptNo where EmpName=@EmpName";
            //cmdUpdate.Parameters.AddWithValue("@EmpName",txtName);

            //SqlParameter p = new SqlParameter();
            //p.ParameterName = "@EmpName";
            //p.Value = "EmpName";
            //p.SourceVersion = DataRowVersion.Current;
            //cmdUpdate.Parameters.Add(p);

            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpName", Value = "EmpName", SourceVersion = DataRowVersion.Original });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpBasic", Value = "EmpBasic", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", Value = "DeptNo", SourceVersion = DataRowVersion.Current });
          //  cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpId", Value = "EmpId", SourceVersion = DataRowVersion.Original });

            //Insert
            SqlCommand cmdInsert = new SqlCommand();
            //cmdInsert.Connection = cn;
            //cmdInsert.CommandType = CommandType.Text;
            //cmdInsert.CommandText = "insert into Employee values(@EmpId,@EmpName,@EmpBasic,@DeptNo)";

            //cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpName", Value = "EmpName", SourceVersion = DataRowVersion.Current });
            //cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpId", Value = "EmpId", SourceVersion = DataRowVersion.Current });
            //cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpBasic", Value = "EmpBasic", SourceVersion = DataRowVersion.Current });
            //cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", Value = "DeptNo", SourceVersion = DataRowVersion.Current });



            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = cmdUpdate;
            da.DeleteCommand = cmdDelte;
            da.InsertCommand = cmdInsert;
            da.Update(ds, "Emp");

        }
    }
}
