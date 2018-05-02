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
    /// Interaction logic for AddCourse.xaml
    /// </summary>
    public partial class AddCourse : Window
    {


        // We use these three SQLite objects:
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;

        public AddCourse()
        {
            InitializeComponent();

            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
`            sqlite_cmd = sqlite_conn.CreateCommand();

      

        }


        private void yearSemesterChooser_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> yearSemesterData = new List<string>();
            yearSemesterData.Add("First Year First Semester [I/I]");
            yearSemesterData.Add("First Year Second Semester [I/II]");
            yearSemesterData.Add("Second Year First Semester [II/I]");
            yearSemesterData.Add("Second Year Second Semester [I/II]");
            yearSemesterData.Add("Third Year First Semester [III/I]");
            yearSemesterData.Add("Third Year Second Semester [III/II]");
            yearSemesterData.Add("Fourth Year First Semester [IV/I]");
            yearSemesterData.Add("Fourth Year Second Semester [IV/II]");


            var comboBox = sender as ComboBox;

            comboBox.ItemsSource = yearSemesterData;
            comboBox.SelectedIndex = -1;
        }

        private void yearSemesterChooser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string value = comboBox.SelectedItem as string;
            //this.Title = "Selected: " + value;
        }

        private void teacherChooser_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void teacherChooser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void facultyChooser_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void facultyChooser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addCourseButton_Click(object sender, RoutedEventArgs e)
        {
            
            string courseCodevalue = courseCodetextBox.Text;
            string courseNamevalue = courseName.Text;
            string yearSemseter = yearSemesterChooser.Text;
            string courseCreditvalue = courseCredit.Text;
            
            try
            {
                if (courseCodevalue != "" && courseNamevalue != "" && courseCreditvalue != "")
                {
                    // Lets insert something into our new table:
                    sqlite_cmd.CommandText = "INSERT INTO courses_info (courseCode,courseName,credit,yearSemester) VALUES ('" + courseCodevalue + "','" + courseNamevalue + "','" + courseCreditvalue + "',1);";
                    // And execute this again ;D
                    sqlite_cmd.ExecuteNonQuery();
                    MessageBox.Show("Data entered succesfully");

                }
                else
                    MessageBox.Show("Kehi ta data rakha, database ma check garna");
                }
            catch (Exception ex)
            {
                // Lets insert something into our new table:
                sqlite_cmd.CommandText = "INSERT INTO addCourse (courseCode,courseName,credit) VALUES ('"+courseCodevalue + "','" + courseNamevalue + "','"+ yearSemseter +"','1');";
                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
                MessageBox.Show("Data entered succesfully");
            }
          //  sqlite_conn.Close();
        }
    }
}
