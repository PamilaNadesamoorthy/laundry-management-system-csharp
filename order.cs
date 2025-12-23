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
    public partial class order : UserControl
    {
        function fn = new function();
        String query;

       
        public order()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            lblBill.Visible = false;
            lblShowBill.Visible = false;
        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void order_Load(object sender, EventArgs e)
        {

        }

        private void btnOrderSave_Click(object sender, EventArgs e)
        {

            if (txtWeight.Text != "" && txtType.Text != "" && txtOrderDate.Text != "" && txtDelivery.Text != "" && txtSpecCase.Text != "")
            {
                String stuffsweight = txtWeight.Text;
                String washingtype = txtType.Text;
                String orderdate = txtOrderDate.Text;
                String deliverydate = txtDelivery.Text;
                String specialcriteria = txtSpecCase.Text;

                query = "insert into orderDetails(stuffsweight, washingtype, orderdate, deliverydate, specialcriteria) values(" + stuffsweight + ", '" + washingtype + "', '" + orderdate + "', '" + deliverydate + "', '" + specialcriteria + "')";

                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Fill all the fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrderReset_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtType.SelectedIndex = -1;
            txtSpecCase.SelectedIndex = -1;
            groupBox1.Visible = false;
            lblShowBill.Visible = false;
            lblBill.Visible = false;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            lblBill.Visible = true;
            lblShowBill.Visible = true;

            double stuffsweight;

            if (!double.TryParse(txtWeight.Text, out stuffsweight))
            {
                MessageBox.Show("Please enter a valid weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double bill = Convert.ToDouble(txtWeight.Text) * 150;
            lblShowBill.Text = bill.ToString();


        }
    }
}
