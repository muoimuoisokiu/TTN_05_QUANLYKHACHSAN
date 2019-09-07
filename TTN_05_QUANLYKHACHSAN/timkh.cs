using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qlks
{
    public partial class timkh : Form
    {
        public timkh()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        private int mp;
        private string scm = null;
        private void bt_tk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tk.Text))
            {
                dt.Clear();
                dt = cl.timkhachang(txt_tk.Text);
                try
                {
                    bt_xoa.Enabled = true;
                    dg.DataSource = dt;
                }
                catch (Exception)
                {
                }
                
            }
            else MessageBox.Show("Nh?p !!!", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            bt_xoa.Enabled = false;
            bt_ct.Enabled = false;
            txt_tk.Text = "";
        }
            }
}
