
namespace QLVT_DATHANG
{
    partial class frmCTTriGiaNhapXuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nhom = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.cbb_LoaiPhieu = new System.Windows.Forms.ComboBox();
            this.dtp_NgayBD = new DevExpress.XtraEditors.DateEdit();
            this.dtp_NgayKT = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayKT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ NHẬP XUẤT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại phiếu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhóm";
            // 
            // txt_Nhom
            // 
            this.txt_Nhom.Enabled = false;
            this.txt_Nhom.Location = new System.Drawing.Point(337, 349);
            this.txt_Nhom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Nhom.Name = "txt_Nhom";
            this.txt_Nhom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nhom.Properties.Appearance.Options.UseFont = true;
            this.txt_Nhom.Size = new System.Drawing.Size(525, 28);
            this.txt_Nhom.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(437, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "CHỌN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_LoaiPhieu
            // 
            this.cbb_LoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiPhieu.FormattingEnabled = true;
            this.cbb_LoaiPhieu.Items.AddRange(new object[] {
            "NHAP",
            "XUAT"});
            this.cbb_LoaiPhieu.Location = new System.Drawing.Point(337, 274);
            this.cbb_LoaiPhieu.Name = "cbb_LoaiPhieu";
            this.cbb_LoaiPhieu.Size = new System.Drawing.Size(525, 28);
            this.cbb_LoaiPhieu.TabIndex = 10;
            // 
            // dtp_NgayBD
            // 
            this.dtp_NgayBD.EditValue = null;
            this.dtp_NgayBD.Location = new System.Drawing.Point(337, 107);
            this.dtp_NgayBD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_NgayBD.Name = "dtp_NgayBD";
            this.dtp_NgayBD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayBD.Properties.Appearance.Options.UseFont = true;
            this.dtp_NgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayBD.Size = new System.Drawing.Size(525, 28);
            this.dtp_NgayBD.TabIndex = 11;
            // 
            // dtp_NgayKT
            // 
            this.dtp_NgayKT.EditValue = null;
            this.dtp_NgayKT.Location = new System.Drawing.Point(337, 190);
            this.dtp_NgayKT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_NgayKT.Name = "dtp_NgayKT";
            this.dtp_NgayKT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKT.Properties.Appearance.Options.UseFont = true;
            this.dtp_NgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgayKT.Size = new System.Drawing.Size(525, 28);
            this.dtp_NgayKT.TabIndex = 12;
            // 
            // frmCTTriGiaNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 522);
            this.Controls.Add(this.dtp_NgayKT);
            this.Controls.Add(this.dtp_NgayBD);
            this.Controls.Add(this.cbb_LoaiPhieu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Nhom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCTTriGiaNhapXuat";
            this.Text = "frmCTTriGiaNhapXuat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCTTriGiaNhapXuat_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgayKT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txt_Nhom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbb_LoaiPhieu;
        private DevExpress.XtraEditors.DateEdit dtp_NgayBD;
        private DevExpress.XtraEditors.DateEdit dtp_NgayKT;
    }
}