using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Text = "Hello world";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.Text = "Hello Shuva.!!";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn1.Text = "None";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
        }
    }
}
