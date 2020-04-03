using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SearchForm : Form
    {
        List<Discipline> disciplines;
        public SearchForm(List<Discipline> _disciplines, SearchType type)
        {
            disciplines = _disciplines;
            InitializeComponent();
            Panel1.Visible = (type == SearchType.Lector);
            Panel2.Visible = (type == SearchType.Semestr);
            Panel3.Visible = (type == SearchType.Course);
        }

        private void LectorSNP_TextChanged(object sender, EventArgs e)
        {
            Result.Nodes.Clear();
            if (FullSearch.Checked)
            {
                foreach (Discipline x in disciplines)
                    if (x.LectorInfo.snp == LectorSNP.Text)
                        Result.Nodes.Add(x.TakeElementTree());
            }
            else
            {
                Regex regex = new Regex("(" + LectorSNP.Text + ")", RegexOptions.IgnoreCase);
                foreach (Discipline x in disciplines)
                    if (regex.IsMatch(x.LectorInfo.snp))
                        Result.Nodes.Add(x.TakeElementTree());
            }
        }
        private void SemestrNumber_TextChanged(object sender, EventArgs e)
        {
            Result.Nodes.Clear();
            int n;
            if (int.TryParse(SemestrNumber.Text, out n))
                foreach (Discipline x in disciplines)
                    if (n == x.Semestr)
                        Result.Nodes.Add(x.TakeElementTree());
        }

        private void CourseNumber_ValueChanged(object sender, EventArgs e)
        {
            Result.Nodes.Clear();
            foreach (Discipline x in disciplines)
                if (x.couse == CourseNumber.Value)
                    Result.Nodes.Add(x.TakeElementTree());
        }

    }
}
