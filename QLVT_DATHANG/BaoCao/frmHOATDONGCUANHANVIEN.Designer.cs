
namespace QLVT_DATHANG
{
    partial class frmHOATDONGCUANHANVIEN
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
            System.Windows.Forms.Label mANVLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.de_NgayBD = new DevExpress.XtraEditors.DateEdit();
            this.de_NgayKT = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.DS = new QLVT_DATHANG.DS();
            this.bdsHoTen = new System.Windows.Forms.BindingSource(this.components);
            this.HOTENNVTableAdapter = new QLVT_DATHANG.DSTableAdapters.HOTENNVTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_Luong = new System.Windows.Forms.Label();
            this.lb_MaCN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTen)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(76, 105);
            mANVLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(126, 22);
            mANVLabel.TabIndex = 11;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "HOẠT ĐỘNG CỦA NHÂN VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đến ngày:";
            // 
            // de_NgayBD
            // 
            this.de_NgayBD.EditValue = null;
            this.de_NgayBD.Location = new System.Drawing.Point(234, 202);
            this.de_NgayBD.Margin = new System.Windows.Forms.Padding(12);
            this.de_NgayBD.Name = "de_NgayBD";
            this.de_NgayBD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_NgayBD.Properties.Appearance.Options.UseFont = true;
            this.de_NgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayBD.Size = new System.Drawing.Size(322, 28);
            this.de_NgayBD.TabIndex = 8;
            // 
            // de_NgayKT
            // 
            this.de_NgayKT.EditValue = null;
            this.de_NgayKT.Location = new System.Drawing.Point(806, 200);
            this.de_NgayKT.Margin = new System.Windows.Forms.Padding(12);
            this.de_NgayKT.Name = "de_NgayKT";
            this.de_NgayKT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_NgayKT.Properties.Appearance.Options.UseFont = true;
            this.de_NgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayKT.Size = new System.Drawing.Size(337, 28);
            this.de_NgayKT.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHoTen
            // 
            this.bdsHoTen.DataMember = "HOTENNV";
            this.bdsHoTen.DataSource = this.DS;
            // 
            // HOTENNVTableAdapter
            // 
            this.HOTENNVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DATHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.DataSource = this.bdsHoTen;
            this.cbb_MaNV.DisplayMember = "MANV";
            this.cbb_MaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(234, 102);
            this.cbb_MaNV.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(322, 28);
            this.cbb_MaNV.TabIndex = 12;
            this.cbb_MaNV.ValueMember = "HOTEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Loại:";
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Loai.Items.AddRange(new object[] {
            "NHẬP",
            "XUẤT"});
            this.cbb_Loai.Location = new System.Drawing.Point(447, 308);
            this.cbb_Loai.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(390, 28);
            this.cbb_Loai.TabIndex = 14;
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTen, "HOTEN", true));
            this.lb_HoTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.Location = new System.Drawing.Point(803, 105);
            this.lb_HoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(311, 29);
            this.lb_HoTen.TabIndex = 15;
            this.lb_HoTen.Text = "label6";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTen, "DIACHI", true));
            this.lb_DiaChi.Location = new System.Drawing.Point(1018, 333);
            this.lb_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(125, 29);
            this.lb_DiaChi.TabIndex = 16;
            this.lb_DiaChi.Text = "Địa chỉ";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTen, "NGAYSINH", true));
            this.lb_NgaySinh.Location = new System.Drawing.Point(1018, 362);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(100, 23);
            this.lb_NgaySinh.TabIndex = 17;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // lb_Luong
            // 
            this.lb_Luong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTen, "LUONG", true));
            this.lb_Luong.Location = new System.Drawing.Point(1018, 385);
            this.lb_Luong.Name = "lb_Luong";
            this.lb_Luong.Size = new System.Drawing.Size(100, 23);
            this.lb_Luong.TabIndex = 18;
            this.lb_Luong.Text = "Lương";
            // 
            // lb_MaCN
            // 
            this.lb_MaCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTen, "MACN", true));
            this.lb_MaCN.Location = new System.Drawing.Point(1018, 408);
            this.lb_MaCN.Name = "lb_MaCN";
            this.lb_MaCN.Size = new System.Drawing.Size(100, 23);
            this.lb_MaCN.TabIndex = 19;
            this.lb_MaCN.Text = "Mã CN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(878, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 136);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // frmHOATDONGCUANHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_MaCN);
            this.Controls.Add(this.lb_Luong);
            this.Controls.Add(this.lb_NgaySinh);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.cbb_Loai);
            this.Controls.Add(this.label1);
            this.Controls.Add(mANVLabel);
            this.Controls.Add(this.cbb_MaNV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.de_NgayKT);
            this.Controls.Add(this.de_NgayBD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHOATDONGCUANHANVIEN";
            this.Text = "frmHOATDONGCUANHANVIEN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHOATDONGCUANHANVIEN_FormClosed);
            this.Load += new System.EventHandler(this.frmHOATDONGCUANHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit de_NgayBD;
        private DevExpress.XtraEditors.DateEdit de_NgayKT;
        private System.Windows.Forms.Button button1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsHoTen;
        private DSTableAdapters.HOTENNVTableAdapter HOTENNVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_Luong;
        private System.Windows.Forms.Label lb_MaCN;
        private System.Windows.Forms.Label label6;
    }
}