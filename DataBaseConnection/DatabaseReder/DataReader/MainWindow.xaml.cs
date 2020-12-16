using System;
using System.Collections.Generic;
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

namespace DataReader
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

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select EmpName from Employee";

            MessageBox.Show(cmd.ExecuteScalar().ToString());
            cn.Close();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
           SqlTransaction t= cn.BeginTransaction();
            cmd.Connection = cn;
            cmd.Transaction = t;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Employee values(300,'sidhesh',3000,1)";


            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = cn;
            cmd2.Transaction = t;
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "insert into Employee values(400,'Sushant',5000,2)";

            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery(); 
                t.Commit();
                cn.Close();
                MessageBox.Show("Commit");
            }
            catch(Exception ex)
            {
               
                t.Rollback();
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEploye_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Employee values(@EmpNo,@EmpName,@Basic,@DeptNo)";
            cmd.Parameters.AddWithValue("@EmpNo", txtEmpId.Text);
            cmd.Parameters.AddWithValue("@EmpName", txtEmpName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);

            cmd.ExecuteNonQuery();
            //MessageBox.Show(cmd.ExecuteScalar().ToString());
            cn.Close();
            MessageBox.Show("Inserted");
        }
    }
}
