using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANG
{
    public partial class frmTONGHOPNHAPXUAT : Form
    {
        public frmTONGHOPNHAPXUAT()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xprt_TONGHOPNHAPXUAT xprt = new Xprt_TONGHOPNHAPXUAT(txt_ngayBD.Text, txt_ngayKT.Text);
            xprt.lbl_ThoiGian.Text = "Từ " + txt_ngayBD.Text + " Đến " + txt_ngayKT.Text;
            ReportPrintTool print = new ReportPrintTool(xprt);
            print.ShowPreviewDialog();
            //this.Close();
        }

        private void frmTONGHOPNHAPXUAT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
