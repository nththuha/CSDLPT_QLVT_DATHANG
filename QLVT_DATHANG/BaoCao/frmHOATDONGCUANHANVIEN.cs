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
    public partial class frmHOATDONGCUANHANVIEN : Form
    {
        public frmHOATDONGCUANHANVIEN()
        {
            InitializeComponent();
        }

        private void frmHOATDONGCUANHANVIEN_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOTENNVTableAdapter.Fill(this.DS.HOTENNV);
            cbb_MaNV.SelectedIndex = 0;
            cbb_Loai.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(de_NgayBD.Text == "" || de_NgayKT.Text == "")
            {
                MessageBox.Show("Ngày bắt đầu và kết thúc không được để trống!","", MessageBoxButtons.OK);
                return;
            }
            String temp;
            if (cbb_Loai.SelectedIndex == 0) temp = "N";
            else temp = "X";
            Xprt_HOATDONGCUANHANVIEN rp = new Xprt_HOATDONGCUANHANVIEN(int.Parse(cbb_MaNV.Text), de_NgayBD.Text, de_NgayKT.Text, temp);
            rp.lb_MaNV.Text = cbb_MaNV.Text;
            rp.lb_HoTen.Text = lb_HoTen.Text;
            rp.lb_CN.Text = lb_MaCN.Text;
            rp.lb_DiaChi.Text = lb_DiaChi.Text;
            rp.lb_Luong.Text = lb_Luong.Text;
            rp.lb_NgaySinh.Text = lb_NgaySinh.Text;
            rp.xrTitle.Text = rp.xrTitle.Text + " PHIẾU " + cbb_Loai.SelectedItem.ToString();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void frmHOATDONGCUANHANVIEN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
