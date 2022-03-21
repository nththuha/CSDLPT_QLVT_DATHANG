
namespace QLVT_DATHANG
{
    partial class frmDatHang
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
            System.Windows.Forms.Label mASODDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nHACCLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mASODDHLabel1;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAVTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbb_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLVT_DATHANG.DS();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.DATHANGTableAdapter = new QLVT_DATHANG.DSTableAdapters.DATHANGTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.cgDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASODDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHACC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSoDDH = new DevExpress.XtraEditors.TextEdit();
            this.dtp_Ngay = new DevExpress.XtraEditors.DateEdit();
            this.txt_NhaCC = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_MaKho = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_MaNV = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.CTDDHTableAdapter = new QLVT_DATHANG.DSTableAdapters.CTDDHTableAdapter();
            this.cgCTDDH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASODDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_MaVT = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new DevExpress.XtraEditors.SpinEdit();
            this.txt_SoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txt_DDH = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUNHAPTableAdapter = new QLVT_DATHANG.DSTableAdapters.PHIEUNHAPTableAdapter();
            mASODDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nHACCLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mASODDHLabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSoDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Ngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NhaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // mASODDHLabel
            // 
            mASODDHLabel.AutoSize = true;
            mASODDHLabel.Location = new System.Drawing.Point(89, 64);
            mASODDHLabel.Name = "mASODDHLabel";
            mASODDHLabel.Size = new System.Drawing.Size(78, 17);
            mASODDHLabel.TabIndex = 11;
            mASODDHLabel.Text = "MASODDH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(90, 118);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(47, 17);
            nGAYLabel.TabIndex = 12;
            nGAYLabel.Text = "NGAY:";
            // 
            // nHACCLabel
            // 
            nHACCLabel.AutoSize = true;
            nHACCLabel.Location = new System.Drawing.Point(90, 169);
            nHACCLabel.Name = "nHACCLabel";
            nHACCLabel.Size = new System.Drawing.Size(57, 17);
            nHACCLabel.TabIndex = 13;
            nHACCLabel.Text = "NHACC:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(90, 278);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 16;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(89, 223);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 17;
            mANVLabel.Text = "MANV:";
            // 
            // mASODDHLabel1
            // 
            mASODDHLabel1.AutoSize = true;
            mASODDHLabel1.Location = new System.Drawing.Point(89, 64);
            mASODDHLabel1.Name = "mASODDHLabel1";
            mASODDHLabel1.Size = new System.Drawing.Size(78, 17);
            mASODDHLabel1.TabIndex = 19;
            mASODDHLabel1.Text = "MASODDH:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(89, 163);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(75, 17);
            sOLUONGLabel.TabIndex = 21;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(90, 215);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(63, 17);
            dONGIALabel.TabIndex = 22;
            dONGIALabel.Text = "DONGIA:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(90, 113);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(47, 17);
            mAVTLabel.TabIndex = 23;
            mAVTLabel.Text = "MAVT:";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
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
            this.btn_ChuyenChiNhanh,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(342, 151);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_HieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Ghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_PhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.Text = "Tools";
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
            this.btn_Ghi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Ghi.ImageOptions.SvgImage")));
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 774);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 744);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 744);
            // 
            // btn_ChuyenChiNhanh
            // 
            this.btn_ChuyenChiNhanh.Caption = "Chuyển chi nhánh";
            this.btn_ChuyenChiNhanh.Id = 7;
            this.btn_ChuyenChiNhanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ChuyenChiNhanh.ImageOptions.SvgImage")));
            this.btn_ChuyenChiNhanh.Name = "btn_ChuyenChiNhanh";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Report";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbb_ChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1924, 43);
            this.panelControl1.TabIndex = 5;
            // 
            // cbb_ChiNhanh
            // 
            this.cbb_ChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ChiNhanh.FormattingEnabled = true;
            this.cbb_ChiNhanh.Location = new System.Drawing.Point(127, 10);
            this.cbb_ChiNhanh.Name = "cbb_ChiNhanh";
            this.cbb_ChiNhanh.Size = new System.Drawing.Size(361, 24);
            this.cbb_ChiNhanh.TabIndex = 1;
            this.cbb_ChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbb_ChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DATHANG";
            this.bdsDatHang.DataSource = this.DS;
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
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // cgDatHang
            // 
            this.cgDatHang.DataSource = this.bdsDatHang;
            this.cgDatHang.Location = new System.Drawing.Point(0, 80);
            this.cgDatHang.MainView = this.gridView1;
            this.cgDatHang.MenuManager = this.barManager1;
            this.cgDatHang.Name = "cgDatHang";
            this.cgDatHang.Size = new System.Drawing.Size(1191, 338);
            this.cgDatHang.TabIndex = 6;
            this.cgDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASODDH,
            this.colNGAY,
            this.colNHACC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.cgDatHang;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lập đơn đặt hàng";
            // 
            // txt_MaSoDDH
            // 
            this.txt_MaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MASODDH", true));
            this.txt_MaSoDDH.Location = new System.Drawing.Point(224, 61);
            this.txt_MaSoDDH.MenuManager = this.barManager1;
            this.txt_MaSoDDH.Name = "txt_MaSoDDH";
            this.txt_MaSoDDH.Size = new System.Drawing.Size(306, 22);
            this.txt_MaSoDDH.TabIndex = 12;
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NGAY", true));
            this.dtp_Ngay.EditValue = null;
            this.dtp_Ngay.Location = new System.Drawing.Point(224, 115);
            this.dtp_Ngay.MenuManager = this.barManager1;
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Ngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Ngay.Size = new System.Drawing.Size(306, 22);
            this.dtp_Ngay.TabIndex = 13;
            // 
            // txt_NhaCC
            // 
            this.txt_NhaCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NHACC", true));
            this.txt_NhaCC.Location = new System.Drawing.Point(224, 166);
            this.txt_NhaCC.MenuManager = this.barManager1;
            this.txt_NhaCC.Name = "txt_NhaCC";
            this.txt_NhaCC.Size = new System.Drawing.Size(306, 22);
            this.txt_NhaCC.TabIndex = 14;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txt_MaKho);
            this.panelControl2.Controls.Add(this.button1);
            this.panelControl2.Controls.Add(mANVLabel);
            this.panelControl2.Controls.Add(this.txt_MaNV);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(mAKHOLabel);
            this.panelControl2.Controls.Add(nHACCLabel);
            this.panelControl2.Controls.Add(this.txt_MaSoDDH);
            this.panelControl2.Controls.Add(nGAYLabel);
            this.panelControl2.Controls.Add(mASODDHLabel);
            this.panelControl2.Controls.Add(this.dtp_Ngay);
            this.panelControl2.Controls.Add(this.txt_NhaCC);
            this.panelControl2.Location = new System.Drawing.Point(1197, 73);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(715, 345);
            this.panelControl2.TabIndex = 18;
            // 
            // txt_MaKho
            // 
            this.txt_MaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDatHang, "MAKHO", true));
            this.txt_MaKho.Enabled = false;
            this.txt_MaKho.Location = new System.Drawing.Point(224, 275);
            this.txt_MaKho.Name = "txt_MaKho";
            this.txt_MaKho.Size = new System.Drawing.Size(306, 23);
            this.txt_MaKho.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MANV", true));
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(224, 220);
            this.txt_MaNV.MenuManager = this.barManager1;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(306, 22);
            this.txt_MaNV.TabIndex = 18;
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
            // cgCTDDH
            // 
            this.cgCTDDH.DataSource = this.bdsCTDDH;
            this.cgCTDDH.Location = new System.Drawing.Point(0, 424);
            this.cgCTDDH.MainView = this.gridView2;
            this.cgCTDDH.MenuManager = this.barManager1;
            this.cgCTDDH.Name = "cgCTDDH";
            this.cgCTDDH.Size = new System.Drawing.Size(1191, 305);
            this.cgCTDDH.TabIndex = 18;
            this.cgCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASODDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cgCTDDH;
            this.gridView2.Name = "gridView2";
            // 
            // colMASODDH1
            // 
            this.colMASODDH1.FieldName = "MASODDH";
            this.colMASODDH1.MinWidth = 25;
            this.colMASODDH1.Name = "colMASODDH1";
            this.colMASODDH1.Visible = true;
            this.colMASODDH1.VisibleIndex = 0;
            this.colMASODDH1.Width = 94;
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
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.button2);
            this.panelControl3.Controls.Add(this.txt_MaVT);
            this.panelControl3.Controls.Add(mAVTLabel);
            this.panelControl3.Controls.Add(dONGIALabel);
            this.panelControl3.Controls.Add(this.txt_DonGia);
            this.panelControl3.Controls.Add(sOLUONGLabel);
            this.panelControl3.Controls.Add(this.txt_SoLuong);
            this.panelControl3.Controls.Add(mASODDHLabel1);
            this.panelControl3.Controls.Add(this.txt_DDH);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Location = new System.Drawing.Point(1197, 424);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(715, 309);
            this.panelControl3.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 24);
            this.button2.TabIndex = 21;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_MaVT
            // 
            this.txt_MaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTDDH, "MAVT", true));
            this.txt_MaVT.Enabled = false;
            this.txt_MaVT.Location = new System.Drawing.Point(224, 107);
            this.txt_MaVT.Name = "txt_MaVT";
            this.txt_MaVT.Size = new System.Drawing.Size(306, 23);
            this.txt_MaVT.TabIndex = 24;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "DONGIA", true));
            this.txt_DonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_DonGia.Location = new System.Drawing.Point(224, 211);
            this.txt_DonGia.MenuManager = this.barManager1;
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_DonGia.Size = new System.Drawing.Size(306, 24);
            this.txt_DonGia.TabIndex = 23;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "SOLUONG", true));
            this.txt_SoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_SoLuong.Location = new System.Drawing.Point(224, 159);
            this.txt_SoLuong.MenuManager = this.barManager1;
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_SoLuong.Size = new System.Drawing.Size(306, 24);
            this.txt_SoLuong.TabIndex = 22;
            // 
            // txt_DDH
            // 
            this.txt_DDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "MASODDH", true));
            this.txt_DDH.Enabled = false;
            this.txt_DDH.Location = new System.Drawing.Point(224, 61);
            this.txt_DDH.MenuManager = this.barManager1;
            this.txt_DDH.Name = "txt_DDH";
            this.txt_DDH.Size = new System.Drawing.Size(306, 22);
            this.txt_DDH.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lập chi tiết đơn đặt hàng";
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "FK_DATHANG_PHIEUNHAP";
            this.bdsPhieuNhap.DataSource = this.bdsDatHang;
            // 
            // PHIEUNHAPTableAdapter
            // 
            this.PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 794);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.cgCTDDH);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.cgDatHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatHang";
            this.Text = "frmDatHang";
            this.Load += new System.EventHandler(this.DatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSoDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Ngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NhaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbb_ChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DS DS;
        private DSTableAdapters.DATHANGTableAdapter DATHANGTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl cgDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASODDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNHACC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_NhaCC;
        private DevExpress.XtraEditors.DateEdit dtp_Ngay;
        private DevExpress.XtraEditors.TextEdit txt_MaSoDDH;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txt_MaNV;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
        private DevExpress.XtraGrid.GridControl cgCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASODDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SpinEdit txt_DonGia;
        private DevExpress.XtraEditors.SpinEdit txt_SoLuong;
        private DevExpress.XtraEditors.TextEdit txt_DDH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txt_MaKho;
        public System.Windows.Forms.TextBox txt_MaVT;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DSTableAdapters.PHIEUNHAPTableAdapter PHIEUNHAPTableAdapter;
    }
}