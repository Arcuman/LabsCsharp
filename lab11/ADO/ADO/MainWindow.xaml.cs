using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnetionString1"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("OK");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed/Denied of Access/Database does not exist");
                SqlConnection myConn = new SqlConnection("Data Source=.\\SQLEXPRESS;Integrated security=True;database=master");
                String str = "CREATE DATABASE Discipline1 ON PRIMARY " +
                     "(NAME = Discipline1, " +
                      "FILENAME = 'D:\\BSTU 2 course\\2sem\\OOP\\labs\\lab11\\ADO\\ADO\\Discipline1.mdf', " +
                      "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                      "LOG ON (NAME = Discipline1_Log, " +
                      "FILENAME = 'D:\\BSTU 2 course\\2sem\\OOP\\labs\\lab11\\ADO\\ADO\\Discipline1.ldf', " +
                      "SIZE = 1MB, " +
                      "MAXSIZE = 5MB, " +
                      "FILEGROWTH = 10%)";
                SqlCommand myCommand = new SqlCommand(str, myConn);
                try
                {
                    myCommand.Connection.Open();
                    myCommand.ExecuteNonQuery();
                    myConn.Close();
                    Thread.Sleep(5000);
                    SqlConnection myConn1 = new SqlConnection(connectionString);
                    SqlCommand CreateTableCommand = new SqlCommand();
                    CreateTableCommand.Connection = myConn1;
                    CreateTableCommand.CommandType = CommandType.Text;
                    CreateTableCommand.CommandText = "CREATE table Disciplines (" +
                                                        "DisciplineId int IDENTITY(1,1) NOT NULL, " +
                                                        "Name nvarchar(50) ,                      " +
                                                        "Term int,                                " +
                                                        "Course int ,                             " +
                                                        "Specialization nvarchar(50),             " +
                                                        "LecturesCount int ,                      " +
                                                        "LabsCount int," +
                                                        "ControlType nvarchar(50),                " +
                                                        "PRIMARY KEY (DisciplineId)) ";
                    CreateTableCommand.CommandText += "\nCREATE table Lectors (" +
                                                        "LectorId int IDENTITY(1,1) NOT NULL, " +
                                                        "SNP nvarchar(50) ,                   " +
                                                        "Auditory int,                        " +
                                                        "Pulpit nvarchar(50),                 " +
                                                        "ImageData varbinary(MAX),             " +
                                                        "PRIMARY KEY (LectorId))";
                    CreateTableCommand.Connection.Open();
                    CreateTableCommand.ExecuteNonQuery();
                    CreateTableCommand.Connection.Close();
                    CreateTableCommand.CommandText = "CREATE PROCEDURE insert_Disciplines " +
                                                        "@name nvarchar(50),            " +
                                                        "@term int,                     " +
                                                        "@course int,                   " +
                                                        "@specialization nvarchar(50),  " +
                                                        "@lecturesCount int ,           " +
                                                        "@labsCount int,                " +
                                                        "@controlType  nvarchar(50)     " +
                                                    "AS INSERT INTO Disciplines(Name, Term, Course, Specialization, LecturesCount, LabsCount, ControlType)" +
                                                        "VALUES(@name, @term, @course, @specialization, @lecturesCount, @labsCount, @controlType)" +
                                                        "SELECT SCOPE_IDENTITY()";
                    CreateTableCommand.Connection.Open();
                    CreateTableCommand.ExecuteNonQuery();
                    CreateTableCommand.Connection.Close();
                    CreateTableCommand.CommandText = "CREATE PROCEDURE insert_Lectors(" +
                                                            "    @snp nvarchar(50),                                     " +
                                                            "	 @auditory int,                                          " +
                                                            "    @pulpit nvarchar(50),                                  " +
                                                            "	 @data varbinary(MAX)                                    " +
                                                            "	)                                                       " +
                                                            "AS                                                         " +
                                                            "    INSERT INTO Lectors(SNP, Auditory, Pulpit, ImageData)  " +
                                                            "    VALUES(@snp, @auditory, @pulpit, @data)                " +
                                                            "                                                           " +
                                                            "                                                           " +
                                                            "    SELECT SCOPE_IDENTITY()                                 ";

                    CreateTableCommand.Connection.Open();
                    CreateTableCommand.ExecuteNonQuery();
                    CreateTableCommand.Connection.Close();
                    MessageBox.Show("DataBase is Created Successfully");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (myConn.State == ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                }
            }
            MyFrame.Navigate(new InfoFrame());

        }
        public void Add_to_database(object sender, EventArgs eventArgs)
        {
            MyFrame.Navigate(new AddFrame());
        }
        public void Delete_from_database(object sender, EventArgs eventArgs)
        {
            MyFrame.Navigate(new DeleteFrame());
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new InfoFrame());
        }
    }
}
