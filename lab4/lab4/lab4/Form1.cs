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
namespace lab4
{

    public partial class Form1 : Form
    {
        private Calculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (calculator.isReplace)
            {
                calculator.Replace_Step2(textBox2.Text);
                textBox2.Text = calculator.EmptyString;
                label1.Text = calculator.EnterString;
                return;
            }
            label1.Text += textBox2.Text;
            calculator.EnterString += textBox2.Text;
            textBox2.Text = calculator.EmptyString;
        }

        private void Reset_click(object sender, EventArgs e)
        {
            try
            {
                if (calculator.isOperation)
                {
                    throw new Exception("Possible only 1 operation");
                }
                textBox2.Text = calculator.EmptyString;
                calculator.EnterString = label1.Text = calculator.EmptyString;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void DeleteOne_Click(object sender, EventArgs e)
        {
            calculator.DeleteOne();
            label1.Text = calculator.EnterString;
        }

        private void Length_Click(object sender, EventArgs e)
        {
            calculator.GetLength();
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            if (calculator.Replace_Step1(textBox2.Text))
            {
                label1.Text += " replace " + calculator.WhatReplace + " on (Enter your string)";
            }

            textBox2.Text = calculator.EmptyString;
        }

        private void DeleteSubString_Click(object sender, EventArgs e)
        {
            calculator.DelteSubString(textBox2.Text);
            textBox2.Text = calculator.EmptyString;
            label1.Text = calculator.EnterString;
        }
        private void GetElemByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.GetElemByIndex(Convert.ToInt32(textBox2.Text));
                textBox2.Text = calculator.EmptyString;
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

        private void Sentence_Click(object sender, EventArgs e)
        {
            calculator.GetSentece();
        }
        private void VowelsAndConsonants_Click(object sender, EventArgs e)
        {
            calculator.GetVowelsAndConsonants();
        }
        private void Words_Click(object sender, EventArgs e)
        {
            calculator.GetWords();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
