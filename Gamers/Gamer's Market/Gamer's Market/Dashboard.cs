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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            market.Show();
            market.BringToFront();

            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Signin signin = new Signin();
            signin.Show();
            signin.BringToFront();

            Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ActiveBids activeBids = new ActiveBids();
            activeBids.Show();
            activeBids.BringToFront();

            Visible = false;
        }
    }
}
