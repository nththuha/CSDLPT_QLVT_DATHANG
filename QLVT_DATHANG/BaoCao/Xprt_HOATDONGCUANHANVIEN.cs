using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANG
{
    public partial class Xprt_HOATDONGCUANHANVIEN : DevExpress.XtraReports.UI.XtraReport
    {
        public Xprt_HOATDONGCUANHANVIEN(int maNV, String ngayBD, String ngayKT, String loai)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maNV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayBD;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ngayKT;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = loai;
            this.sqlDataSource1.Fill();
        }

    }
}
