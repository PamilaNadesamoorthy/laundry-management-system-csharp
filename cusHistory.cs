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
    public partial class cusHistory : UserControl
    {
        function fn = new function();
        String query;
        public cusHistory()
        {
            InitializeComponent();
        }

        private void cusHistory_Enter(object sender, EventArgs e)
        {
            query = "select * from customerDetails";
            DataSet ds = fn.getData(query);
            dataCusHistory.DataSource = ds.Tables[0];
        }
        int bid;
        private void dataCusHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataCusHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) 
            {
                bid = int.Parse(dataCusHistory.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from customerDetails where cid ="+bid+"";
            DataSet ds = fn.getData(query);

            cusNamelabel.Text = ds.Tables[0].Rows[0][1].ToString();
            cusMobilelabel.Text = ds.Tables[0].Rows[0][2].ToString();
            cusNiclabel.Text = ds.Tables[0].Rows[0][3].ToString();
            cusAddresslabel.Text = ds.Tables[0].Rows[0][4].ToString();
            cusNotificationlabel.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void cusHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
