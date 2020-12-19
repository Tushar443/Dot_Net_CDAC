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
using System.Windows.Shapes;

namespace LINQ_DataSet
{
    /// <summary>
    /// Interaction logic for LINQ_To_SQL.xaml
    /// </summary>
    public partial class LINQ_To_SQL : Window
    {
        public LINQ_To_SQL()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataClasses1DataContext dtc = new DataClasses1DataContext();
           //Employee objEmp = new Employee();
            try
            {
                dtc.Employees.InsertOnSubmit(new Employee { EmpNo = 111, EmpName = "Tushar12334", Basic = 24242, DeptNo = 10 });
                dtc.SubmitChanges();
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataClasses1DataContext dtc = new DataClasses1DataContext();
            Employee emp = dtc.Employees.SingleOrDefault(emp1 => emp1.EmpNo == 111);


            try
            {
                emp.EmpName = "Hello";
                emp.Basic = 0000;
                emp.DeptNo = 20;
                dtc.SubmitChanges();
                MessageBox.Show("Updated");
            }
            catch (Exception excep)
            {

                MessageBox.Show(excep.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataClasses1DataContext dtc = new DataClasses1DataContext();
            Employee emp = dtc.Employees.SingleOrDefault(emp1 => emp1.EmpNo == 111);


            try
            {
                dtc.Employees.DeleteOnSubmit(emp);
                dtc.SubmitChanges();
                MessageBox.Show("Deleted");
            }
            catch (Exception excep)
            {

                MessageBox.Show(excep.Message);
            }
        }
    }
}
