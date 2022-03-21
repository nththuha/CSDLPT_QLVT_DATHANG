
namespace QLVT_DATHANG
{
    partial class frmPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mASODDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_ChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.panel_ChonChiNhanh = new System.Windows.Forms.Panel();
            this.cbb_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_DatHang = new System.Windows.Forms.Panel();
            this.gcDatHang = new DevExpress.XtraGrid.GridControl();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT_DATHANG.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASODDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHACC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATHANGTableAdapter = new QLVT_DATHANG.DSTableAdapters.DATHANGTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.PHIEUNHAPTableAdapter = new QLVT_DATHANG.DSTableAdapters.PHIEUNHAPTableAdapter();
            this.panel_PN_CTPN = new System.Windows.Forms.Panel();
            this.gcCTPN = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASODDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_Them_Sua = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_DonGia = new DevExpress.XtraEditors.TextEdit();
            this.txt_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.txt_MaVT = new System.Windows.Forms.TextBox();
            this.txt_MaPN_CTPN = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_MaKho = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaSoDDH = new System.Windows.Forms.TextBox();
            this.txt_Ngay = new DevExpress.XtraEditors.DateEdit();
            this.txt_MaPN_PN = new System.Windows.Forms.TextBox();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.CTDDHTableAdapter = new QLVT_DATHANG.DSTableAdapters.CTDDHTableAdapter();
            this.CTPNTableAdapter = new QLVT_DATHANG.DSTableAdapters.CTPNTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mASODDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel_ChonChiNhanh.SuspendLayout();
            this.panel_DatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel_PN_CTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel_Them_Sua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(32, 44);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(48, 17);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(33, 82);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(47, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // mASODDHLabel
            // 
            mASODDHLabel.AutoSize = true;
            mASODDHLabel.Location = new System.Drawing.Point(32, 115);
            mASODDHLabel.Name = "mASODDHLabel";
            mASODDHLabel.Size = new System.Drawing.Size(78, 17);
            mASODDHLabel.TabIndex = 4;
            mASODDHLabel.Text = "MASODDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(33, 151);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(33, 189);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(33, 53);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(48, 17);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "MAPN:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(32, 99);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(47, 17);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(32, 141);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(75, 17);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(33, 185);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(63, 17);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Them,
            this.btn_HieuChinh,
            this.btn_Ghi,
            this.btn_Xoa,
            this.btn_PhucHoi,
            this.btn_Reload,
            this.btn_Thoat,
            this.btn_ChuyenChiNhanh});
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_HieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Ghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_PhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btn_Them
            // 
            this.btn_Them.Caption = "Thêm";
            this.btn_Them.Id = 0;
            this.btn_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Them.ImageOptions.SvgImage")));
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Them_ItemClick);
            // 
            // btn_HieuChinh
            // 
            this.btn_HieuChinh.Caption = "Hiệu chỉnh";
            this.btn_HieuChinh.Id = 1;
            this.btn_HieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_HieuChinh.ImageOptions.SvgImage")));
            this.btn_HieuChinh.Name = "btn_HieuChinh";
            this.btn_HieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HieuChinh_ItemClick);
            // 
            // btn_Ghi
            // 
            this.btn_Ghi.Caption = "Ghi";
            this.btn_Ghi.Id = 2;
            this.btn_Ghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ghi.ImageOptions.Image")));
            this.btn_Ghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Ghi.ImageOptions.LargeImage")));
            this.btn_Ghi.Name = "btn_Ghi";
            this.btn_Ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Ghi_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 3;
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Caption = "Phục hồi";
            this.btn_PhucHoi.Id = 4;
            this.btn_PhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_PhucHoi.ImageOptions.SvgImage")));
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhucHoi_ItemClick);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Caption = "Reload";
            this.btn_Reload.Id = 5;
            this.btn_Reload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Reload.ImageOptions.SvgImage")));
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Reload_ItemClick);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 6;
            this.btn_Thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Thoat.ImageOptions.SvgImage")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1013);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 983);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 983);
            // 
            // btn_ChuyenChiNhanh
            // 
            this.btn_ChuyenChiNhanh.Caption = "Chuyển chi nhánh";
            this.btn_ChuyenChiNhanh.Id = 7;
            this.btn_ChuyenChiNhanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ChuyenChiNhanh.ImageOptions.SvgImage")));
            this.btn_ChuyenChiNhanh.Name = "btn_ChuyenChiNhanh";
            // 
            // panel_ChonChiNhanh
            // 
            this.panel_ChonChiNhanh.Controls.Add(this.cbb_ChiNhanh);
            this.panel_ChonChiNhanh.Controls.Add(this.label1);
            this.panel_ChonChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChonChiNhanh.Location = new System.Drawing.Point(0, 30);
            this.panel_ChonChiNhanh.Name = "panel_ChonChiNhanh";
            this.panel_ChonChiNhanh.Size = new System.Drawing.Size(1924, 45);
            this.panel_ChonChiNhanh.TabIndex = 4;
            // 
            // cbb_ChiNhanh
            // 
            this.cbb_ChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ChiNhanh.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ChiNhanh.FormattingEnabled = true;
            this.cbb_ChiNhanh.Location = new System.Drawing.Point(132, 11);
            this.cbb_ChiNhanh.Name = "cbb_ChiNhanh";
            this.cbb_ChiNhanh.Size = new System.Drawing.Size(386, 24);
            this.cbb_ChiNhanh.TabIndex = 2;
            this.cbb_ChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbb_ChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh:";
            // 
            // panel_DatHang
            // 
            this.panel_DatHang.Controls.Add(this.gcDatHang);
            this.panel_DatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_DatHang.Location = new System.Drawing.Point(0, 75);
            this.panel_DatHang.Name = "panel_DatHang";
            this.panel_DatHang.Size = new System.Drawing.Size(1924, 210);
            this.panel_DatHang.TabIndex = 5;
            // 
            // gcDatHang
            // 
            this.gcDatHang.DataSource = this.bdsDatHang;
            this.gcDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDatHang.Location = new System.Drawing.Point(0, 0);
            this.gcDatHang.MainView = this.gridView1;
            this.gcDatHang.MenuManager = this.barManager1;
            this.gcDatHang.Name = "gcDatHang";
            this.gcDatHang.Size = new System.Drawing.Size(1924, 193);
            this.gcDatHang.TabIndex = 0;
            this.gcDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DATHANG";
            this.bdsDatHang.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASODDH,
            this.colNGAY,
            this.colNHACC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcDatHang;
            this.gridView1.Name = "gridView1";
            // 
            // colMASODDH
            // 
            this.colMASODDH.FieldName = "MASODDH";
            this.colMASODDH.MinWidth = 25;
            this.colMASODDH.Name = "colMASODDH";
            this.colMASODDH.Visible = true;
            this.colMASODDH.VisibleIndex = 0;
            this.colMASODDH.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNHACC
            // 
            this.colNHACC.FieldName = "NHACC";
            this.colNHACC.MinWidth = 25;
            this.colNHACC.Name = "colNHACC";
            this.colNHACC.Visible = true;
            this.colNHACC.VisibleIndex = 2;
            this.colNHACC.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // DATHANGTableAdapter
            // 
            this.DATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DATHANGTableAdapter = this.DATHANGTableAdapter;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = this.PHIEUNHAPTableAdapter;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // PHIEUNHAPTableAdapter
            // 
            this.PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // panel_PN_CTPN
            // 
            this.panel_PN_CTPN.Controls.Add(this.gcCTPN);
            this.panel_PN_CTPN.Controls.Add(this.gcPhieuNhap);
            this.panel_PN_CTPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_PN_CTPN.Location = new System.Drawing.Point(0, 285);
            this.panel_PN_CTPN.Name = "panel_PN_CTPN";
            this.panel_PN_CTPN.Size = new System.Drawing.Size(1084, 728);
            this.panel_PN_CTPN.TabIndex = 6;
            // 
            // gcCTPN
            // 
            this.gcCTPN.DataSource = this.bdsCTPN;
            this.gcCTPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTPN.Location = new System.Drawing.Point(0, 241);
            this.gcCTPN.MainView = this.gridView3;
            this.gcCTPN.MenuManager = this.barManager1;
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.Size = new System.Drawing.Size(1084, 220);
            this.gcCTPN.TabIndex = 1;
            this.gcCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_PHIEUNHAP_CTPN";
            this.bdsCTPN.DataSource = this.bdsPhieuNhap;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PHIEUNHAP";
            this.bdsPhieuNhap.DataSource = this.DS;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView3.GridControl = this.gcCTPN;
            this.gridView3.Name = "gridView3";
            // 
            // colMAPN1
            // 
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.DataSource = this.bdsPhieuNhap;
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.gcPhieuNhap.MainView = this.gridView2;
            this.gcPhieuNhap.MenuManager = this.barManager1;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(1084, 241);
            this.gcPhieuNhap.TabIndex = 0;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY1,
            this.colMASODDH1,
            this.colMANV1,
            this.colMAKHO1});
            this.gridView2.GridControl = this.gcPhieuNhap;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
            // 
            // colNGAY1
            // 
            this.colNGAY1.FieldName = "NGAY";
            this.colNGAY1.MinWidth = 25;
            this.colNGAY1.Name = "colNGAY1";
            this.colNGAY1.Visible = true;
            this.colNGAY1.VisibleIndex = 1;
            this.colNGAY1.Width = 94;
            // 
            // colMASODDH1
            // 
            this.colMASODDH1.FieldName = "MASODDH";
            this.colMASODDH1.MinWidth = 25;
            this.colMASODDH1.Name = "colMASODDH1";
            this.colMASODDH1.Visible = true;
            this.colMASODDH1.VisibleIndex = 2;
            this.colMASODDH1.Width = 94;
            // 
            // colMANV1
            // 
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.MinWidth = 25;
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 3;
            this.colMANV1.Width = 94;
            // 
            // colMAKHO1
            // 
            this.colMAKHO1.FieldName = "MAKHO";
            this.colMAKHO1.MinWidth = 25;
            this.colMAKHO1.Name = "colMAKHO1";
            this.colMAKHO1.Visible = true;
            this.colMAKHO1.VisibleIndex = 4;
            this.colMAKHO1.Width = 94;
            // 
            // panel_Them_Sua
            // 
            this.panel_Them_Sua.Controls.Add(this.groupControl2);
            this.panel_Them_Sua.Controls.Add(this.groupControl1);
            this.panel_Them_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Them_Sua.Location = new System.Drawing.Point(1084, 285);
            this.panel_Them_Sua.Name = "panel_Them_Sua";
            this.panel_Them_Sua.Size = new System.Drawing.Size(840, 728);
            this.panel_Them_Sua.TabIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(dONGIALabel);
            this.groupControl2.Controls.Add(this.txt_DonGia);
            this.groupControl2.Controls.Add(sOLUONGLabel);
            this.groupControl2.Controls.Add(this.txt_SoLuong);
            this.groupControl2.Controls.Add(mAVTLabel);
            this.groupControl2.Controls.Add(this.txt_MaVT);
            this.groupControl2.Controls.Add(mAPNLabel1);
            this.groupControl2.Controls.Add(this.txt_MaPN_CTPN);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 241);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(840, 487);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Hiệu chỉnh Chi Tiết Phiếu Nhập";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "DONGIA", true));
            this.txt_DonGia.Location = new System.Drawing.Point(126, 182);
            this.txt_DonGia.MenuManager = this.barManager1;
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(318, 22);
            this.txt_DonGia.TabIndex = 7;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTPN, "SOLUONG", true));
            this.txt_SoLuong.Location = new System.Drawing.Point(126, 139);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(318, 23);
            this.txt_SoLuong.TabIndex = 5;
            // 
            // txt_MaVT
            // 
            this.txt_MaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAVT", true));
            this.txt_MaVT.Location = new System.Drawing.Point(126, 93);
            this.txt_MaVT.Name = "txt_MaVT";
            this.txt_MaVT.Size = new System.Drawing.Size(318, 23);
            this.txt_MaVT.TabIndex = 3;
            // 
            // txt_MaPN_CTPN
            // 
            this.txt_MaPN_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAPN", true));
            this.txt_MaPN_CTPN.Location = new System.Drawing.Point(126, 50);
            this.txt_MaPN_CTPN.Name = "txt_MaPN_CTPN";
            this.txt_MaPN_CTPN.Size = new System.Drawing.Size(318, 23);
            this.txt_MaPN_CTPN.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(mAKHOLabel);
            this.groupControl1.Controls.Add(this.txt_MaKho);
            this.groupControl1.Controls.Add(mANVLabel);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(mASODDHLabel);
            this.groupControl1.Controls.Add(this.txtMaSoDDH);
            this.groupControl1.Controls.Add(nGAYLabel);
            this.groupControl1.Controls.Add(this.txt_Ngay);
            this.groupControl1.Controls.Add(mAPNLabel);
            this.groupControl1.Controls.Add(this.txt_MaPN_PN);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(840, 241);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hiệu chỉnh Phiếu Nhập";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_MaKho
            // 
            this.txt_MaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAKHO", true));
            this.txt_MaKho.Location = new System.Drawing.Point(126, 186);
            this.txt_MaKho.Name = "txt_MaKho";
            this.txt_MaKho.Size = new System.Drawing.Size(318, 23);
            this.txt_MaKho.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(126, 148);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(318, 23);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtMaSoDDH
            // 
            this.txtMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MASODDH", true));
            this.txtMaSoDDH.Location = new System.Drawing.Point(126, 112);
            this.txtMaSoDDH.Name = "txtMaSoDDH";
            this.txtMaSoDDH.Size = new System.Drawing.Size(318, 23);
            this.txtMaSoDDH.TabIndex = 5;
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuNhap, "NGAY", true));
            this.txt_Ngay.EditValue = null;
            this.txt_Ngay.Location = new System.Drawing.Point(126, 79);
            this.txt_Ngay.MenuManager = this.barManager1;
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Ngay.Size = new System.Drawing.Size(318, 22);
            this.txt_Ngay.TabIndex = 3;
            // 
            // txt_MaPN_PN
            // 
            this.txt_MaPN_PN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAPN", true));
            this.txt_MaPN_PN.Location = new System.Drawing.Point(126, 41);
            this.txt_MaPN_PN.Name = "txt_MaPN_PN";
            this.txt_MaPN_PN.Size = new System.Drawing.Size(318, 23);
            this.txt_MaPN_PN.TabIndex = 1;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_DATHANG_CTDDH";
            this.bdsCTDDH.DataSource = this.bdsDatHang;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.panel_Them_Sua);
            this.Controls.Add(this.panel_PN_CTPN);
            this.Controls.Add(this.panel_DatHang);
            this.Controls.Add(this.panel_ChonChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel_ChonChiNhanh.ResumeLayout(false);
            this.panel_ChonChiNhanh.PerformLayout();
            this.panel_DatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel_PN_CTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel_Them_Sua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_HieuChinh;
        private DevExpress.XtraBars.BarButtonItem btn_Ghi;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_ChuyenChiNhanh;
        private System.Windows.Forms.Panel panel_ChonChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_ChiNhanh;
        private System.Windows.Forms.Panel panel_DatHang;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DS DS;
        private DSTableAdapters.DATHANGTableAdapter DATHANGTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASODDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNHACC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.Panel panel_PN_CTPN;
        private System.Windows.Forms.Panel panel_Them_Sua;
        private DSTableAdapters.PHIEUNHAPTableAdapter PHIEUNHAPTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASODDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraEditors.DateEdit txt_Ngay;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_MaKho;
        public System.Windows.Forms.TextBox txtMaSoDDH;
        public System.Windows.Forms.TextBox txt_MaPN_PN;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.TextEdit txt_DonGia;
        private System.Windows.Forms.NumericUpDown txt_SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        public System.Windows.Forms.TextBox txt_MaPN_CTPN;
        private System.Windows.Forms.TextBox txt_MaVT;
    }
}