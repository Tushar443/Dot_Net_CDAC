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

namespace DataReader2
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

        private void btnDatareader_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Employee;select * from Dept";

            SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            lstEmps.Items.Add("EMPOYEES");

            while (dr.Read())
            {
                // dr["EmpName"] = "twdd"; read only error
                lstEmps.Items.Add(dr["EmpName"]+" "+ dr["Basic"] + " "+ dr["DeptNo"]); //this is better more readable
                // lstEmps.Items.Add(dr[1]);
                dr.GetString(1);
                dr.GetInt32(0);
            }
            dr.Close();
            cn.Close();
        }

        private void btnNextResult_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Employee;select * from Dept";

            SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            lstEmps.Items.Add("EMPOYEES");

            while (dr.Read())
            {
                // dr["EmpName"] = "twdd"; read only error
                lstEmps.Items.Add(dr["EmpName"]);
               // lstEmps.Items.Add(dr[1]);
            }
            lstEmps.Items.Add("DEPARTMENTS");


            dr.NextResult();
            while(dr.Read())
            {
                lstEmps.Items.Add(dr[1]);
            }
            dr.Close();
            cn.Close();
        }

        private void btnEmpDept_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmdDept = new SqlCommand();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True;MultipleActiveResultSets=true";
            
            cn.Open();
            cmdDept.Connection = cn;
            cmdDept.CommandType = System.Data.CommandType.Text;
            cmdDept.CommandText = "select * from Dept";
            SqlDataReader drDept = cmdDept.ExecuteReader();

            SqlCommand cmdEmps = new SqlCommand();
            cmdEmps.Connection = cn;
            cmdEmps.CommandType = System.Data.CommandType.Text;

            while (drDept.Read())
            {
                lstEmps.Items.Add(drDept[1]);
                cmdEmps.CommandText = "select * from Employee where DeptNo = " + drDept[0];
                SqlDataReader drEmps = cmdEmps.ExecuteReader();
                while (drEmps.Read())
                {
                    lstEmps.Items.Add(drEmps[0] + " " + drEmps[1] + " " + drEmps[2] + " " + drEmps[3]);
                }
                drEmps.Close();
            }
            drDept.Close();
            cn.Close();
        }

        private void btnFunc_Click(object sender, RoutedEventArgs e)
        {
            SqlDataReader funcReader = getDataReader();
            while (funcReader.Read())
            {
                lstEmps.Items.Add(funcReader[1]);
            }
            funcReader.Close();  //connection is close here at this line
            MessageBox.Show(cn.State.ToString());
        }
        SqlConnection cn = new SqlConnection();
        private SqlDataReader getDataReader()
        {
           
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Thunder;Integrated Security=True;MultipleActiveResultSets=true";

            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Employee";
                SqlDataReader dr= cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            //SqlDataReader dr= cmd.ExecuteReader();
           // cn.Close(); //Exception at linr 119
             return dr;
        }
    }
}
