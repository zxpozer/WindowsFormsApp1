using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void закрити_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закриває програму
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
                lblResult.Text = ""; // Очищення попереднього результату

                double a = ValidateInput(textBoxA);
                double b = ValidateInput(textBoxB);
                double c = ValidateInput(textBoxC);

                if ((a == b) || (a == c) || (b == c))
                {
                    lblResult.Text = "Трикутник рівнобедрений.";
                }
                else
                {
                    lblResult.Text = "Трикутник не рівнобедрений.";
                }
            }

            // Метод для валідації введених значень
            private double ValidateInput(TextBox textBox)
            {
                double value;
                if (!double.TryParse(textBox.Text, out value))
                {
                    value = 5;
                    textBox.Text = "5";
                    textBox.ForeColor = Color.Red; // Якщо некоректне значення, зробити текст червоним
                }
                return value;
            }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програма для перевірки трикутника.\nАвтор: Фурс Богдан 2024", "Про програму");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

