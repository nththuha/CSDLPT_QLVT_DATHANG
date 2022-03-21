using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANG
{
    public partial class Xprt_TONGHOPNHAPXUAT : DevExpress.XtraReports.UI.XtraReport
    {
        public Xprt_TONGHOPNHAPXUAT()
        {
        }
        public Xprt_TONGHOPNHAPXUAT(String ngayBD, String ngayKT)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngayBD;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayKT;
            this.sqlDataSource1.Fill();
        }

    }
}
