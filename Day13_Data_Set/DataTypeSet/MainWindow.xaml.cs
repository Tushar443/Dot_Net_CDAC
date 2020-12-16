using DataTypeSet.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
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

namespace DataTypeSet
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
        DataSet1 ds;
        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            ds = new DataSet1();
            DeptTableAdapter dsDept = new DeptTableAdapter();
            dsDept.Fill(ds.Dept);

            EmployeeTableAdapter dsEmps = new EmployeeTableAdapter();
            dsEmps.Fill(ds.Employee);

            lstGrid.ItemsSource = ds.Employee.DefaultView;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            EmployeeTableAdapter dsEmps = new EmployeeTableAdapter();
            dsEmps.Update(ds.Employee);
        }
    }
}
