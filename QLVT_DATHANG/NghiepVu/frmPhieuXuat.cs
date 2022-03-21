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
    public partial class frmPhieuXuat : Form
    {
        int vitri = 0;
        String temp = "";
        String button = "";

        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void pHIEUXUATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuXuat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.PHIEUXUAT' table. You can move, or remove it, as needed.
            this.PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUXUATTableAdapter.Fill(this.DS.PHIEUXUAT);

            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);

            cbb_ChiNhanh.DataSource = Program.bds_dspm;
            cbb_ChiNhanh.DisplayMember = "TENCN";
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            cbb_ChiNhanh.SelectedItem = Program.mChinhanh;


            if (Program.mGroup == "CONGTY")
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
                cbb_ChiNhanh.Enabled = btn_Thoat.Enabled = true;
                cgPhieuXuat.Enabled = cgCTPX.Enabled = true;
                panelControl2.Enabled = panelControl3.Enabled = false;
            }
            else
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = true;
                cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                cgPhieuXuat.Enabled = cgCTPX.Enabled = true;
                panelControl2.Enabled = panelControl3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.formDSKho = new frmDSKho("PhieuXuat");
            Program.formDSKho.Show();
            Program.frmChinh.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.formDSVatTu = new frmDSVatTu("PhieuXuat");
            Program.formDSVatTu.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.PHIEUXUATTableAdapter.Fill(this.DS.PHIEUXUAT);
                this.CTPXTableAdapter.Fill(this.DS.CTPX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload phiếu xuất \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Reload_ItemClick(sender, e);
            bdsPhieuXuat.CancelEdit(); //Bỏ qua các dữ liệu chưa lưu
            bdsCTPX.CancelEdit();
            if (btn_Them.Enabled == false && panelControl2.Enabled == true && panelControl3.Enabled == false)
            {
                bdsPhieuXuat.Position = vitri;
            }
            if (btn_Them.Enabled == false && panelControl2.Enabled == false && panelControl3.Enabled == true)
            {
                bdsCTPX.Position = vitri;
            }

            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = btn_ChuyenChiNhanh.Enabled = true;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = false;
            cgPhieuXuat.Enabled = cgCTPX.Enabled = true;
            panelControl2.Enabled = panelControl3.Enabled = false;
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Them";
            if (MessageBox.Show("Chọn YES nếu muốn thêm Phiếu xuât \nChọn NO nếu muốn thêm Chi tiết Phiếu Xuất ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                temp = "PhieuXuat";
                vitri = bdsPhieuXuat.Position;
                panelControl2.Enabled = true;
                bdsPhieuXuat.AddNew();
                txt_MaNV.Text = Program.username;
                dtp_Ngay.EditValue = "";

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                cgPhieuXuat.Enabled = cgCTPX.Enabled = panelControl3.Enabled = false;
            }
            else
            {
                temp = "CTPX";
                vitri = bdsCTPX.Position;
                panelControl3.Enabled = true;
                bdsCTPX.AddNew();
                txt_PX.Text = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position])["MAPX"].ToString();
                txt_PX.Enabled = false;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                cgPhieuXuat.Enabled = cgCTPX.Enabled = panelControl2.Enabled = false;
            }
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "HieuChinh";
            if (MessageBox.Show("Chọn YES nếu muốn hiệu chỉnh Phiếu xuất \nChọn NO nếu muốn hiệu chỉnh Chi tiết Phiếu xuất ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                temp = "PhieuXuat";
                txt_MaPX.Enabled = false;
                vitri = bdsPhieuXuat.Position;
                panelControl2.Enabled = true;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                cgPhieuXuat.Enabled = cgCTPX.Enabled = panelControl3.Enabled = false;
            }
            else
            {
                temp = "CTPX";
                txt_PX.Enabled = false;
                txt_PX.Text = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position])["MAPX"].ToString();
                txt_MaVT.Enabled = false;
                vitri = bdsCTPX.Position;
                panelControl3.Enabled = true;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                cgPhieuXuat.Enabled = cgCTPX.Enabled = panelControl2.Enabled = false;
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tam = "";
            if (MessageBox.Show("Chọn YES nếu muốn xóa Phiếu xuất \nChọn NO nếu muốn xóa Chi tiết Phiếu xuất ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bdsCTPX.Count > 0)
                {
                    MessageBox.Show("Không thể xóa phiếu xuất này", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu xuất này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        tam = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position])["MAPX"].ToString();
                        bdsPhieuXuat.RemoveCurrent();
                        this.PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.PHIEUXUATTableAdapter.Update(this.DS.PHIEUXUAT);
                        MessageBox.Show("Xóa phiếu xuất thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phiếu xuất \n" + ex.Message, "", MessageBoxButtons.OK);
                        this.PHIEUXUATTableAdapter.Fill(this.DS.PHIEUXUAT);
                        bdsPhieuXuat.Position = bdsPhieuXuat.Find("MAPX", tam);
                        return;
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết phiếu xuất này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        tam = ((DataRowView)bdsCTPX[bdsCTPX.Position])["MAPX"].ToString();
                        bdsCTPX.RemoveCurrent();
                        this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.CTPXTableAdapter.Update(this.DS.CTPX);
                        MessageBox.Show("Xóa chi tiết phiếu xuất thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa chi tiết phiếu xuất \n" + ex.Message, "", MessageBoxButtons.OK);
                        this.CTPXTableAdapter.Fill(this.DS.CTPX);
                        bdsCTPX.Position = bdsCTPX.Find("MAPX", tam);
                        return;
                    }
                }
            }

            panelControl3.Enabled = panelControl2.Enabled = false;
            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = btn_PhucHoi.Enabled = true;
            btn_Ghi.Enabled = false;
            cgPhieuXuat.Enabled = cgCTPX.Enabled = true;
            if (bdsPhieuXuat.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (temp == "PhieuXuat")
            {
                if (txt_MaPX.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phiếu xuất không được để trống", "", MessageBoxButtons.OK);
                    txt_MaPX.Focus();
                    return;
                }
                if (dtp_Ngay.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày không được để trống", "", MessageBoxButtons.OK);
                    dtp_Ngay.Focus();
                    return;
                }
                if (txt_HoTen.Text.Trim() == "")
                {
                    MessageBox.Show("Họ tên khách hàng không được để trống", "", MessageBoxButtons.OK);
                    txt_HoTen.Focus();
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
                    String strLenh = "EXECUTE dbo.SP_CHECKMA N'" + txt_MaPX.Text + "', N'MAPX'";
                    Program.ExecuteScalar(strLenh);

                    if (Program.kt == 0)
                    {
                        try
                        {
                            bdsPhieuXuat.EndEdit();
                            bdsPhieuXuat.ResetCurrentItem();
                            this.PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.PHIEUXUATTableAdapter.Update(this.DS.PHIEUXUAT);

                            MessageBox.Show("Thêm phiếu xuất thành công");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi thêm phiếu xuất \n" + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                        btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                        cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                        cgCTPX.Enabled = cgPhieuXuat.Enabled = true;
                        panelControl2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Mã phiếu xuất đã tồn tại, vui lòng nhập mã khác");
                        txt_MaPX.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        bdsPhieuXuat.EndEdit();
                        bdsPhieuXuat.ResetCurrentItem();
                        this.PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.PHIEUXUATTableAdapter.Update(this.DS.PHIEUXUAT);

                        MessageBox.Show("Hiệu chỉnh phiếu xuất thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh phiếu xuất \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                    cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                    cgCTPX.Enabled = cgPhieuXuat.Enabled = true;
                    panelControl2.Enabled = false;
                    txt_MaPX.Enabled = true;
                    txt_MaPX.Enabled = true;
                }
            }
            else if(temp == "CTPX")
            {
                if (txt_PX.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phiếu xuất không được để trống", "", MessageBoxButtons.OK);
                    txt_PX.Focus();
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
                        bdsCTPX.EndEdit();
                        bdsCTPX.ResetCurrentItem();
                        this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.CTPXTableAdapter.Update(this.DS.CTPX);

                        MessageBox.Show("Thêm chi tiết phiếu xuất thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm chi tiết phiếu xuất \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                    cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                    cgCTPX.Enabled = cgPhieuXuat.Enabled = true;
                    panelControl3.Enabled = false;
                    txt_PX.Enabled = true;
                }
                else
                {
                    try
                    {
                        bdsCTPX.EndEdit();
                        bdsCTPX.ResetCurrentItem();
                        this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.CTPXTableAdapter.Update(this.DS.CTPX);

                        MessageBox.Show("Hiệu chỉnh Chi tiết phiếu xuất thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh chi tiết phiếu xuất \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                    cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                    cgCTPX.Enabled = cgPhieuXuat.Enabled = true;
                    panelControl3.Enabled = false;
                    txt_PX.Enabled = true;
                }
            }
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
                this.PHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUXUATTableAdapter.Fill(this.DS.PHIEUXUAT);
                this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPXTableAdapter.Fill(this.DS.CTPX);
            }
        }
    }
}
