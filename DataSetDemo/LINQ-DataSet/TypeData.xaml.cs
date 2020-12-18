using LINQ_DataSet.MyTypeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace LINQ_DataSet
{
    /// <summary>
    /// Interaction logic for TypeData.xaml
    /// </summary>
    public partial class TypeData : Window
    {
        public TypeData()
        {
            InitializeComponent();
        }
        MyTypeDataSet ds=new MyTypeDataSet();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DepartmentsTableAdapter deptAdt = new DepartmentsTableAdapter();
            deptAdt.Fill(ds.Departments);

            EmployeeTableAdapter empAdt = new EmployeeTableAdapter();
            empAdt.Fill(ds.Employee);
            MessageBox.Show("Done");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var records = ds.Employee.AsEnumerable();

            var query = from emp in records
                        where emp.Basic > 1000
                        select emp;

            DataTable dt = query.CopyToDataTable();

            lstGrid1.ItemsSource = dt.DefaultView;

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
