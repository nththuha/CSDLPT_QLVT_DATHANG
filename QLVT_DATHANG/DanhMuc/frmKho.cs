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
    public partial class frmKho : Form
    {
        String macn = "";
        int vitri = 0;
        String button = "";
        public frmKho()
        {
            InitializeComponent();
        }

        private void kHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOTableAdapter.Fill(this.DS.KHO);

            this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DATHANGTableAdapter.Fill(this.DS.DATHANG);

            this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

            this.PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUXUATTableAdapter.Fill(this.DS.PHIEUXUAT);

            macn = Program.maChiNhanh;

            cbb_ChiNhanh.DataSource = Program.bds_dspm;
            cbb_ChiNhanh.DisplayMember = "TENCN";
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            cbb_ChiNhanh.SelectedItem = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
                cbb_ChiNhanh.Enabled = btn_Thoat.Enabled = true;
            }
            else
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = true;
                cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
            }
            gcKho.Enabled = true;
            groupControl1.Enabled = false;
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
                this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOTableAdapter.Fill(this.DS.KHO);
                this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DATHANGTableAdapter.Fill(this.DS.DATHANG);
                this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);
                this.PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUXUATTableAdapter.Fill(this.DS.PHIEUXUAT);
            }
        }

        private void mACNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.KHOTableAdapter.Fill(this.DS.KHO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới kho! \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Reload_ItemClick(sender, e);
            bdsKho.CancelEdit();
            if (btn_Them.Enabled == false) bdsKho.Position = vitri;
            gcKho.Enabled = true;
            groupControl1.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = false;

        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            groupControl1.Enabled = true;
            bdsKho.AddNew();
            txtMaChiNhanh.Text = macn;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = false;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = true;
            gcKho.Enabled = false;
            txtMaChiNhanh.Enabled = false;
            txtMaKho.Enabled = true;

            button = "Them";
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            groupControl1.Enabled = true;
            txtMaKho.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = false;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = true;
            gcKho.Enabled = false;
            txtMaChiNhanh.Enabled = false;

            button = "HieuChinh";
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maKho = "";
            if (bdsDatHang.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho này vì đã có trong Đặt hàng!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho này vì đã có trong Phiếu nhập!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho này vì đã có trong Phiếu xuất!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa kho này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maKho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
                    bdsKho.RemoveCurrent();
                    this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHOTableAdapter.Update(this.DS.KHO);
                    MessageBox.Show("Xóa kho thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa kho \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.KHOTableAdapter.Fill(this.DS.KHO);
                    bdsKho.Position = bdsKho.Find("MAKHO", maKho);
                    return;
                }
            }
            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = true;
            cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
            gcKho.Enabled = true;
            groupControl1.Enabled = false;
            if (bdsKho.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKho.Text.Trim() == "" || txtMaKho.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã kho không được để trống và không được quá 4 ký tự!", "", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return;
            }
            if (txtTenKho.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được để trống!", "", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ của kho không được để trống!", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }

            if (button == "Them")
            {
                String strLenh = "EXECUTE dbo.SP_CHECKMA N'" + txtMaKho.Text + "', MAKHO";
                Program.ExecuteScalar(strLenh);

                if (Program.kt == 0)
                {
                    strLenh = "EXECUTE dbo.SP_CHECKMA N'" + txtTenKho.Text + "', TENKHO";
                    Program.ExecuteScalar(strLenh);
                    if (Program.kt == 0)
                    {
                        try
                        {
                            bdsKho.EndEdit();
                            bdsKho.ResetCurrentItem();
                            this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.KHOTableAdapter.Update(this.DS.KHO);

                            MessageBox.Show("Thêm kho thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi kho \n" + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                        btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                        cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                        gcKho.Enabled = true;
                        groupControl1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Tên kho đã tồn tại, vui lòng nhập tên khác!");
                        txtMaKho.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mã kho đã tồn tại, vui lòng nhập mã khác!");
                    txtMaKho.Focus();
                    return;
                }
            }
            else
            {
                try
                {
                    bdsKho.EndEdit();
                    bdsKho.ResetCurrentItem();
                    this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHOTableAdapter.Update(this.DS.KHO);

                    MessageBox.Show("Hiệu chỉnh kho thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi kho \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                gcKho.Enabled = true;
                groupControl1.Enabled = false;
                txtMaKho.Enabled = true;
            }
        }
    }
}
