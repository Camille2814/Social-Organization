using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Organization.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dashboardUC1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
            labelTitle.Text = "Dashboard";


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void donersUC1_Load(object sender, EventArgs e)
        {

        }

        private void dashboardUC1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            donersUC1.BringToFront();
            labelTitle.Text = "Add or update Doner's record";
        }
    }
}
