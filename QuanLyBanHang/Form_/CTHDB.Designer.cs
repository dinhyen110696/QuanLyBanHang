namespace QuanLyBanHang.Form_
{
    partial class CTHDB
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
            this.txtTT = new System.Windows.Forms.TextBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaHDB = new System.Windows.Forms.Label();
            this.cmbTenHH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCTHDB = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtHDB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(125, 157);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(121, 20);
            this.txtTT.TabIndex = 40;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Enabled = false;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(125, 83);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(121, 21);
            this.cmbNhanVien.TabIndex = 39;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(49, 160);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(62, 14);
            this.lblTongTien.TabIndex = 38;
            this.lblTongTien.Text = "Tổng tiền : ";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "MM/dd/yyyy";
            this.dtpNgayBan.Enabled = false;
            this.dtpNgayBan.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(125, 119);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayBan.TabIndex = 37;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBan.Location = new System.Drawing.Point(49, 124);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(56, 14);
            this.lblNgayBan.TabIndex = 36;
            this.lblNgayBan.Text = "Ngày bán :";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(49, 86);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(50, 14);
            this.lblTenNV.TabIndex = 35;
            this.lblTenNV.Text = "Tên NV :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Chi Tiết Phiếu Bán";
            // 
            // lblMaHDB
            // 
            this.lblMaHDB.AutoSize = true;
            this.lblMaHDB.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDB.Location = new System.Drawing.Point(49, 53);
            this.lblMaHDB.Name = "lblMaHDB";
            this.lblMaHDB.Size = new System.Drawing.Size(57, 14);
            this.lblMaHDB.TabIndex = 32;
            this.lblMaHDB.Text = "Mã HĐB : ";
            // 
            // cmbTenHH
            // 
            this.cmbTenHH.Enabled = false;
            this.cmbTenHH.FormattingEnabled = true;
            this.cmbTenHH.Location = new System.Drawing.Point(385, 50);
            this.cmbTenHH.Name = "cmbTenHH";
            this.cmbTenHH.Size = new System.Drawing.Size(121, 21);
            this.cmbTenHH.TabIndex = 42;
            this.cmbTenHH.SelectedIndexChanged += new System.EventHandler(this.cmbTenHH_SelectedIndexChanged);
            this.cmbTenHH.TextChanged += new System.EventHandler(this.cmbTenHH_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên HH :";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(385, 87);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(121, 20);
            this.txtSL.TabIndex = 44;
            this.txtSL.Click += new System.EventHandler(this.txtSL_Click);
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 43;
            this.label3.Text = "Số Lượng : ";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(385, 122);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(121, 20);
            this.txtGia.TabIndex = 46;
            this.txtGia.Click += new System.EventHandler(this.txtGia_Click);
            this.txtGia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGia_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 45;
            this.label4.Text = "Đơn Gía : ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(385, 160);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(121, 20);
            this.txtThanhTien.TabIndex = 48;
            this.txtThanhTien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtThanhTien_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 47;
            this.label5.Text = "Thành tiền : ";
            // 
            // dgvCTHDB
            // 
            this.dgvCTHDB.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDB.Location = new System.Drawing.Point(12, 257);
            this.dgvCTHDB.Name = "dgvCTHDB";
            this.dgvCTHDB.Size = new System.Drawing.Size(553, 407);
            this.dgvCTHDB.TabIndex = 49;
            this.dgvCTHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHDB_CellClick);
            this.dgvCTHDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHDB_CellClick);
            this.dgvCTHDB.Click += new System.EventHandler(this.dgvCTHDB_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(281, 208);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(62, 22);
            this.btnHuy.TabIndex = 54;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Location = new System.Drawing.Point(349, 208);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(62, 22);
            this.btnLuu.TabIndex = 53;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(214, 208);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 22);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(79, 208);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 22);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(147, 208);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 22);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtHDB
            // 
            this.txtHDB.Location = new System.Drawing.Point(125, 50);
            this.txtHDB.Name = "txtHDB";
            this.txtHDB.Size = new System.Drawing.Size(121, 20);
            this.txtHDB.TabIndex = 55;
            // 
            // CTHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 676);
            this.Controls.Add(this.txtHDB);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvCTHDB);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTenHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.lblNgayBan);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaHDB);
            this.Name = "CTHDB";
            this.Text = "CTHDB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaHDB;
        private System.Windows.Forms.ComboBox cmbTenHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCTHDB;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtHDB;
    }
}