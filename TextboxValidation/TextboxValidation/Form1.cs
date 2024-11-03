using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextboxValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox2.Text)
            {
                MessageBox.Show("logged in");
            }
            else
            {
                MessageBox.Show("enter correct password");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox2.Text)
            {
                label4.ForeColor = Color.Green;
                label4.Text = "Lgoin";
                
            }
            else
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Wrong Password";
            }
        }
    }
}
