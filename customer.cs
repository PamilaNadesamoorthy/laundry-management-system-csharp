using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem.Properties
{
    public partial class customer : UserControl
    {
        function fn = new function();
        String query;
        public customer()
        {
            InitializeComponent();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnCusSave_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text != "" && txtCusMobile.Text != "" && txtCusNIC.Text != "" && txtCusNotification.Text != "" && txtCusAddress.Text != "")
            {
                String cname = txtCusName.Text;
                String cmobile = txtCusMobile.Text;
                String cnic = txtCusNIC.Text;
                String notificationprefer = txtCusNotification.Text;
                String caddress = txtCusAddress.Text;

                query = "insert into customerDetails (cname,cmobile,cnic,notificationprefer,caddress) values('" + cname + "','" + cmobile + "','" + cnic + "','" + notificationprefer + "','" + caddress + "')";
                fn.setData(query);
            }
            else 
            {
                MessageBox.Show("Fill All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCusReset_Click(object sender, EventArgs e)
        {
            txtCusName.Clear();
            txtCusMobile.Clear();
            txtCusNIC.Clear();
            txtCusNotification.SelectedIndex = -1;
            txtCusAddress.Clear();
            
       
        }
    }
}
