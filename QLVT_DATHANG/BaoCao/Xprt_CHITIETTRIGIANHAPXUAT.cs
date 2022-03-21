using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG
{
    public partial class Xprt_CHITIETTRIGIANHAPXUAT : DevExpress.XtraReports.UI.XtraReport
    {
        public Xprt_CHITIETTRIGIANHAPXUAT(DateTime ngayBD, DateTime ngayKT, String nhom, String loaiPhieu)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngayBD;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayKT;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = nhom;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = loaiPhieu;
            this.sqlDataSource1.Fill();
        }

    }
}
