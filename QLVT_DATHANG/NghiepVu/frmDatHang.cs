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
    public partial class frmDatHang : Form
    {
        int vitri = 0;
        String temp = "";
        String button = "";

        public frmDatHang()
        {
            InitializeComponent();
        }

        private void DatHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.DATHANG' table. You can move, or remove it, as needed.
            this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DATHANGTableAdapter.Fill(this.DS.DATHANG);

            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            // TODO: This line of code loads data into the 'DS.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

            cbb_ChiNhanh.DataSource = Program.bds_dspm;
            cbb_ChiNhanh.DisplayMember = "TENCN";
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            cbb_ChiNhanh.SelectedItem = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
                cbb_ChiNhanh.Enabled = btn_Thoat.Enabled = true;
                cgDatHang.Enabled = cgCTDDH.Enabled = true;
                panelControl2.Enabled = panelControl3.Enabled = false;
            }
            else
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = true;
                cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                cgDatHang.Enabled = cgCTDDH.Enabled = true;
                panelControl2.Enabled = panelControl3.Enabled = false;
            }
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.DATHANGTableAdapter.Fill(this.DS.DATHANG);
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload đặt hàng và CT đặt hàng \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Reload_ItemClick(sender, e);
            bdsDatHang.CancelEdit(); //Bỏ qua các dữ liệu chưa lưu
            bdsCTDDH.CancelEdit();
            if (btn_Them.Enabled == false && panelControl2.Enabled == true && panelControl3.Enabled == false)
            {
                bdsDatHang.Position = vitri;
            }
            if (btn_Them.Enabled == false && panelControl2.Enabled == false && panelControl3.Enabled == true)
            {
                bdsCTDDH.Position = vitri;
            }

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = btn_ChuyenChiNhanh.Enabled = true;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = false;
            cgDatHang.Enabled = cgCTDDH.Enabled = true;
            panelControl2.Enabled = panelControl3.Enabled = false;
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Them";
            if (MessageBox.Show("Chọn Yes nếu muốn thêm Đơn đặt hàng \nChọn No nếu muốn thêm Chi tiết Đơn đặt hàng ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                temp = "DatHang";
                vitri = bdsDatHang.Position;
                panelControl2.Enabled = true;
                bdsDatHang.AddNew();
                txt_MaNV.Text = Program.username;
                dtp_Ngay.EditValue = "";

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                cgDatHang.Enabled = cgCTDDH.Enabled = panelControl3.Enabled = false;
            }
            else
            {
                temp = "CTDDH";
                vitri = bdsCTDDH.Position;
                panelControl3.Enabled = true;
                bdsCTDDH.AddNew();
                txt_DDH.Text = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MASODDH"].ToString();
                txt_DDH.Enabled = false;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                cgDatHang.Enabled = cgCTDDH.Enabled = panelControl2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.formDSKho = new frmDSKho("DatHang");
            Program.formDSKho.Show();
            Program.frmChinh.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.formDSVatTu = new frmDSVatTu("DatHang");
            Program.formDSVatTu.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "HieuChinh";
            if (MessageBox.Show("Chọn YES nếu muốn hiệu chỉnh Đơn đặt hàng \nChọn NO nếu muốn hiệu chỉnh Chi tiết đơn đặt hàng ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                temp = "DatHang";
                txt_MaSoDDH.Enabled = false;
                vitri = bdsDatHang.Position;
                panelControl2.Enabled = true;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                cgDatHang.Enabled = cgCTDDH.Enabled = panelControl3.Enabled = false;
            }
            else
            {
                temp = "CTDDH";
                txt_DDH.Enabled = false;
                txt_DDH.Text = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MASODDH"].ToString();
                txt_MaVT.Enabled = false;
                vitri = bdsCTDDH.Position;
                panelControl3.Enabled = true;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                cgDatHang.Enabled = cgCTDDH.Enabled = panelControl2.Enabled = false;
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tam = "";
            if (MessageBox.Show("Chọn YES nếu muốn xóa Đơn đặt hàng \nChọn NO nếu muốn xóa Chi tiết Đơn đặt hàng ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bdsPhieuNhap.Count + bdsCTDDH.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        tam = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MASODDH"].ToString();
                        bdsDatHang.RemoveCurrent();
                        this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.DATHANGTableAdapter.Update(this.DS.DATHANG);
                        MessageBox.Show("Xóa Đơn đặt hàng thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Xóa đơn đặt hàng \n" + ex.Message, "", MessageBoxButtons.OK);
                        this.DATHANGTableAdapter.Fill(this.DS.DATHANG);
                        bdsDatHang.Position = bdsDatHang.Find("MASODDH", tam);
                        return;
                    }
                }
            }
            else
            {
                if (bdsPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa chi tiết đơn đặt hàng này vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết đơn đặt hàng này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        tam = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MASODDH"].ToString();
                        bdsCTDDH.RemoveCurrent();
                        this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.CTDDHTableAdapter.Update(this.DS.CTDDH);
                        MessageBox.Show("Xóa chi tiết đơn đặt hàng thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Xóa chi tiết đơn đặt hàng \n" + ex.Message, "", MessageBoxButtons.OK);
                        this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
                        bdsCTDDH.Position = bdsCTDDH.Find("MASODDH", tam);
                        return;
                    }
                }
            }

            panelControl3.Enabled = panelControl2.Enabled = false;
            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = btn_PhucHoi.Enabled = true;
            btn_Ghi.Enabled = false;
            cgDatHang.Enabled = cgCTDDH.Enabled = true;
            if (bdsDatHang.Count == 0) btn_Xoa.Enabled = false;
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
                this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DATHANGTableAdapter.Fill(this.DS.DATHANG);
                this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
                this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);
            }
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(temp == "DatHang")
            {
                if (txt_MaSoDDH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã số đơn đặt hàng không được để trống", "", MessageBoxButtons.OK);
                    txt_MaSoDDH.Focus();
                    return;
                }
                if(dtp_Ngay.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày không được để trống", "", MessageBoxButtons.OK);
                    dtp_Ngay.Focus();
                    return;
                }
                if (txt_NhaCC.Text.Trim() == "")
                {
                    MessageBox.Show("Nhà cung cấp không được để trống", "", MessageBoxButtons.OK);
                    txt_NhaCC.Focus();
                    return;
                }
                if (txt_MaKho.Text.Trim() == "")
                {
                    MessageBox.Show("Mã kho không được để trống", "", MessageBoxButtons.OK);
                    txt_MaKho.Focus();
                    return;
                }
                if (button == "Them")
                {
                    String strLenh = "EXECUTE dbo.SP_CHECKMA N'" + txt_MaSoDDH.Text + "', N'MADDH'";
                    Program.ExecuteScalar(strLenh);

                    if (Program.kt == 0)
                    {
                        try
                        {
                            bdsDatHang.EndEdit();
                            bdsDatHang.ResetCurrentItem();
                            this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.DATHANGTableAdapter.Update(this.DS.DATHANG);

                            MessageBox.Show("Thêm đơn đặt hàng thành công");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi thêm đơn đặt hàng \n" + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                        btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                        cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                        cgCTDDH.Enabled = cgDatHang.Enabled = true;
                        panelControl2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Mã đơn đặt hàng đã tồn tại, vui lòng nhập mã khác");
                        txt_MaSoDDH.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        bdsDatHang.EndEdit();
                        bdsDatHang.ResetCurrentItem();
                        this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.DATHANGTableAdapter.Update(this.DS.DATHANG);

                        MessageBox.Show("Hiệu chỉnh đơn đặt hàng thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh đơn đặt hàng \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                    cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                    cgCTDDH.Enabled = cgDatHang.Enabled = true;
                    panelControl2.Enabled = false;
                    txt_MaSoDDH.Enabled = true;
                }
            }
            else if(temp == "CTDDH")
            {
                if (txt_DDH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã số đơn đặt hàng không được để trống", "", MessageBoxButtons.OK);
                    txt_DDH.Focus();
                    return;
                }
                if (txt_MaVT.Text.Trim() == "")
                {
                    MessageBox.Show("Mã vật tư không được để trống", "", MessageBoxButtons.OK);
                    txt_MaVT.Focus();
                    return;
                }
                if (txt_SoLuong.Text.Trim() == "")
                {
                    MessageBox.Show("Số lượng không được để trống", "", MessageBoxButtons.OK);
                    txt_SoLuong.Focus();
                    return;
                }
                if (txt_DonGia.Text.Trim() == "")
                {
                    MessageBox.Show("Đơn giá không được để trống", "", MessageBoxButtons.OK);
                    txt_DonGia.Focus();
                    return;
                }
                if (button == "Them")
                {
                    try
                    {
                        bdsCTDDH.EndEdit();
                        bdsCTDDH.ResetCurrentItem();
                        this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.CTDDHTableAdapter.Update(this.DS.CTDDH);

                        MessageBox.Show("Thêm chi tiết đơn đặt hàng thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm chi tiết đơn đặt hàng \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                    cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                    cgCTDDH.Enabled = cgDatHang.Enabled = true;
                    panelControl3.Enabled = false;
                    txt_DDH.Enabled = true;
                }
                else
                {
                    try
                    {
                        bdsCTDDH.EndEdit();
                        bdsCTDDH.ResetCurrentItem();
                        this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.CTDDHTableAdapter.Update(this.DS.CTDDH);

                        MessageBox.Show("Hiệu chỉnh chi tiết đơn đặt hàng thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh chi tiết đơn đặt hàng \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                    cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                    cgCTDDH.Enabled = cgDatHang.Enabled = true;
                    panelControl3.Enabled = false;
                    txt_DDH.Enabled = true;
                }
            }
        }
    }
}
