using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedRole = comboBox1.SelectedItem.ToString();
            string password = textBox2.Text;


            if (!string.IsNullOrEmpty(password))
            {

                if (selectedRole == "Бегун" && password == "11")
                {
                    Form1 Form1 = new Form1();
                    Form1.Show();
                    this.Hide();
                }
                else if (selectedRole == "Координатор" && password == "22")
                {
                    Form1 Form1 = new Form1();
                    Form1.Show();
                    this.Hide();
                }
                else if (selectedRole == "Админитратор" && password == "33")
                {
                    Form1 Form1 = new Form1();
                    Form1.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Неверный пароль для выбранной роли");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите пароль");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
