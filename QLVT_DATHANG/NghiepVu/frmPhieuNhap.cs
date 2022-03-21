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
    public partial class frmPhieuNhap : Form
    {
        String macn = "";
        int vitri = 0;
        String button = "";
        String temp = "";
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void dATHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.DATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DATHANGTableAdapter.Fill(this.DS.DATHANG);

            this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);

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
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Thoat.Enabled = true;
                cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
            }

            groupControl1.Enabled = false;
            groupControl2.Enabled = false;

        }

        private void cTDDHBindingSource_CurrentChanged(object sender, EventArgs e)
        {

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

                this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);

                this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

                this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPNTableAdapter.Fill(this.DS.CTPN);
            }
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.DATHANGTableAdapter.Fill(this.DS.DATHANG);
                this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);
                this.CTPNTableAdapter.Fill(this.DS.CTPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload phiếu nhập \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhieuNhap.CancelEdit();
            bdsCTPN.CancelEdit();
            bdsDatHang.Position = vitri;
            if (btn_Them.Enabled == false && groupControl1.Enabled == true && groupControl2.Enabled == false)
            {
                bdsPhieuNhap.Position = vitri;
            }
            if (btn_Them.Enabled == false && groupControl1.Enabled == false && groupControl2.Enabled == true)
            {
                bdsCTPN.Position = vitri;
            }

            if (btn_Them.Enabled == false)
            {
                bdsPhieuNhap.Position = vitri;
                bdsCTPN.Position = vitri;
            }
            btn_Them.Enabled = btn_Xoa.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Ghi.Enabled = false;
            gcPhieuNhap.Enabled = gcCTPN.Enabled = true;
            groupControl1.Enabled = groupControl2.Enabled = false;
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tam = "";
            if (MessageBox.Show("Chọn YES nếu muốn xóa Phiếu nhập \nChọn NO nếu muốn xóa Chi tiết phiếu nhập ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bdsCTPN.Count > 0)
                {
                    MessageBox.Show("Không thể xóa phiếu nhập này!", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        tam = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position])["MAPN"].ToString();
                        bdsPhieuNhap.RemoveCurrent();
                        this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.PHIEUNHAPTableAdapter.Update(this.DS.PHIEUNHAP);
                        MessageBox.Show("Xóa phiếu nhập thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phiếu nhập! \n" + ex.Message, "", MessageBoxButtons.OK);
                        this.PHIEUNHAPTableAdapter.Fill(this.DS.PHIEUNHAP);
                        bdsPhieuNhap.Position = bdsPhieuNhap.Find("MAPN", tam);
                        return;
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết phiếu nhập này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        tam = ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAPN"].ToString();
                        bdsCTPN.RemoveCurrent();
                        this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.CTPNTableAdapter.Update(this.DS.CTPN);
                        MessageBox.Show("Xóa chi tiết phiếu nhập thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa chi tiết phiếu nhập! \n" + ex.Message, "", MessageBoxButtons.OK);
                        this.CTPNTableAdapter.Fill(this.DS.CTPN);
                        bdsCTPN.Position = bdsCTPN.Find("MAPN", tam);
                        return;
                    }
                }
            }

            groupControl1.Enabled = groupControl2.Enabled = false;
            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = btn_PhucHoi.Enabled = true;
            btn_Ghi.Enabled = false;
            gcPhieuNhap.Enabled = gcCTPN.Enabled = true;
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "HieuChinh";
            if (MessageBox.Show("Chọn YES nếu muốn hiệu chỉnh Phiếu nhập \nChọn NO nếu muốn hiệu chỉnh Chi tiết phiếu nhập ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                temp = "PhieuNhap";
                txt_MaPN_PN.Enabled = false;
                vitri = bdsPhieuNhap.Position;
                groupControl1.Enabled = true;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                gcPhieuNhap.Enabled = gcCTPN.Enabled = groupControl2.Enabled = false;
                txt_MaKho.Enabled = false;
                txtMaNV.Enabled = false;
                txtMaSoDDH.Enabled = false;
            }
            else
            {
                temp = "CTPN";
                txt_MaPN_CTPN.Enabled = false;
                txt_MaVT.Enabled = false;
                txt_MaPN_CTPN.Text = ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAPN"].ToString();
                vitri = bdsCTPN.Position;
                groupControl2.Enabled = true;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_Thoat.Enabled = false;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
                gcPhieuNhap.Enabled = gcCTPN.Enabled = groupControl1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.formDSKho = new frmDSKho("PhieuNhap");
            Program.formDSKho.Show();
            Program.frmChinh.Enabled = false;
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            Program.formDSVatTu = new frmDSVatTu("CTPN");
            Program.formDSVatTu.Show();
            Program.frmChinh.Enabled = false;
        }*/

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (temp == "PhieuNhap")
            {
                if (txt_Ngay.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày không được để trống", "", MessageBoxButtons.OK);
                    txt_Ngay.Focus();
                    return;
                }
                if (txtMaSoDDH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã số đơn đặt hàng không được để trống", "", MessageBoxButtons.OK);
                    txtMaSoDDH.Focus();
                    return;
                }
                try
                {
                    bdsPhieuNhap.EndEdit();
                    bdsPhieuNhap.ResetCurrentItem();
                    this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PHIEUNHAPTableAdapter.Update(this.DS.PHIEUNHAP);

                    MessageBox.Show("Hiệu chỉnh phiếu nhập thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hiệu chỉnh phiếu nhập \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                gcPhieuNhap.Enabled = gcCTPN.Enabled = true;
                groupControl1.Enabled = false;
            }
            else if (temp == "CTPN")
            {
                int sLBD = int.Parse(((DataRowView)bdsCTPN[bdsCTPN.Position])["SOLUONG"].ToString());
                if (txt_SoLuong.Text.Trim() == "")
                {
                    MessageBox.Show("Số lượng không được để trống!", "", MessageBoxButtons.OK);
                    txt_SoLuong.Focus();
                    return;
                }
                if (int.Parse(txt_SoLuong.Text.Trim()) > sLBD)
                {
                    MessageBox.Show("Số lượng thay đổi không được lớn hơn số lượng ban đầu!", "", MessageBoxButtons.OK);
                    txt_SoLuong.Focus();
                    return;
                }
                if (txt_DonGia.Text.Trim() == "")
                {
                    MessageBox.Show("Đơn giá không được để trống!", "", MessageBoxButtons.OK);
                    txt_DonGia.Focus();
                    return;
                }
                try
                {
                    bdsCTPN.EndEdit();
                    bdsCTPN.ResetCurrentItem();
                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.DS.CTPN);

                    MessageBox.Show("Hiệu chỉnh Chi tiết phiếu nhập thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hiệu chỉnh Chi tiết phiếu nhập \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Thoat.Enabled = true;
                cbb_ChiNhanh.Enabled = btn_Ghi.Enabled = false;
                gcCTPN.Enabled = gcPhieuNhap.Enabled = true;
                groupControl2.Enabled = false;
            }
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String t = "";
            String strLenh = "EXECUTE dbo.SP_CHECKMA N'" + ((DataRowView)bdsDatHang[bdsDatHang.Position])["MASODDH"].ToString() + "', PN_DDH";
            Program.ExecuteScalar(strLenh);
            if (Program.kt != 0)
            {
                MessageBox.Show("Không thể thêm vì đã lập đơn đặt hàng!");
                return;
            }
            else
            {
                bdsPhieuNhap.AddNew();
                //Nhập mã phiếu nhập
                frmNhapMaPN m = new frmNhapMaPN();
                m.ShowDialog();
                strLenh = "EXECUTE dbo.SP_CHECKMA N'" + txt_MaPN_PN.Text + "', MAPN";
                Program.ExecuteScalar(strLenh);
                if (Program.kt != 0)
                {
                    MessageBox.Show("Không thể thêm vì mã phiếu nhập này đã tồn tại!");
                    btn_Reload_ItemClick(sender, e);
                }
                else
                {
                    t = txt_MaPN_PN.Text;
                    /*txt_Ngay.Text = ((DataRowView)bdsDatHang[bdsDatHang.Position])["NGAY"].ToString();*/
                    DateTime now = DateTime.Now;
                    txt_Ngay.Text = now.ToString();
                    txtMaSoDDH.Text = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MASODDH"].ToString();
                    txtMaNV.Text = Program.username;
                    txt_MaKho.Text = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MAKHO"].ToString();
                    try
                    {

                        bdsPhieuNhap.EndEdit();
                        bdsPhieuNhap.ResetCurrentItem();
                        this.PHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.PHIEUNHAPTableAdapter.Update(this.DS.PHIEUNHAP);
                        //MessageBox.Show("Thêm phiếu nhập thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi phiếu nhập \n" + ex.Message, "", MessageBoxButtons.OK);
                        btn_Reload_ItemClick(sender, e);
                        return;
                    }


                    //Thêm chi tiết phiếu nhập
                    for (int i = 0; i < (bdsCTDDH.Count); i++)
                    {
                        bdsCTPN.AddNew();
                        txt_MaPN_CTPN.Text = t;
                        txt_MaVT.Text = ((DataRowView)bdsCTDDH[i])["MAVT"].ToString();
                        txt_SoLuong.Text = ((DataRowView)bdsCTDDH[i])["SOLUONG"].ToString();
                        txt_DonGia.Text = ((DataRowView)bdsCTDDH[i])["DONGIA"].ToString();
                        try
                        {

                            bdsCTPN.EndEdit();
                            bdsCTPN.ResetCurrentItem();
                            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.CTPNTableAdapter.Update(this.DS.CTPN);
                            //MessageBox.Show("Thêm chi tiết phiếu nhập thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi chi tiết phiếu nhập \n" + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }

                    }
                }
                MessageBox.Show("Thêm phiếu nhập thành công!");
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Xoa.Enabled = btn_PhucHoi.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
                btn_Ghi.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Program.formDSVatTu = new frmDSVatTu("CTPN");
            Program.formDSVatTu.Show();
            Program.frmChinh.Enabled = false;
        }
    }
}
