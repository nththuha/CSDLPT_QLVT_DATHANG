using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.Data.Filtering;

namespace QLVT_DATHANG
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void lay_dspm(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbb_ChiNhanh.DataSource = Program.bds_dspm;
            cbb_ChiNhanh.DisplayMember = "TENCN";
            cbb_ChiNhanh.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kế nối về cơ sở dữ liệu gốc.\n Bạn xem lại Tên Server của Publisher, và tên CSDL", "Lỗi đăng nhập", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0)
                return;
            lay_dspm("SELECT * FROM DSPHANMANH");
            cbb_ChiNhanh.SelectedIndex = 1;
            cbb_ChiNhanh.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbb_ChiNhanh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text.Trim() == "" || txt_MatMa.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống ", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txt_TaiKhoan.Text;
            Program.password = txt_MatMa.Text;

            if (Program.KetNoi() == 0)
                return;

            Program.mChinhanh = cbb_ChiNhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu,\n bạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            if (Program.mChinhanh == 0) Program.maChiNhanh = "CN1";
            else Program.maChiNhanh = "CN2";

            Program.frmChinh.tssl_MaNV.Text = "Mã NV: " + Program.username;
            Program.frmChinh.tssl_HoTen.Text = "Họ Tên: " + Program.mHoten;
            Program.frmChinh.tssl_Nhom.Text = "Nhóm: " + Program.mGroup;
            Program.frmChinh.btn_DangXuat.Enabled = Program.frmChinh.btn_NhanVien.Enabled = Program.frmChinh.btn_VatTu.Enabled = Program.frmChinh.btn_Kho.Enabled = Program.frmChinh.btn_DatHang.Enabled = Program.frmChinh.btn_PhieuNhap.Enabled = Program.frmChinh.btn_PhieuXuat.Enabled = true;
            Program.frmChinh.btn_DSNhanVien.Enabled = Program.frmChinh.btn_DMVatTu.Enabled = Program.frmChinh.btn_GiaTriHang.Enabled = Program.frmChinh.btn_DDH.Enabled = Program.frmChinh.btn_HoatDongNhanVien.Enabled = Program.frmChinh.btn_TongHop.Enabled = true;
            Program.frmChinh.btn_DangNhap.Enabled = false;
            if(Program.mGroup != "USER")
            {
                Program.frmChinh.btn_TaoTaiKhoan.Enabled = true;
            }
            MessageBox.Show("Đăng nhập thành công vào " + Program.maChiNhanh, "", MessageBoxButtons.OK);
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Program.conn.Close();
            if (Program.frmChinh != null)
                Program.frmChinh.Close();
            Close();
        }
    }
}
