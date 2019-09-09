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
    public partial class danhsachphong : Form
    {
                private void danhsachphong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bt_loc_Click(object sender, EventArgs e)
        {

            if(rd_t.Checked == true)
            {
                dt.Clear();
                dt = cl.danhsachpt(0);
                dg.DataSource = dt;
                bt_xoa.Enabled = true;
            }
            if(rd_kt.Checked == true)
            {
                dt.Clear();
                dt = cl.danhsachpkt(0);
                dg.DataSource = dt;
                bt_xoa.Enabled = true;
            }
            else
            {
                
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            load();
        }

        private void rd_t_Click(object sender, EventArgs e)
        {
            bt_loc.Enabled = true;
            bt_xoa.Enabled = false;
            
        }

        private void rd_kt_Click(object sender, EventArgs e)
        {
            bt_loc.Enabled = true;
            bt_xoa.Enabled = false;
        }

        private void rd_kt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_t_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
