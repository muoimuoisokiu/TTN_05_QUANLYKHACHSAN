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
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt;
        public static string taikhoan;
        public void frm_load()
        {
            lb_tk.Text = taikhoan;
            txt_mkm.Clear();
            txt_mkc.Clear();
            txt_nl.Clear();
        }
        private void doimatkhau_Load(object sender, EventArgs e)
        {
            frm_load();

        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
