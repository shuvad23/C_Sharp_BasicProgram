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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string id=box1.Text;
            string pass = box2.Text;


            if(id == "111" && pass == "222")
            {
                Form1 va = new Form1();
                va.Show();
            }
            else
            {
                MessageBox.Show("User ID and Password are wrong---");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            box1.Text = "";
            box2.Text = "";
        }
    }
}
