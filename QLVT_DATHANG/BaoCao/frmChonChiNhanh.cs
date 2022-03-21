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
    public partial class frmChonChiNhanh : Form
    {
        public frmChonChiNhanh()
        {
            InitializeComponent();
            cbb_ChiNhanh.DataSource = Program.bds_dspm;
            cbb_ChiNhanh.DisplayMember = "TENCN";
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            cbb_ChiNhanh.SelectedItem = Program.mChinhanh;
        }

        private void frmChonChiNhanh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void cbb_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_ChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.servername = cbb_ChiNhanh.SelectedValue.ToString();

            if (cbb_ChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xprt_INDANHSACHNHANVIEN rpDSNV = new Xprt_INDANHSACHNHANVIEN();
            ReportPrintTool rpt = new ReportPrintTool(rpDSNV);
            rpDSNV.ShowPreviewDialog();
        }
    }
}
