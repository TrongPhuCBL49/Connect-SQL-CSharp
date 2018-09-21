using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class ConnectGUI : DevExpress.XtraEditors.XtraForm
    {
        public ConnectGUI()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ConnectBUS.Instance.ConnectDB(txtServerName.Text, txtDatabaseName.Text, txtUserID.Text, txtPassword.Text))
            {
                MessageBox.Show("Kết nối thành công!");
                cboTable.Properties.Items.AddRange(ConnectBUS.Instance.ListTables());
            }
            else
                MessageBox.Show("Có lỗi xảy ra. Kết nối thất bại!");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = null;
            gridView1.Columns.Clear();
            try
            {
                dgvTable.DataSource = ConnectBUS.Instance.table(cboTable.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa kết nối Database");
            }
        }
    }
}
