using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LwindowsForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(box1.Text);
            b = Convert.ToInt32(box2.Text);
            int result = a + b;
            btn4.Text = result.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(box1.Text);
            b = Convert.ToInt32(box2.Text);
            int result = a + b;
            btn4.Text = result.ToString();
        }
    }
}
