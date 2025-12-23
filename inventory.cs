using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaundryManagementSystem.Properties
{
    public partial class inventory : UserControl
    {
        function fn = new function();
        String query;
        public inventory()
        {
            InitializeComponent();
            dataInventory.Visible = false;
        }

        private void btnInvUpdate_Click(object sender, EventArgs e)
        {
            dataInventory.Visible = true;

            if (txtInvDate.Text != "" && txtInvDetergent.Text != "" && txtInvSoftner.Text != "" && txtInvChemical.Text != "" )
            {
                DateTime stockdate = txtInvDate.Value;
                String detergent = txtInvDetergent.Text;
                String softner = txtInvSoftner.Text;
                String chemical = txtInvChemical.Text;

                query = "insert into inventoryHistory (stockdate, detergent, softner, chemical) values('"+stockdate+"','" + detergent + "','" + softner + "','" + chemical + "')";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Fill all the fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void inventory_Enter(object sender, EventArgs e)
        {
            query = "select * from inventoryHistory";
            DataSet ds = fn.getData(query);
            dataInventory.DataSource = ds.Tables[0];
        }
        int aid;
        private void dataInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataInventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                aid = int.Parse(dataInventory.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from inventoryHistory where iid =" + aid + "";
            DataSet ds = fn.getData(query);

            lblInvDetergent.Text = ds.Tables[0].Rows[0][1].ToString();
            lblInvSoftner.Text = ds.Tables[0].Rows[0][2].ToString();
            lblInvChemical.Text = ds.Tables[0].Rows[0][3].ToString();
            lblInvDate.Text = ds.Tables[0].Rows[0][4].ToString();
            
        }

        private void inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
