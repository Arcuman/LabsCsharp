using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
    /// Interaction logic for AddFrame.xaml
    /// </summary>
    public partial class AddFrame : Page
    {
        private string ImagePath;
        public AddFrame()
        {
            InitializeComponent();
        }
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (Discipline.IsChecked == true)
            {
                DisciplinePanel1.Visibility = Visibility.Visible;
                DisciplinePanel2.Visibility = Visibility.Visible;
                LectorPanel1.Visibility = Visibility.Collapsed;
                LectorPanel2.Visibility = Visibility.Collapsed;
            }
            if (Lector.IsChecked == true)
            {
                DisciplinePanel1.Visibility = Visibility.Collapsed;
                DisciplinePanel2.Visibility = Visibility.Collapsed;
                LectorPanel1.Visibility = Visibility.Visible;
                LectorPanel2.Visibility = Visibility.Visible;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnetionString1"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (Discipline.IsChecked == true)
                    {
                        using (SqlCommand cmd = new SqlCommand("insert_Disciplines", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            SqlParameter name = new SqlParameter("@name", SqlDbType.NVarChar);
                            name.Value = DisciplineName.Text;
                            cmd.Parameters.Add(name);
                            

                            SqlParameter term = new SqlParameter("@term", SqlDbType.Int);
                            term.Value = Int32.Parse(Term.Text);
                            cmd.Parameters.Add(term);
                           

                            SqlParameter course = new SqlParameter("@course", SqlDbType.Int);
                            course.Value = Int32.Parse(Course.Text);
                            cmd.Parameters.Add(course);
                           

                            SqlParameter specialization = new SqlParameter("@specialization", SqlDbType.NVarChar);
                            specialization.Value = Specialization.Text;
                            cmd.Parameters.Add(specialization);
                            

                           SqlParameter lecturesCount = new SqlParameter("@lecturesCount", SqlDbType.Int);
                            lecturesCount.Value = (int)(LecturesCount.Value);
                            cmd.Parameters.Add(lecturesCount);
                            

                            SqlParameter labsCount = new SqlParameter("@labsCount", SqlDbType.Int);
                            labsCount.Value = (int)(LabsCount.Value);
                            cmd.Parameters.Add(labsCount);
                            

                            SqlParameter controlType = new SqlParameter("@controlType", SqlDbType.NVarChar);
                            controlType.Value = ControlType.Text;
                            cmd.Parameters.Add(controlType);
                            
                            cmd.ExecuteNonQuery();
                            ControlType.Text = "";
                            LabsCount.Value = 0;
                            LecturesCount.Value = 0;
                            Specialization.Text = "";
                            Course.Text = "";
                            Term.Text = "";
                            DisciplineName.Text = "";
                        }
                    }
                    else if (Lector.IsChecked == true)
                    {
                        using (SqlCommand cmd = new SqlCommand("insert_Lectors", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            SqlParameter snp = new SqlParameter("@snp", SqlDbType.NVarChar);
                            snp.Value = SNP.Text;
                            cmd.Parameters.Add(snp);
                           
                            SqlParameter auditory = new SqlParameter("@auditory", SqlDbType.Int);
                            auditory.Value = Int32.Parse(Auditory.Text);
                            cmd.Parameters.Add(auditory);

                            SqlParameter pulpit = new SqlParameter("@pulpit", SqlDbType.NVarChar);
                            pulpit.Value = Pulpit.Text;
                            cmd.Parameters.Add(pulpit);
                            
                            byte[] imageData;
                            string tempImagePath = ImagePath + "temp";
                            File.Copy(ImagePath, tempImagePath);
                            using (FileStream fs = new FileStream(tempImagePath, FileMode.Open))
                            {
                                imageData = new byte[fs.Length];
                                fs.Read(imageData, 0, imageData.Length);
                            }
                            File.Delete(tempImagePath);
                            SqlParameter data = new SqlParameter("@data", SqlDbType.VarBinary);
                            data.Value = imageData;
                            cmd.Parameters.Add(data);

                            cmd.ExecuteNonQuery();
                            SNP.Text = "";
                            Auditory.Text = "";
                            Pulpit.Text = "";
                            Photo.Source = null;
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Set_Image(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image|*.png|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                ImageSourceConverter converter = new ImageSourceConverter();
                Photo.Source = (ImageSource)converter.ConvertFrom(dialog.FileName);
                ImagePath = dialog.FileName;
            }
        }
    }
}
