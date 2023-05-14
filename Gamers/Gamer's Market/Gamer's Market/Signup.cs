using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_s_Market
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void signinLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signin signin = new Signin();
            signin.Show();

            Visible = false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Signin signin = new Signin();
            signin.Show();
            signin.BringToFront();

            Visible = false;
        }
    }
}
