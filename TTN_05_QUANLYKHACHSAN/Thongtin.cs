using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlks
{
    public partial class Thongtin : Form
    {
        public Thongtin()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Thongtin_Load(object sender, EventArgs e)
        {
            string t = "Http://Facebook.com";
            webBrowser1.Navigate(t);
        }

        
        private void bt_2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
