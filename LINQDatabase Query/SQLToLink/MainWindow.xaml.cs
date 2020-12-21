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

namespace SQLToLink
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
        DataClasses1DataContext dbObj = new DataClasses1DataContext();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Employee emp= new Employee();
            emp.Basic = 23456;
            emp.EmpNo = 23;
            emp.EmpName = "Kishor";
            emp.DeptNo = 10;

            dbObj.Employees.InsertOnSubmit(emp);
            dbObj.SubmitChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Employee emp = dbObj.Employees.SingleOrDefault(emp1=>emp1.EmpName.Equals("Kishor"));
            dbObj.SubmitChanges();
            MessageBox.Show("Emp name " + emp.EmpNo);
        }




    }

}
