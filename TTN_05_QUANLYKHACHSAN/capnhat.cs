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
    public partial class capnhat : Form
    {
        public capnhat()
        {
            InitializeComponent();
        }

        public static int maphong;
        public int madv = 0, giadv = 0, dongia = 0;
        public string tendv = null;
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        private void form_load()
        {
            dt.Clear();
            txt_sl.Enabled = false;
            bt_qua.Enabled = false;
            lb_mp.Text = "Number of room : " + maphong.ToString();
            dr = cl.hienchiphiphu(maphong);
            while (dr.Read())
            {

                txt_dc.Text = dr.GetInt32(0).ToString();
                txt_dv.Text = dr.GetString(1);
                txt_gia.Text = dr.GetInt32(2).ToString();
                lb_tt.Text = dr.GetInt32(3).ToString();

            }
            dt = cl.laydichvu(0);
            dataGridView1.DataSource = dt;
        }

      
    }
}
