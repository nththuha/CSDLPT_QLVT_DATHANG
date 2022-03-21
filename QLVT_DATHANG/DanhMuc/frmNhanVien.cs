using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class frmNhanVien : Form
    {
        String macn = "";
        int vitri = 0;
        String button = "";

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

            // TODO: This line of code loads data into the 'DS.DATHANG' table. You can move, or remove it, as needed.
            this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DATHANGTableAdapter.Fill(this.DS.DATHANG);

            // TODO: This line of code loads data into the 'DS.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

            // TODO: This line of code loads data into the 'DS.PHIEUXUAT' table. You can move, or remove it, as needed.
            this.PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUXUATTableAdapter.Fill(this.DS.PHIEUXUAT);

            macn = Program.maChiNhanh;

            cbb_ChiNhanh.DataSource = Program.bds_dspm;
            cbb_ChiNhanh.DisplayMember = "TENCN";
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            cbb_ChiNhanh.SelectedItem = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_ChuyenChiNhanh.Enabled = false;
                cbb_ChiNhanh.Enabled = btn_Thoat.Enabled = true;
            }
            else
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_ChuyenChiNhanh.Enabled = btn_Thoat.Enabled = true;
                cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
            }
            cgNhanVien.Enabled = true;
            panelControl2.Enabled = false;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNhanVien.Position;
            panelControl2.Enabled = true;
            bdsNhanVien.AddNew();
            txt_MaCN.Text = macn;
            dtp_NgaySinh.EditValue = "";
            txt_TrangThaiXoa.Text = "0";
            txt_MaNV.Enabled = true;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = btn_ChuyenChiNhanh.Enabled = false;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = true;
            cgNhanVien.Enabled = false;

            button = "Them";
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhanVien.CancelEdit();
            if (btn_Them.Enabled == false) bdsNhanVien.Position = vitri;
            btn_Reload_ItemClick(sender, e);
            cgNhanVien.Enabled = true;
            panelControl2.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled =  btn_ChuyenChiNhanh.Enabled = true;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = false;
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNhanVien.Position;
            panelControl2.Enabled = true;
            txt_MaNV.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = btn_ChuyenChiNhanh.Enabled = false;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = true;
            cgNhanVien.Enabled = false;

            button = "HieuChinh";
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int manv = 0;
            if(bdsDatHang.Count + bdsPhieuNhap.Count + bdsPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString());
                    bdsNhanVien.RemoveCurrent();
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.DS.NHANVIEN);

                    String strLenh = "EXECUTE dbo.SP_XOATAIKHOAN " + manv;
                    Program.Execute(strLenh);
                    if(Program.kt == 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                    }                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                    bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_ChuyenChiNhanh.Enabled = btn_Reload.Enabled = true;
            cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
            cgNhanVien.Enabled = true;
            panelControl2.Enabled = false;
            if (bdsNhanVien.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txt_MaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "", MessageBoxButtons.OK);
                txt_MaNV.Focus();
                return;
            }
            if (txt_Ho.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống", "", MessageBoxButtons.OK);
                txt_Ho.Focus();
                return;
            }
            if (txt_Ten.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống", "", MessageBoxButtons.OK);
                txt_Ten.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống", "", MessageBoxButtons.OK);
                txt_DiaChi.Focus();
                return;
            }
            if (dtp_NgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh nhân viên không được để trống", "", MessageBoxButtons.OK);
                dtp_NgaySinh.Focus();
                return;
            }
            if (txt_Luong.Text.Trim() == "")
            {
                MessageBox.Show("Lương nhân viên không được để trống", "", MessageBoxButtons.OK);
                txt_Luong.Focus();
                return;
            }

            if(button == "Them")
            {
                String strLenh = "EXECUTE dbo.SP_CHECKMA N'" + txt_MaNV.Text + "', N'MANV'";
                Program.ExecuteScalar(strLenh);

                if (Program.kt == 0)
                {
                    try
                    {
                        bdsNhanVien.EndEdit();
                        bdsNhanVien.ResetCurrentItem();
                        this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.NHANVIENTableAdapter.Update(this.DS.NHANVIEN);

                        MessageBox.Show("Thêm nhân viên thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_ChuyenChiNhanh.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                    cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                    cgNhanVien.Enabled = true;
                    panelControl2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã khác");
                    txt_MaNV.Focus();
                    return;
                }
            }
            else
            {
                try
                {
                    bdsNhanVien.EndEdit();
                    bdsNhanVien.ResetCurrentItem();
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.DS.NHANVIEN);

                    MessageBox.Show("Hiệu chỉnh nhân viên thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hiệu chỉnh nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_ChuyenChiNhanh.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                cgNhanVien.Enabled = true;
                panelControl2.Enabled = false;
                txt_MaNV.Enabled = true;
            }
        }

        private void btn_ChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*int maNV = 0;
            String maCN = "";
            int trangThaiXoa = int.Parse(((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TrangThaiXoa"].ToString());
            if(trangThaiXoa == 1)
            {
                MessageBox.Show("Nhân viên hiện không có ở chi nhánh này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(MessageBox.Show("Bạn có thật sự muốn chuyển chi nhánh cho nhân viên này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    String strLenh = "EXECUTE [dbo].[MANVLONNHAT]";
                    Program.ExecuteScalar(strLenh);
                    maNV = Program.kt + 1;
                    txt_TrangThaiXoa.Text = "1";
                    bdsNhanVien.EndEdit();
                    bdsNhanVien.ResetCurrentItem();
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.DS.NHANVIEN);

                    if (cbb_ChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;

                    if (Program.maChiNhanh == "CN1")
                    {
                        Program.servername = "NTHTHUHA";
                        maCN = "CN2";
                    }
                    else 
                    {
                        Program.servername = "NTHTHUHA\\SERVER1";
                        maCN = "CN1";
                    }

                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;

                    if (Program.KetNoi() == 0)
                    {
                        MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        strLenh = "INSERT INTO NHANVIEN (" + maNV + ", N'" + txt_Ho.Text + "', N'" + txt_Ten.Text + "', N'" + txt_DiaChi.Text + "', " + dtp_NgaySinh.Text + ", " + txt_Luong.Text + ", 0, N'" + maCN + "')";
                        SqlDataReader myreader = Program.ExecSqlDataReader(strLenh);

                        if (Program.maChiNhanh == "CN1") Program.servername = "NTHTHUHA\\SERVER1";
                        else Program.servername = "NTHTHUHA\\SERVER2";

                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN; ;
                    }
                }
            }*/
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
            else
            {
                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DATHANGTableAdapter.Fill(this.DS.DATHANG);
                this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);
                this.PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUXUATTableAdapter.Fill(this.DS.PHIEUXUAT);
                //macn = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            }
        }
    }
}
