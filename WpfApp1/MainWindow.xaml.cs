using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<Student> students = new List<Student>();
        
        public MainWindow()
        {
            var studentBindingList = new BindingList<Student>(students);
            
            InitializeComponent();
        }

        private void btnResetAddForm_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            cbRegistered.IsChecked=false;
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(int.Parse(txtId.Text), txtFName.Text, txtLName.Text, cbRegistered.IsChecked.Value);
            students.Add(student);
            MessageBox.Show($"{students.Count} student(s) added");
                
        }
    }
}
