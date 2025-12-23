using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order1.Visible = true;
            order1.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            homebtnpanel.Visible = false;
            customer1.Visible = false;
            employee1.Visible = false;
            order1.Visible=false;
            cusHistory1.Visible = false;
            inventory1.Visible = false;
        }

        private void customer1_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer1.Visible=true;
            customer1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            employee1.Visible=true;
            employee1.BringToFront();
        }

        private void btnCusHistory_Click(object sender, EventArgs e)
        {
            cusHistory1.Visible=true;
            cusHistory1.BringToFront();
        }

        private void btnInventoryHistory_Click(object sender, EventArgs e)
        {
            inventory1.Visible=true;
            inventory1.BringToFront();
        }

        private void login1_VisibleChanged(object sender, EventArgs e)
        {
            homebtnpanel.Visible=true;
            //btnCustomer.PerformClick();
        }
    }
}
