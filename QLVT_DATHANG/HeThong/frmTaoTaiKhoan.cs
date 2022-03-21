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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.HOTENNV' table. You can move, or remove it, as needed.
            this.HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOTENNVTableAdapter.Fill(this.DS.HOTENNV);

            cbb_ChiNhanh.DataSource = Program.bds_dspm;
            cbb_ChiNhanh.DisplayMember = "TENCN";
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            cbb_ChiNhanh.SelectedItem = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                cbb_Quyen.Items.Add("CONGTY");
                cbb_Quyen.SelectedIndex = 0;
                cbb_Quyen.Enabled = false;
                cbb_ChiNhanh.Enabled = true;
            }
            else
            {
                cbb_ChiNhanh.Enabled = false;
                cbb_Quyen.Items.Add("CHINHANH");
                cbb_Quyen.Items.Add("USER");
                cbb_Quyen.SelectedIndex = 0;
            }
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.DS);
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
                this.HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOTENNVTableAdapter.Fill(this.DS.HOTENNV);
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "", MessageBoxButtons.OK);
                txt_TenDangNhap.Focus();
                return;
            }
            if (txt_MatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "", MessageBoxButtons.OK);
                txt_MatKhau.Focus();
                return;
            }

            Program.mChinhanh = cbb_ChiNhanh.SelectedIndex;
            if (Program.KetNoi() == 0) return;

            String strLenh = "EXECUTE dbo.SP_TAOTAIKHOAN N'" + txt_TenDangNhap.Text + "', N'" + txt_MatKhau.Text + "', N'" + cbb_HoTenNV.SelectedValue.ToString() + "', N'" + cbb_Quyen.SelectedItem + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            MessageBox.Show("Tạo tài khoản thành công " + Program.mlogin, " ", MessageBoxButtons.OK);

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            Program.myReader.Close();
            Program.conn.Close();

            Program.frmChinh.tssl_MaNV.Text = "Mã nhân viên: " + Program.username;
            Program.frmChinh.tssl_HoTen.Text = "Họ tên: " + Program.mHoten;
            Program.frmChinh.tssl_Nhom.Text = "Nhóm: " + Program.mGroup;
        }
    }
}
