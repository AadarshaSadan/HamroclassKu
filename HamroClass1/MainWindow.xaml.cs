using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Finisar.SQLite;
namespace HamroClass1
{
    public partial class MainWindow : Window
    {
        // We use these three SQLite objects:
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;

        int codeNo;
        AddTeacher addTeacherWindow;
        AddCourse addCourseWindow;
        int tempPosition,tempLunch;
        Options optionsWindow;
        Point startPoint;
        int totalNoOfCourses = 40;
       string[,] names = new string[7,8];
        int[,] position = new int[6, 7];
        ListView dragSource = null;
        List<string> courseList = new List<string>();
        Label parentDragged;
        Label labeldy;
        int Lramdom = 0;
        int Urandom,tempRandom;
        String yearSemester;
        int getFirstyear;
        int getSecondyear =0;
        int getThirdyear;
        int getFourthyear = 0;
        public MainWindow()
        { 
           Random ran = new Random();
            InitializeComponent();

            sqlite_conn = new SQLiteConnection("Data Source=database.db ;Version=3;Compress=True;");
          
           sqlite_conn.Open();
           sqlite_cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            //      sqlite_cmd.CommandText = "CREATE TABLE addCourse (id integer primary key, courseCode varchar(100),courseName varchar(100),credit integer);";

            // Now lets execute the SQL ;D
            //        sqlite_cmd.ExecuteNonQuery();

            // Lets insert something into our new table:
            //       sqlite_cmd.CommandText = "INSERT INTO addCourse (courseCode,courseName,credit) VALUES ('DEF 101','DEFAULT','3');";
            // And execute this again ;D
            //        sqlite_cmd.ExecuteNonQuery();
      
            sqlite_cmd = sqlite_conn.CreateCommand();
            
            sqlite_cmd.CommandText = "SELECT * FROM courses_info";
            
            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                String yearSemesterss = "" + sqlite_datareader["yearSemester"];
                int yearSemesters = Convert.ToInt32(yearSemesterss);
                if (yearSemesters == 1)
                {
                    tempRandom++;

                    String tempCourse = "" + sqlite_datareader["courseCode"];
                    String tempCredit = "" + sqlite_datareader["credit"];
                    int temp = Convert.ToInt32(tempCredit);
                    for (int i = 1; i <= temp + 1; i++)   //n credit = n+1 hours per week through calcs
                    {
                        courseList.Add("" + sqlite_datareader["courseCode"]);

                    }

                }



            }
       if (getFirstyear == 1)
            {
                // The SQLiteDataReader allows us to run through the result lines:
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    String yearSemesterss = "" + sqlite_datareader["yearSemester"];
                    int yearSemesters = Convert.ToInt32(yearSemesterss);
                    if (yearSemesters == 1)
                    {
                        tempRandom++;

                        String tempCourse = "" + sqlite_datareader["courseCode"];
                        String tempCredit = "" + sqlite_datareader["credit"];
                        int temp = Convert.ToInt32(tempCredit);
                        for (int i = 1; i <= temp + 1; i++)   //n credit = n+1 hours per week through calcs
                        {
                            courseList.Add("" + sqlite_datareader["courseCode"]);

                        }

                    }



                }
            }
            else if(getSecondyear ==2)
            {
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    String yearSemesterss = "" + sqlite_datareader["yearSemester"];
                    int yearSemesters = Convert.ToInt32(yearSemesterss);
                    if (yearSemesters == 3)
                    {
                        tempRandom++;

                        String tempCourse = "" + sqlite_datareader["courseCode"];
                        String tempCredit = "" + sqlite_datareader["credit"];
                        int temp = Convert.ToInt32(tempCredit);
                        for (int i = 1; i <= temp + 1; i++)   //n credit = n+1 hours per week through calcs
                        {
                            courseList.Add("" + sqlite_datareader["courseCode"]);

                        }

                    }



                }

            }
            else if(getThirdyear == 3)
            {

                // The SQLiteDataReader allows us to run through the result lines:
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    String yearSemesterss = "" + sqlite_datareader["yearSemester"];
                    int yearSemesters = Convert.ToInt32(yearSemesterss);
                    if (yearSemesters == 3)
                    {
                        tempRandom++;

                        String tempCourse = "" + sqlite_datareader["courseCode"];
                        String tempCredit = "" + sqlite_datareader["credit"];
                        int temp = Convert.ToInt32(tempCredit);
                        for (int i = 1; i <= temp + 1; i++)   //n credit = n+1 hours per week through calcs
                        {
                            courseList.Add("" + sqlite_datareader["courseCode"]);

                        }

                    }



                }

            }
            else if (getFourthyear == 4)
            {


            }
            else
            {
                // The SQLiteDataReader allows us to run through the result lines:
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    String yearSemesterss = "" + sqlite_datareader["yearSemester"];
                    int yearSemesters = Convert.ToInt32(yearSemesterss);
                    if (yearSemesters == 1)
                    {
                        tempRandom++;

                        String tempCourse = "" + sqlite_datareader["courseCode"];
                        String tempCredit = "" + sqlite_datareader["credit"];
                        int temp = Convert.ToInt32(tempCredit);
                        for (int i = 1; i <= temp + 1; i++)   //n credit = n+1 hours per week through calcs
                        {
                            courseList.Add("" + sqlite_datareader["courseCode"]);

                        }

                    }



                }
            }
                Urandom = tempRandom;
            int count = courseList.Count();
             while (count < 36)
            {
                Urandom++;
                count++;
                courseList.Add("" + "....");
            }
            
         DragList.ItemsSource = courseList;
            /*      for (int i = 0; i < 40; i++)
                 {
               
                    codeNo = ran.Next(100, 800);
                     int a = ran.Next(65, 70);
                     int b = ran.Next(65, 80);
                     int c = ran.Next(75, 80);
                     int d = ran.Next(65, 70);
             
             
                     char code = (char)codeNo;
                     String a = (String)code;
                     courseList.Add("" + (char)a + (char)b+(char)c +(char)d+ " "+codeNo);
         
              
                     -courseList.Add(""+sqlite_datareader["text"]);
       
                 }
                 DragList.ItemsSource = courseList;
               */
        }

        private void Ribbon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DragList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListView parent = (ListView)sender;
            dragSource = parent;
            object data = GetDataFromListView(dragSource, e.GetPosition(parent));
            try
            {
                if (data != null)
                {
                    DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
                }

                //  dragSource.Items.Remove(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error draging");
            }

        }


        #region GetDataFromListView(ListView,Point)
        private static object GetDataFromListView(ListView source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);
                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }
                    if (element == source)
                    {
                        return null;
                    }
                }
                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }
            return null;
        }

        #endregion

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Label_Drop_1(object sender, DragEventArgs e)
        {
           
                Label dragable = (Label)sender;
                object data = e.Data.GetData(typeof(string));
                ((IList)dragSource.ItemsSource).Remove(data);
             // MessageBox.Show("Error Dropping");
                dragable.Content = data;
              
        }

        private void openAddTeacherDialog(object sender, RoutedEventArgs e)
        {
            addTeacherWindow = new AddTeacher();
            addTeacherWindow.Show();
        }
        private void openAddCourseDialog(object sender, RoutedEventArgs e)
        {
            addCourseWindow = new AddCourse();
            addCourseWindow.Show();
        }

        private void exitMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void optionsMenu_Click(object sender, RoutedEventArgs e)
        {

            optionsWindow = new Options();
            optionsWindow.Show();

        }

        private void autoGenerate_Click(object sender, RoutedEventArgs e)
        {
            var ll11 = (Label)l11;
            var ll12 = (Label)l12;
            var ll13 = (Label)l13;
            var ll14 = (Label)l14;
            var ll15 = (Label)l15;
            var ll16 = (Label)l16;
            var ll17 = (Label)l17;

            var ll21 = (Label)l21;
            var ll22 = (Label)l22;
            var ll23 = (Label)l23;
            var ll24 = (Label)l24;
            var ll25 = (Label)l25;
            var ll26 = (Label)l26;
            var ll27 = (Label)l27;

            var ll31 = (Label)l31;
            var ll32 = (Label)l32;
            var ll33 = (Label)l33;
            var ll34 = (Label)l34;
            var ll35 = (Label)l35;
            var ll36 = (Label)l36;
            var ll37 = (Label)l37;

            var ll41 = (Label)l41;
            var ll42 = (Label)l42;
            var ll43 = (Label)l43;
            var ll44 = (Label)l44;
            var ll45 = (Label)l45;
            var ll46 = (Label)l46;
            var ll47 = (Label)l47;

            var ll51 = (Label)l51;
            var ll52 = (Label)l52;
            var ll53 = (Label)l53;
            var ll54 = (Label)l54;
            var ll55 = (Label)l55;
            var ll56 = (Label)l56;
            var ll57 = (Label)l57;

            var ll61 = (Label)l61;
            var ll62 = (Label)l62;
            var ll63 = (Label)l63;
            var ll64 = (Label)l64;
            var ll65 = (Label)l65;
            var ll66 = (Label)l66;
            var ll67 = (Label)l67;


           Random auto = new Random();
             // int resource = dragSource.getCount; garnu parne ho
          
            for (int i =0;i<=6;i++)
            {
                for (int j=0;j<=7;j++)
                {
                     tempPosition = auto.Next(Lramdom,36);
                     //tempVar.Content = tempPosition;
                  //  if (!isAlreadyFilled(tempPosition)) {                    {
                        //position[i, j] = tempPosition;
                  /*  }  else
                    {
                        j--;
                        continue;
                    }*/

                    names[i, j] = courseList[tempPosition];
                }
            }
            tempLunch = auto.Next(Lramdom,1);
            names[1, 3] = "Lunch";

            names[2, 3] = "Lunch";
            names[3, 4] = "Lunch";
            names[4, 4] = "Lunch";
            names[5, 4] = "Lunch";
            names[6, 4] = "Lunch";

         
        /*    string[,] names = new string[,]{
            
           { "course","clourse","course","course","course","course","course","course"},
            { "course","clourse","course","course","course","course","course","course"},
             { "course","clourse","course","course","course","course","course","course"},
              { "course","clourse","course","course","course","course","course","course"},
               { "course","clourse","course","course","course","course","course","course"},
                { "course","clourse","course","course","course","course","course","course"},
                 { "course","clourse","course","course","course","course","course","course"}
            };
       */ 
            ll11.Content = names[1,1];
            ll12.Content = names[1, 2];
            ll13.Content = names[1, 3];
            ll14.Content = names[1, 4];
            ll15.Content = names[1, 5];
            ll16.Content = names[1, 6];
            ll17.Content = names[1, 7];

            ll21.Content = names[2, 1];
            ll22.Content = names[2, 2];
            ll23.Content = names[2, 3];
            ll24.Content = names[2, 4];
            ll25.Content = names[2, 5];
            ll26.Content = names[2, 6];
            ll27.Content = names[2, 7];

            ll31.Content = names[3, 1];
            ll32.Content = names[3, 2];
            ll33.Content = names[3, 3];
            ll34.Content = names[3, 4];
            ll35.Content = names[3, 5];
            ll36.Content = names[3, 6];
            ll37.Content = names[3, 7];

            ll41.Content = names[4, 1];
            ll42.Content = names[4, 2];
            ll43.Content = names[4, 3];
            ll44.Content = names[4, 4];
            ll45.Content = names[4, 5];
            ll46.Content = names[4, 6];
            ll47.Content = names[4, 7];

            ll51.Content = names[5, 1];
            ll52.Content = names[5, 2];
            ll53.Content = names[5, 3];
            ll54.Content = names[5, 4];
            ll55.Content = names[5, 5];
            ll56.Content = names[5, 6];
            ll57.Content = names[5, 7];

            ll61.Content = names[6, 1];
            ll62.Content = names[6, 2];
            ll63.Content = names[6, 3];
            ll64.Content = names[6, 4];
            ll65.Content = names[6, 5];
            ll66.Content = names[6, 6];
            ll67.Content = names[6, 7];
        }
        bool isAlreadyFilled(int temp)
        {
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {

           //     this.Close();
              
            }
        }

        private void firstYear_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void secondYear_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.getSecondyear = 2;
             // Let the SQLiteCommand object know our SQL-Query:
            //      sqlite_cmd.CommandText = "CREATE TABLE addCourse (id integer primary key, courseCode varchar(100),courseName varchar(100),credit integer);";

            // Now lets execute the SQL ;D
            //        sqlite_cmd.ExecuteNonQuery();

            // Lets insert something into our new table:
            //       sqlite_cmd.CommandText = "INSERT INTO addCourse (courseCode,courseName,credit) VALUES ('DEF 101','DEFAULT','3');";
            // And execute this again ;D
            //        sqlite_cmd.ExecuteNonQuery();

             sqlite_datareader = sqlite_cmd.ExecuteReader();
         
                // The SQLiteDataReader allows us to run through the result lines:
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    String yearSemesterss = "" + sqlite_datareader["yearSemester"];
                    int yearSemesters = Convert.ToInt32(yearSemesterss);
                 //   if (yearSemesters == 3)
                  //  {
                        tempRandom++;

                        String tempCourse = "" + sqlite_datareader["courseCode"];
                        String tempCredit = "" + sqlite_datareader["credit"];
                        int temp = Convert.ToInt32(tempCredit);
                        for (int i = 1; i <= temp + 1; i++)   //n credit = n+1 hours per week through calcs
                        {
                            courseList.Add("" + sqlite_datareader["courseCode"]);

                        }
 


               // }
            }

                Urandom = tempRandom;
                int count = courseList.Count();
                while (count < 36)
                {
                    Urandom++;
                    count++;
                    courseList.Add("" + "....");
                }

                DragList.ItemsSource = courseList;
                main.Show();
                this.Close();
        }
        private void thirdYear_Checked(object sender, RoutedEventArgs e)
        {
          
            MainWindow main = new MainWindow();
            main.getThirdyear = 3;
           main.UpdateLayout();
            main.Show();
            this.Close();
          }
        private void fourthYear_Checked(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            this.Close();
            getFourthyear = 4;
            main.Show();
         }

        private void DragList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       

      

        
    }
   
}
