using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Discipline> serializeListScore = new List<Discipline>();
        List<Discipline> serializeListType = new List<Discipline>();
        Discipline discipline;
        List<Discipline> disciplines;
        List<Book> books;
        Timer timer;
        public Form1()
        {
            books = new List<Book>();
            disciplines = new List<Discipline>();
            InitializeComponent();
            DateTimeChange.Text = DateTime.Now.ToLongTimeString();
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void DisciplineName_Enter(object sender, EventArgs e)
        {
            if (DisciplineName.Text == "Название дисциплины")
                DisciplineName.Text = "";
        }
        private void LecturesCount_ValueChanged(object sender, EventArgs e)
        {
            LecturesCountValue.Text = LecturesCount.Value.ToString();
        }

        private void LabsCount_ValueChanged(object sender, EventArgs e)
        {
            LabsCountValue.Text = LabsCount.Value.ToString();
        }

        private void SNP_Enter(object sender, EventArgs e)
        {
            if (SNP.Text == "Ф.И.О.")
                SNP.Text = "";
        }
        private void Pulpit_Enter(object sender, EventArgs e)
        {
            if (Pulpit.Text == "Кафедра")
                Pulpit.Text = "";
        }
        private void BookName_Enter(object sender, EventArgs e)
        {
            if (BookName.Text == "Название")
                BookName.Text = "";
        }
        private void Author_Enter(object sender, EventArgs e)
        {
            if (Author.Text == "Автор")
                Author.Text = "";
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (Author.Text == "" || Author.Text == "Автор" ||
                BookName.Text == "" || BookName.Text == "Название")
                MessageBox.Show("Укажите книгу корректно");
            else
            {
                Book book = new Book(Author.Text, BookName.Text, CreationDate.Value.Date);
                books.Add(book);
                BookList.Items.Add(book.ToString());
            }
        }
        private void AddAll_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (CheckBox x in Controls.OfType<CheckBox>())
                if (x.Checked)
                {
                    flag = true;
                    break;
                }
            foreach (RadioButton x in ControlPanel.Controls.OfType<RadioButton>())
                if (x.Checked)
                {
                    flag = true;
                    break;
                }
            //foreach (TextBox x in Controls.OfType<TextBox>())
            //    if (x.Text == "")
            //    {
            //        flag = false;
            //        break;
            //    }
            int buf;
            if (!flag ||
                DisciplineName.Text == "Название дисциплины" ||
                SemestrValue.Text == "" ||
                SNP.Text == "Ф.И.О" ||
                Pulpit.Text == "Кафедра" ||
                books.Count == 0 || LecturesCountValue.Text == "" ||
                LabsCountValue.Text == "" ||
                int.Parse(SemestrValue.Text) > 6)
                MessageBox.Show("Некорректно введены данные");
            else
            {
                discipline = new Discipline(DisciplineName.Text,
                int.Parse(SemestrValue.Text), (int)CourseValue.Value,
                new Spec(SpecializationPOIT.Checked, SpecializationPOIBMS.Checked,
                SpecializationISIT.Checked, SpecializationDEVI.Checked),
                LecturesCount.Value, LabsCount.Value, ((exam.Checked) ? PassType.Exam : PassType.Test),
                new Lector(SNP.Text, Pulpit.Text, (int)NumberAudit.Value, (int)CorpusAydit.Value), books);


                var results = new List<ValidationResult>();
                var context = new ValidationContext(discipline);
                if (!Validator.TryValidateObject(discipline, context, results, true))
                {
                    foreach (var error in results)
                    {
                        string strWithErrroe = error.ErrorMessage;
                        MessageBox.Show(strWithErrroe);
                    }
                    return;
                }

                try
                {
                    DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                    using (FileStream File = new FileStream("Serialize.json", FileMode.Open))
                    {
                        disciplines = (List<Discipline>)Serializer.ReadObject(File);
                    }
                }
                catch { }
                disciplines.Add(discipline);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                using (FileStream file = new FileStream("Serialize.json", FileMode.OpenOrCreate))
                {
                    serializer.WriteObject(file, disciplines);
                }
                disciplines.Clear();
                BookList.Items.Clear();
                books.Clear();
                CountOfObject.Text = countObj().ToString();
                LastAction.Text = "Добавление дисциплины";
            }
        }
        private void Output_Click(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                using (FileStream file = new FileStream("Serialize.json", FileMode.Open))
                {
                    disciplines = (List<Discipline>)serializer.ReadObject(file);
                    OutputList.Nodes.Clear();
                    foreach (Discipline x in disciplines)
                        OutputList.Nodes.Add(x.TakeElementTree());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LastAction.Text = "Вывод всех дисциплины";
        }
        private void SNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            e.Handled = Char.IsDigit(e.KeyChar);

            if (Char.IsDigit(e.KeyChar))
                error.SetError(SNP, "Цифры не допустимы");
            else
                error.SetError(SNP, "");
        }

        private void LectorSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));

                using (FileStream file = new FileStream("Serialize.json", FileMode.Open))
                {
                    disciplines = (List<Discipline>)serializer.ReadObject(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SearchForm form = new SearchForm(disciplines, SearchType.Lector);
            form.Show();
            LastAction.Text = "Поиск по лектору";
        }

        private void SemestrSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));

                using (FileStream file = new FileStream("Serialize.json", FileMode.Open))
                {
                    disciplines = (List<Discipline>)serializer.ReadObject(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SearchForm form = new SearchForm(disciplines, SearchType.Semestr);
            form.Show();
            LastAction.Text = "Поиск по семестру";
        }

        private void CourseSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));

                using (FileStream file = new FileStream("Serialize.json", FileMode.Open))
                {
                    disciplines = (List<Discipline>)serializer.ReadObject(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SearchForm form = new SearchForm(disciplines, SearchType.Course);
            form.Show();
            LastAction.Text = "Поиск по курсу";
        }

        private void Example1_Click(object sender, EventArgs e)
        {
            DisciplineName.Text = "Высшая математика";
            SemestrValue.Text = "1";
            CourseValue.Value = 1;
            SpecializationPOIT.Checked = true;
            SpecializationDEVI.Checked = true;
            LecturesCount.Value = 20;
            LabsCount.Value = 30;
            exam.Checked = true;
            SNP.Text = "Ловенецкая Е.И.";
            Pulpit.Text = "Высшей математики";
            NumberAudit.Value = 210;
            CorpusAydit.Value = 4;
            books.Add(new Book("Ловенецкая Е.В.", "Высшая математика", DateTime.Parse("01.05.2008")));
            BookList.Items.Add("Ловенецкая Е.В. \"Высшая математика\" 01.05.2008");
            books.Add(new Book("Асмыкович А.А.", "Математика это просто", DateTime.Parse("04.03.2007")));
            BookList.Items.Add("Асмыкович А.А. \"Математика это просто\" 04.03.2007");
            books.Add(new Book("Ловенецкая Е.И. Асмыкович А.А", "Базовый курс высшей математики", DateTime.Parse("15.07.2008")));
            BookList.Items.Add("Ловенецкая Е.И. Асмыкович А.А \"Базовый курс высшей математики\" 15.07.2008");
        }
        private void LecturesSort_Click(object sender, EventArgs e)
        {
            serializeListScore.Clear();
            try
            {
                DataContractJsonSerializer serializer1 = new DataContractJsonSerializer(typeof(List<Discipline>));
                using (FileStream file1 = new FileStream("Serialize.json", FileMode.Open))
                {
                    disciplines = (List<Discipline>)serializer1.ReadObject(file1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var tempCollection = from dicc in disciplines
                                 let sort = dicc.LecturesCount
                                 orderby sort
                                 select sort;

            foreach (int d in tempCollection)
            {
                foreach (Discipline outS in disciplines)
                {
                    if (outS.LecturesCount == d)
                    {
                        serializeListScore.Add(outS);
                        disciplines.Remove(outS);
                        break;
                    }
                }
            }

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
            using (FileStream file = new FileStream("Serialize.json", FileMode.OpenOrCreate))
            {
                serializer.WriteObject(file, serializeListScore);
            }
            disciplines.Clear();
            Output_Click(sender, e);
            LastAction.Text = "Сортировка по количеству лекций";
        }


        private void PassTypeSort_Click(object sender, EventArgs e)
        {
            serializeListType.Clear();
            try
            {
                DataContractJsonSerializer serializer1 = new DataContractJsonSerializer(typeof(List<Discipline>));
                using (FileStream file1 = new FileStream("Serialize.json", FileMode.Open))
                {
                    disciplines = (List<Discipline>)serializer1.ReadObject(file1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var tempCollection = from dicc in disciplines
                                 let sort = dicc.pass
                                 orderby sort
                                 select sort;

            foreach (int d in tempCollection)
            {
                foreach (Discipline outS in disciplines)
                {
                    if ((int)outS.pass == d)
                    {
                        serializeListType.Add(outS);
                        disciplines.Remove(outS);
                        break;
                    }
                }
            }

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
            using (FileStream file = new FileStream("Serialize.json", FileMode.OpenOrCreate))
            {
                serializer.WriteObject(file, serializeListType);
            }
            disciplines.Clear();
            Output_Click(sender, e);
            LastAction.Text = "Сортировка по виду контроля";
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (serializeListScore.Count != 0 && serializeListScore.Count != 0)
            {
                using (FileStream fileXML = new FileStream("usersSortScore.xml", FileMode.OpenOrCreate))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Discipline>));
                    xml.Serialize(fileXML, serializeListScore);
                }
                using (FileStream fileXML = new FileStream("usersSortType.xml", FileMode.OpenOrCreate))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Discipline>));
                    xml.Serialize(fileXML, serializeListType);
                }
                MessageBox.Show("Сохранено");
            }
            else
            {
                MessageBox.Show("Нечего сохранять !");
            }
            LastAction.Text = "Сохранение результатов сортировок";
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия:" + Application.ProductVersion.ToString() + "\nФИО: Борисов Антон Андреевич");
            LastAction.Text = "Узнать больше";
        }

        private void fixTool_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CountOfObject.Text = countObj().ToString();
            LastAction.Text = "";
        }

        private int countObj()
        {
            List<Discipline> disciplinesTemp;
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                using (FileStream file = new FileStream("Serialize.json", FileMode.Open))
                {
                    disciplinesTemp = (List<Discipline>)serializer.ReadObject(file);
                }
                return disciplinesTemp.Count;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        void timer_Tick(object sender, EventArgs e)
        {
            DateTimeChange.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
