using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO
{
    /// <summary>
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class InfoFrame : Page
    {
        public ObservableCollection<Discipline> Disciplines { get; set; }
        public DataTable dataDiscipline;
        public DataTable dataLectors;
        int pageSize = 3; // размер страницы
        int pageNumberDiscipline = 0; // текущая страница дисциплин
        int pageNumberLector = 0; // текущая страница лекторов
        string connectionString  = ConfigurationManager.ConnectionStrings["MyConnetionString1"].ConnectionString;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        public InfoFrame()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(connectionString);
            
                SqlCommand command = new SqlCommand(GetSqlDiscipline(),connection);
                adapter = new SqlDataAdapter(command);
                dataDiscipline = new DataTable("Disciplines");
                adapter.Fill(dataDiscipline);
                DB_Discipline.ItemsSource = dataDiscipline.DefaultView;
                DB_Discipline.CanUserAddRows = false;
                DB_Discipline.CanUserDeleteRows = false;

                SqlCommand command2 = new SqlCommand(GetSqlLectors(), connection);
                adapter2 = new SqlDataAdapter(command2);
                dataLectors = new DataTable("Lectors");
                adapter2.Fill(dataLectors);
                DB_Lector.ItemsSource = dataLectors.DefaultView;
                DB_Lector.CanUserAddRows = false;
            DB_Lector.CanUserDeleteRows = false;
            connection.Close();
        }
        private string GetSqlDiscipline()
        {
            return "SELECT * FROM Disciplines ORDER BY DisciplineId OFFSET ((" + pageNumberDiscipline + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
        }
        private string GetSqlLectors()
        {
            return "SELECT * FROM Lectors ORDER BY LectorId OFFSET ((" + pageNumberLector + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
        }


        #region Event Button CLick

        private void nextButton_ClickDisc(object sender, EventArgs e)
        {
            if (dataDiscipline.Rows.Count < pageSize) return;

            pageNumberDiscipline++;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSqlDiscipline(), connection);

                dataDiscipline.Clear();

                adapter.Fill(dataDiscipline);
            }
        }
        private void backButton_ClickDiscipline(object sender, EventArgs e)
        {
            if (pageNumberDiscipline == 0) return;
            pageNumberDiscipline--;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSqlDiscipline(), connection);

                dataDiscipline.Clear();

                adapter.Fill(dataDiscipline);
            }
        }
        private void nextButton_ClickLector(object sender, EventArgs e)
        {
            if (dataLectors.Rows.Count < pageSize) return;

            pageNumberLector++;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter2 = new SqlDataAdapter(GetSqlLectors(), connection);

                dataLectors.Clear();

                adapter2.Fill(dataLectors);
            }
        }
        private void backButton_ClickLectors(object sender, EventArgs e)
        {
            if (pageNumberLector == 0) return;
            pageNumberLector--;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter2 = new SqlDataAdapter(GetSqlLectors(), connection);

                dataLectors.Clear();

                adapter2.Fill(dataLectors);
            }
        }
        private void updateInfo_Click(object sender, EventArgs e)
        {
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            adapter.Update(dataDiscipline);//обновляет БД
            DB_Discipline.CanUserAddRows = false;
        }

        #endregion 
    }
 }
 

