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
    public partial class frmVatTu : Form
    {
        int vitri = 0;
        String button = "";
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void vATTUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VATTUTableAdapter.Fill(this.DS.VATTU);

            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);

            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);

            if (Program.mGroup == "CONGTY")
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_ChuyenChiNhanh.Enabled = false;
                btn_Thoat.Enabled = true;
            }
            else
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_ChuyenChiNhanh.Enabled = true;
                btn_Ghi.Enabled = false;
            }

            groupControl1.Enabled = false;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Reload_ItemClick(sender, e);
            bdsVatTu.CancelEdit();
            if (btn_Them.Enabled == false) bdsVatTu.Position = vitri;
            groupControl1.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = btn_ChuyenChiNhanh.Enabled = true;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = false;
            gcVatTu.Enabled = true;
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVatTu.Position;
            groupControl1.Enabled = true;
            bdsVatTu.AddNew();

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = btn_ChuyenChiNhanh.Enabled = false;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = true;
            gcVatTu.Enabled = false;

            button = "Them";
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVatTu.Position;
            groupControl1.Enabled = true;
            txtMaVT.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = btn_ChuyenChiNhanh.Enabled = false;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = true;
            gcVatTu.Enabled = false;

            button = "HieuChinh";
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaVT.Text.Trim() == "" || txtMaVT.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã vật tư không được để trống và không quá 4 ký tự!", "", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return;
            }
            if (txtTenVT.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được để trống", "", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return;
            }
            if (txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống", "", MessageBoxButtons.OK);
                txtDVT.Focus();
                return;
            }
            if (txtSoLuongTon.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng tồn không được để trống", "", MessageBoxButtons.OK);
                txtSoLuongTon.Focus();
                return;
            }
            if(int.Parse(txtSoLuongTon.Text) < 0)
            {
                MessageBox.Show("Số lượng tồn phải lớn hơn 0", "", MessageBoxButtons.OK);
                txtSoLuongTon.Focus();
                return;
            }

            if (button == "Them")
            {
                String strLenh = "EXECUTE dbo.SP_CHECKMA N'" + txtMaVT.Text + "', 'MAVT'";
                Program.ExecuteScalar(strLenh);

                if (Program.kt == 0)
                {
                    try
                    {
                        bdsVatTu.EndEdit();
                        bdsVatTu.ResetCurrentItem();
                        this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.VATTUTableAdapter.Update(this.DS.VATTU);

                        MessageBox.Show("Thêm vật tư thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi vật tư \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                    btn_Ghi.Enabled = false;
                    gcVatTu.Enabled = true;
                    groupControl1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Mã vật tư đã tồn tại, vui lòng nhập mã khác!");
                    txtMaVT.Focus();
                    return;
                }
            } 
            else
            {
                try
                {
                    bdsVatTu.EndEdit();
                    bdsVatTu.ResetCurrentItem();
                    this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.VATTUTableAdapter.Update(this.DS.VATTU);

                    MessageBox.Show("Hiệu chỉnh vật tư thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi vật tư \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
                btn_Ghi.Enabled = false;
                gcVatTu.Enabled = true;
                groupControl1.Enabled = false;
                txtMaVT.Enabled = true;
            }    
                
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maVT = "";
            if (bdsVatTu.Count == 0)
            {
                return;
            }
            else
            {
                if (bdsCTDDH.Count > 0)
                {
                    MessageBox.Show("Không thể xóa vì vật tư này đã nhập hàng!", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsCTPN.Count > 0)
                {
                    MessageBox.Show("Không thể xóa vì vật tư này đã nằm trong Chi tiết phiếu nhập!", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsCTPX.Count > 0)
                {
                    MessageBox.Show("Không thể xóa vì vật tư này đã nằm trong Chi tiết phiếu xuất!", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        maVT = ((DataRowView)bdsVatTu[bdsVatTu.Position])["MAVT"].ToString();
                        bdsVatTu.RemoveCurrent();
                        this.VATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.VATTUTableAdapter.Update(this.DS.VATTU);
                        MessageBox.Show("Xóa vật tư thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Xóa vật tư \n" + ex.Message, "", MessageBoxButtons.OK);
                        this.VATTUTableAdapter.Fill(this.DS.VATTU);
                        bdsVatTu.Position = bdsVatTu.Find("MAVT", maVT);
                        return;
                    }
                }
            }
            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_ChuyenChiNhanh.Enabled = btn_Reload.Enabled = true;
            btn_Ghi.Enabled = false;
            gcVatTu.Enabled = true;
            groupControl1.Enabled = false;
            if (bdsVatTu.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.VATTUTableAdapter.Fill(this.DS.VATTU);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới vật tư! \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
