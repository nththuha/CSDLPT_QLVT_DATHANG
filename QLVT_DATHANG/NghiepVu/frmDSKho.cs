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
    public partial class frmDSKho : Form
    {
        String vitri = "";

        public frmDSKho(String vitri)
        {
            InitializeComponent();
            this.vitri = vitri;
        }

        private void kHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDSKho_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.KHO' table. You can move, or remove it, as needed.
            this.KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOTableAdapter.Fill(this.DS.KHO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maKho = ((DataRowView)bdsKho.Current)["MAKHO"].ToString();
            if (vitri == "DatHang") Program.formDatHang.txt_MaKho.Text = maKho;
            else if (vitri == "PhieuXuat") Program.formPhieuXuat.txt_MaKho.Text = maKho;
            else if (vitri == "PhieuNhap") Program.formPhieuNhap.txt_MaKho.Text = maKho;

            this.Close();
        }

        private void frmDSKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
