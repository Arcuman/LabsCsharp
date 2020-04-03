using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    public enum SearchType
    {
        Lector = 0,
        Semestr = 1,
        Course = 2
    }
    [DataContract]
    public struct Spec
    {
        [DataMember]
        public bool POIT;
        [DataMember]
        public bool POIBMS;
        [DataMember]
        public bool ISIT;
        [DataMember]
        public bool DEVI;
        public Spec(bool poit, bool poibms, bool isit, bool devi)
        {
            POIT = poit;
            POIBMS = poibms;
            ISIT = isit;
            DEVI = devi;
        }
        public override string ToString()
        {
            return (POIT ? "ПОИТ " : "") +
                (POIBMS ? "ПОИБМС " : "") +
                (ISIT ? "ИСИТ " : "") +
                (DEVI ? "ДЭВИ" : "");
        }
    }
    [DataContract]
    public enum PassType
    {
        Exam = 0,
        Test = 1
    }
    [DataContract]
    public class Lector
    {
        [DataMember]
        public string SNP; // Surname Name Patronomic
        [DataMember]
        public string Pulpit;
        [DataMember]
        public string MainWorkPlace;
        public Lector(string snp, string pulpit, int number, int building)
        {
            SNP = snp;
            Pulpit = pulpit;
            MainWorkPlace = number.ToString() + '-' + building.ToString();
        }
        public Lector()
        {
        }
        public string snp => SNP;
        public string pulpit => Pulpit;
        public string WorkPlace => MainWorkPlace;
    }
    [DataContract]
    public class Book
    {
        [DataMember]
        public string Author;
        [DataMember]
        public string Name;
        [DataMember]
        public DateTime CreationDate;
        public Book(string author, string name, DateTime date)
        {
            Author = author;
            Name = name;
            CreationDate = date;
        }
        public Book()
        { }
        public override string ToString() =>
            Author +
            " \"" + Name +
            "\" " + CreationDate.Day.ToString() + '.' + CreationDate.Month.ToString() + '.' + CreationDate.Year.ToString();
    }

    [DataContract]
    public class Discipline
    {
        [DataMember]
        [Required (ErrorMessage = "Введите имя дисциплины")]
        [RegularExpression (@"\D(\w|\s)*", ErrorMessage = "Дисциплина не может начинаться с цифры")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Недопустимая длина имени")]
        public string Name { get; set; }
        [DataMember]
        [Semestr]
        [Required]
        public int Semestr { get; set; }
        [DataMember]
        public int Course;
        [DataMember]
        public Spec specialization;
        [DataMember]
        [Required]
        public int LecturesCount;
        [DataMember]
        [Required (ErrorMessage = "Не указано имя пользователя")]
        public int LabsCount;
        [DataMember]
        public PassType pass;
        [DataMember]
        public Lector lector;
        [DataMember]
        public List<Book> bookList;
        public Lector LectorInfo => lector;
        public int couse => Course;
        public Discipline()
        {

        }
        public Discipline(string name,
            int semestr,
            int course,
            Spec spec,
            int lectcount,
            int labscount,
            PassType type,
            Lector lect,
            IEnumerable<Book> books)
        {
            try
            {
                Name = name;
                Semestr = semestr;
                Course = course;
                specialization = spec;
                LecturesCount = lectcount;
                LabsCount = labscount;
                pass = type;
                lector = lect;
                bookList = new List<Book>(books);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public TreeNode TakeElementTree()
        {
            TreeNode name = new TreeNode(Name);
            name.Nodes.Add("Курс: " + Course);
            name.Nodes.Add("Семестр: " + Semestr);
            name.Nodes.Add("Специальность: " + specialization);
            name.Nodes.Add("Количество лекций: " + LecturesCount);
            name.Nodes.Add("Количество лаб: " + LabsCount);
            name.Nodes.Add("Вид контроля: " + ((pass == PassType.Exam) ? "экзамен" : "зачёт"));
            TreeNode Lector = new TreeNode("Лектор");
            TreeNode books = new TreeNode("Список литературы");
            Lector.Nodes.Add("Ф.И.О.: " + lector.snp);
            Lector.Nodes.Add("Кафедра: " + lector.pulpit);
            Lector.Nodes.Add("Аудитория: " + lector.WorkPlace);
            name.Nodes.Add(Lector);
            foreach (Book x in bookList)
                books.Nodes.Add(x.ToString());
            name.Nodes.Add(books);
            return name;
        }
    }
}
