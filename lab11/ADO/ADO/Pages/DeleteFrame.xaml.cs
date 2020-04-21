using System;
using System.Collections.Generic;
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
    /// Interaction logic for DeleteFrame.xaml
    /// </summary>
    public partial class DeleteFrame : Page
    {
        public DeleteFrame()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (Discipline.IsChecked == true)
            {
                DisciplineNamePanel.Visibility = Visibility.Visible;
                SNP.Visibility = Visibility.Collapsed;
            }
            if (Lector.IsChecked == true)
            {
                DisciplineNamePanel.Visibility = Visibility.Collapsed;
                SNP.Visibility = Visibility.Visible;
            }
        }

        private void Delete_from_database(object sender, RoutedEventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["MyConnetionString1"].ConnectionString;
            string sqlExpression = "DELETE FROM ";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlTransaction transact = connection.BeginTransaction();
            if (Discipline.IsChecked == true)
            {
                sqlExpression += "Disciplines Where Name = @value";
                SqlParameter valueParam = new SqlParameter("@value", DisciplineName.Text);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlExpression;
            
                command.Parameters.Add(valueParam);
                command.Transaction = transact;
                command.ExecuteNonQuery();
            }    
            else if (Lector.IsChecked == true)
            {
                sqlExpression += "Lectors Where SNP = @value";
                SqlParameter valueParam = new SqlParameter("@value", SNPName.Text);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlExpression;
                command.Parameters.Add(valueParam);
                command.Transaction = transact;
                command.ExecuteNonQuery();
            }
            
            MessageBoxResult response = MessageBox.Show("Вы уверены?" , "Удаление", MessageBoxButton.YesNo);
            switch (response)
            {
                case MessageBoxResult.Yes:  // подтверждаем транзакцию 
                    transact.Commit(); break;
                case MessageBoxResult.No: // откатить транзакцию
                    transact.Rollback(); break;
            }
            connection.Close();
            SNPName.Text = "";
            DisciplineName.Text = "";

        }



        #region Config
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var setting = new ConnectionStringSettings
            {
                Name = "MyConnectionString1",
                ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Discipline;Integrated Security=True;"
            };
            Configuration config;
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(setting);
            config.Save();

            string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Discipline;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);
            try {
                connection.Open();
                MessageBox.Show(connection.State.ToString());
                MessageBox.Show(ConfigurationManager.ConnectionStrings["MyConnetionString1"].ConnectionString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
