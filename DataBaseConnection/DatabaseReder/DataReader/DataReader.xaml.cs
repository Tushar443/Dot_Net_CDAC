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
using System.Windows.Shapes;

namespace DataReader
{
    /// <summary>
    /// Interaction logic for DataReader.xaml
    /// </summary>
    public partial class DataReader : Window
    {
        public DataReader()
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
            cmd.CommandText = "select * from Employee";

            SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            while (dr.Read())
            {
                lstEmps.Items.Add(dr["EmpName"]);
            }
            dr.Close();
            cn.Close();
        }
    }
}
