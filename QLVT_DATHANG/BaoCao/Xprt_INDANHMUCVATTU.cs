using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG
{
    public partial class Xprt_INDANHMUCVATTU : DevExpress.XtraReports.UI.XtraReport
    {
        public Xprt_INDANHMUCVATTU()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
