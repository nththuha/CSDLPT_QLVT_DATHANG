﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG
{
    public partial class Xprt_INDANHSACHNHANVIEN : DevExpress.XtraReports.UI.XtraReport
    {
        public Xprt_INDANHSACHNHANVIEN()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
