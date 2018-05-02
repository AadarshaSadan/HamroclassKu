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
using Finisar.SQLite;

namespace HamroClass1
{
    /// <summary>
    /// Interaction logic for AddTeacher.xaml
    /// </summary>
    public partial class AddTeacher : Window
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addTeacherButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Teacher Added", "Message", MessageBoxButton.OK);
        }

        private void departmentChooser_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> departmentData = new List<string>();
            departmentData.Add("Computer Engineering");
            departmentData.Add("Computer Science");
            departmentData.Add("Mechanical Engineering");
            departmentData.Add("Electrical Engineering");
            departmentData.Add("Geomatics Engineering");
            departmentData.Add("Phamacy");
            departmentData.Add("Applied Physics");
            departmentData.Add("Environmental Engineering");


            var comboBox = sender as ComboBox;

            comboBox.ItemsSource = departmentData;
            comboBox.SelectedIndex = -1;
        }

        private void departmentChooser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
