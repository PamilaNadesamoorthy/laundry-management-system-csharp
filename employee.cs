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
    public partial class employee : UserControl
    {
        function fn = new function();
        String query;
        public employee()
        {
            InitializeComponent();
        }

        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text != "" && txtEmpMobile.Text != "" && txtEmpNIC.Text != "" && txtEmpAddress.Text != "" && txtEmpDOB.Text != "" && txtEmpGender.Text != "" && txtEmpRole.Text != "")
            {
                String ename = txtEmpName.Text;
                String emobile = txtEmpMobile.Text;
                String enic = txtEmpNIC.Text;
                String eaddress = txtEmpAddress.Text;
                String edob = txtEmpDOB.Text;
                String egender = txtEmpGender.Text;
                String erole = txtEmpRole.Text;

                query = "insert into employeeDetails (ename,emobile,enic,eaddress,edob,egender,erole) values('" + ename + "','" + emobile + "','" + enic + "','" + eaddress + "','" + edob + "','" + egender + "','" + erole + "')";
                fn.setData(query);
            }
            else 
            {
                MessageBox.Show("Fill all the fields.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnEmpReset_Click(object sender, EventArgs e)
        {
            txtEmpName.Clear();
            txtEmpMobile.Clear();
            txtEmpNIC.Clear();
            txtEmpAddress.Clear();    
            txtEmpGender.SelectedIndex = -1;
            txtEmpRole.SelectedIndex = -1;
        }
    }
}
