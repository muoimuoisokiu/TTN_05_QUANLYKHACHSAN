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
    public partial class suaphong : Form
    {
        public suaphong()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        public void suaphong_load()
        {
             dt = cl.loaiphong1(0);
            cb_lp.DataSource = dt;
            cb_lp.DisplayMember = "LoaiPhong";
        }
        private void suaphong_Load(object sender, EventArgs e)
        {

           suaphong_load();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
           
                    private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
