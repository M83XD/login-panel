using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "bist" && textBox2.Text == "3232")
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                progressBar1.Visible = true;

            }
else
            {
                
                MessageBox.Show("Ulan kullanıcı adını ve şifreni düzgün gir yoksa banlarım seni he!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Step = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 5;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

       
    }
}
