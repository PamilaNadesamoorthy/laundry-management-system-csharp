using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem.Properties
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
            lblWrong.Visible = false;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible = false;
            this.progressBar1.Value = 100;
            
        }

        int abc = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if (abc == 10)
            {
                abc = 0;
                if (txtUsername.Text == "Laundry" && txtPassword.Text == "12345")
                {
                    this.Hide();
                    timer1.Stop();

                }

                else
                {
                    lblWrong.Visible = true;
                    timer1.Stop();
                    panel1.Visible = true;

                }

            }
        }
       
    }
}
