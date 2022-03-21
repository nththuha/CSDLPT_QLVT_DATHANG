using DevExpress.XtraReports.UI;
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
    public partial class frmCTTriGiaNhapXuat : Form
    {
        public frmCTTriGiaNhapXuat()
        {
            InitializeComponent();
            txt_Nhom.Text = Program.mGroup;
            cbb_LoaiPhieu.SelectedIndex = 1;
            cbb_LoaiPhieu.SelectedIndex = 0;
        }

        private void frmCTTriGiaNhapXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dtp_NgayBD.Text == "")
            {
                MessageBox.Show("Ngày bắt đầu không được để trống", "", MessageBoxButtons.OK);
                dtp_NgayBD.Focus();
                return;
            }
            if (dtp_NgayKT.Text == "")
            {
                MessageBox.Show("Ngày kết thúc không được để trống", "", MessageBoxButtons.OK);
                dtp_NgayKT.Focus();
                return;
            }
            String temp = "";
            if (cbb_LoaiPhieu.SelectedIndex == 0) temp = "NHẬP";
            else temp = "XUẤT";
            Xprt_CHITIETTRIGIANHAPXUAT rp = new Xprt_CHITIETTRIGIANHAPXUAT(dtp_NgayBD.DateTime, dtp_NgayKT.DateTime, txt_Nhom.Text, cbb_LoaiPhieu.SelectedItem.ToString());
            rp.lb_Tittle.Text = "CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ HÀNG " +  temp;
            rp.lb_Ngay.Text = "Thời gian: " + dtp_NgayBD.Text + " - " + dtp_NgayKT.Text;
            ReportPrintTool rpt = new ReportPrintTool(rp);
            rp.ShowPreviewDialog();
        }
    }
}
