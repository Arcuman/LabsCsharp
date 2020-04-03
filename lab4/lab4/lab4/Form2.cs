using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form2 : Form
    {
        Collection collection = new Collection();
        public Form2()
        {
            InitializeComponent();
        }

        private void Generation_Click(object sender, EventArgs e)
        {

            try
            {
                collection.Generate(Convert.ToInt32(textBox1.Text));
                listBox2.Items.Clear();
                listBox1.Items.Clear();
                foreach (var item in collection.users)
                listBox1.Items.Add(item.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: " + "Enter a number");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }

        }

        private void Sort_Ascending_click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            collection.lowerSort();
            foreach (User user in collection.users)
            {
                listBox2.Items.Add(user.ToString());
            }
        }

        private void Sort_Descending_click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            collection.lowerSort();
            for (int i = collection.users.Count; i > 0; i--)
            {
                listBox2.Items.Add(collection.users[i - 1].ToString());
            }
        }

        private void TheYoungest_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add(collection.GetMin());
        }

        private void TheOldest_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add(collection.GetMax());
        }
    }
}
