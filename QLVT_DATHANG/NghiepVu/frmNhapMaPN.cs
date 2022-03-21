using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class frmNhapMaPN : Form
    {
        public frmNhapMaPN()
        {
            InitializeComponent();
        }

        private void frmNhapMaPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNhapMaPN.Text != "")
            {
                Program.formPhieuNhap.txt_MaPN_PN.Text = txtNhapMaPN.Text;
                Program.formPhieuNhap.txt_MaPN_CTPN.Text = txtNhapMaPN.Text;
                this.Close();
            }
        }
    }
}
