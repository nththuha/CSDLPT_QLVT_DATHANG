using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            btn_TaoTaiKhoan.Enabled = btn_DangXuat.Enabled = btn_NhanVien.Enabled = btn_VatTu.Enabled = btn_Kho.Enabled = btn_DatHang.Enabled = btn_PhieuNhap.Enabled = btn_PhieuXuat.Enabled = false;
            btn_DSNhanVien.Enabled = btn_DMVatTu.Enabled = btn_GiaTriHang.Enabled = btn_DDH.Enabled = btn_HoatDongNhanVien.Enabled = btn_TongHop.Enabled = false;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDangNhap = new frmDangNhap();
                Program.formDangNhap.MdiParent = this;
                Program.formDangNhap.Show();
            }
        }

        private void btn_NhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Program.formNhanVien = new frmNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
        }

        private void btn_VatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                Program.formVatTu = new frmVatTu();
                Program.formVatTu.MdiParent = this;
                Program.formVatTu.Show();
            }
        }

        private void btn_Kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                Program.formKho = new frmKho();
                Program.formKho.MdiParent = this;
                Program.formKho.Show();
            }
        }

        private void btn_TaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTaoTaiKhoan = new frmTaoTaiKhoan();
                Program.formTaoTaiKhoan.MdiParent = this;
                Program.formTaoTaiKhoan.Show();
            }
        }

        private void btn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(frmDatHang));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(frmPhieuNhap));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(frmPhieuXuat));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Close();

            btn_TaoTaiKhoan.Enabled = btn_DangXuat.Enabled = btn_NhanVien.Enabled = btn_VatTu.Enabled = btn_Kho.Enabled = btn_DatHang.Enabled = btn_PhieuNhap.Enabled = btn_PhieuXuat.Enabled = false;
            btn_DSNhanVien.Enabled = btn_DMVatTu.Enabled = btn_GiaTriHang.Enabled = btn_DDH.Enabled = btn_HoatDongNhanVien.Enabled = btn_TongHop.Enabled = false;
            btn_DangNhap.Enabled = true;
            tssl_MaNV.Text = "";
            tssl_HoTen.Text = "";
            tssl_Nhom.Text = "";
        }

        private void btn_DatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDatHang));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDatHang = new frmDatHang();
                Program.formDatHang.MdiParent = this;
                Program.formDatHang.Show();
            }
        }

        private void btn_PhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.formPhieuNhap = new frmPhieuNhap();
                Program.formPhieuNhap.MdiParent = this;
                Program.formPhieuNhap.Show();
            }
        }

        private void btn_PhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                Program.formPhieuXuat = new frmPhieuXuat();
                Program.formPhieuXuat.MdiParent = this;
                Program.formPhieuXuat.Show();
            }
        }

        private void btn_DMVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xprt_INDANHMUCVATTU rpDSVT = new Xprt_INDANHMUCVATTU();
            ReportPrintTool rpt = new ReportPrintTool(rpDSVT);
            rpDSVT.ShowPreviewDialog();
        }

        private void btn_DDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xprt_INDANHSACHDDH_CHUAPN rpDDH_PN = new Xprt_INDANHSACHDDH_CHUAPN();
            ReportPrintTool rpt = new ReportPrintTool(rpDDH_PN);
            rpDDH_PN.ShowPreviewDialog();
        }

        private void btn_DSNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.mGroup == "CONGTY")
            {
                Program.formChonChiNhanh = new frmChonChiNhanh();
                Program.formChonChiNhanh.Show();
                Program.frmChinh.Enabled = false;
            }
            else
            {
                Xprt_INDANHSACHNHANVIEN rpDSNV = new Xprt_INDANHSACHNHANVIEN();
                ReportPrintTool rpt = new ReportPrintTool(rpDSNV);
                rpDSNV.ShowPreviewDialog();
            }
        }

        private void btn_GiaTriHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.formCTTriGiaNhapXuat = new frmCTTriGiaNhapXuat();
            Program.formCTTriGiaNhapXuat.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_TongHop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.formTONGHOPNHAPXUAT = new frmTONGHOPNHAPXUAT();
            Program.formTONGHOPNHAPXUAT.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_HoatDongNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.formHOATDONGCUANHANVIEN = new frmHOATDONGCUANHANVIEN();
            Program.formHOATDONGCUANHANVIEN.Show();
            Program.frmChinh.Enabled = false;
        }
    }
}
