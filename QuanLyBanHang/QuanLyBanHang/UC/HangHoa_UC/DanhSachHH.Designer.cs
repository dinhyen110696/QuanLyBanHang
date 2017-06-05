namespace QuanLyBanHang.UC.HangHoa_UC
{
    partial class DanhSachHH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblNhomHang = new System.Windows.Forms.Label();
            this.txtNoiSX = new System.Windows.Forms.TextBox();
            this.cmbNhomHang = new System.Windows.Forms.ComboBox();
            this.cmbNCC = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblNCC = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.lbnDonVi = new System.Windows.Forms.Label();
            this.lblNoiSX = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.lblTenHH = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.button1);
            this.grpNhanVien.Controls.Add(this.txtTimKiem);
            this.grpNhanVien.Controls.Add(this.txtDonGia);
            this.grpNhanVien.Controls.Add(this.lblDonGia);
            this.grpNhanVien.Controls.Add(this.btnHuy);
            this.grpNhanVien.Controls.Add(this.btnLuu);
            this.grpNhanVien.Controls.Add(this.lblNhomHang);
            this.grpNhanVien.Controls.Add(this.txtNoiSX);
            this.grpNhanVien.Controls.Add(this.cmbNhomHang);
            this.grpNhanVien.Controls.Add(this.cmbNCC);
            this.grpNhanVien.Controls.Add(this.btnXoa);
            this.grpNhanVien.Controls.Add(this.btnThem);
            this.grpNhanVien.Controls.Add(this.btnSua);
            this.grpNhanVien.Controls.Add(this.lblNCC);
            this.grpNhanVien.Controls.Add(this.txtDonVi);
            this.grpNhanVien.Controls.Add(this.lbnDonVi);
            this.grpNhanVien.Controls.Add(this.lblNoiSX);
            this.grpNhanVien.Controls.Add(this.txtTenHH);
            this.grpNhanVien.Controls.Add(this.lblTenHH);
            this.grpNhanVien.Controls.Add(this.txtMaHH);
            this.grpNhanVien.Controls.Add(this.lblMaHH);
            this.grpNhanVien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhanVien.Location = new System.Drawing.Point(60, 0);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Size = new System.Drawing.Size(807, 148);
            this.grpNhanVien.TabIndex = 1;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "Thông tin hàng hóa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(737, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 22);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tìm kiếm : ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(596, 120);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(120, 18);
            this.txtTimKiem.TabIndex = 18;
            this.txtTimKiem.Text = "   nhập vào đây để tìm kiếm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(314, 74);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(156, 20);
            this.txtDonGia.TabIndex = 17;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(247, 77);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(49, 14);
            this.lblDonGia.TabIndex = 16;
            this.lblDonGia.Text = "Đơn giá :";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(408, 119);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(62, 22);
            this.btnHuy.TabIndex = 15;
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
            this.btnLuu.Location = new System.Drawing.Point(476, 119);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(62, 22);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblNhomHang
            // 
            this.lblNhomHang.AutoSize = true;
            this.lblNhomHang.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomHang.Location = new System.Drawing.Point(535, 63);
            this.lblNhomHang.Name = "lblNhomHang";
            this.lblNhomHang.Size = new System.Drawing.Size(67, 14);
            this.lblNhomHang.TabIndex = 13;
            this.lblNhomHang.Text = "Nhóm hàng :";
            // 
            // txtNoiSX
            // 
            this.txtNoiSX.Enabled = false;
            this.txtNoiSX.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiSX.Location = new System.Drawing.Point(314, 21);
            this.txtNoiSX.Name = "txtNoiSX";
            this.txtNoiSX.Size = new System.Drawing.Size(156, 20);
            this.txtNoiSX.TabIndex = 12;
            // 
            // cmbNhomHang
            // 
            this.cmbNhomHang.Enabled = false;
            this.cmbNhomHang.FormattingEnabled = true;
            this.cmbNhomHang.Location = new System.Drawing.Point(633, 60);
            this.cmbNhomHang.Name = "cmbNhomHang";
            this.cmbNhomHang.Size = new System.Drawing.Size(168, 23);
            this.cmbNhomHang.TabIndex = 11;
            // 
            // cmbNCC
            // 
            this.cmbNCC.Enabled = false;
            this.cmbNCC.FormattingEnabled = true;
            this.cmbNCC.Location = new System.Drawing.Point(633, 31);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(168, 23);
            this.cmbNCC.TabIndex = 10;
            this.cmbNCC.SelectedIndexChanged += new System.EventHandler(this.cboNCC_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(341, 119);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 22);
            this.btnXoa.TabIndex = 2;
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
            this.btnThem.Location = new System.Drawing.Point(206, 119);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 22);
            this.btnThem.TabIndex = 0;
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
            this.btnSua.Location = new System.Drawing.Point(274, 119);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 22);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.Location = new System.Drawing.Point(535, 37);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(75, 14);
            this.lblNCC.TabIndex = 9;
            this.lblNCC.Text = "Nhà cung cấp :";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Enabled = false;
            this.txtDonVi.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(314, 47);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(156, 20);
            this.txtDonVi.TabIndex = 8;
            this.txtDonVi.TextChanged += new System.EventHandler(this.txtDonVi_TextChanged);
            // 
            // lbnDonVi
            // 
            this.lbnDonVi.AutoSize = true;
            this.lbnDonVi.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnDonVi.Location = new System.Drawing.Point(247, 50);
            this.lbnDonVi.Name = "lbnDonVi";
            this.lbnDonVi.Size = new System.Drawing.Size(45, 14);
            this.lbnDonVi.TabIndex = 7;
            this.lbnDonVi.Text = "Đơn vị :";
            this.lbnDonVi.Click += new System.EventHandler(this.lbnDonVi_Click);
            // 
            // lblNoiSX
            // 
            this.lblNoiSX.AutoSize = true;
            this.lblNoiSX.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiSX.Location = new System.Drawing.Point(247, 24);
            this.lblNoiSX.Name = "lblNoiSX";
            this.lblNoiSX.Size = new System.Drawing.Size(49, 14);
            this.lblNoiSX.TabIndex = 5;
            this.lblNoiSX.Text = "Nơi  SX :";
            this.lblNoiSX.Click += new System.EventHandler(this.lblNoiSX_Click);
            // 
            // txtTenHH
            // 
            this.txtTenHH.Enabled = false;
            this.txtTenHH.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHH.Location = new System.Drawing.Point(99, 60);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(103, 20);
            this.txtTenHH.TabIndex = 3;
            // 
            // lblTenHH
            // 
            this.lblTenHH.AutoSize = true;
            this.lblTenHH.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHH.Location = new System.Drawing.Point(24, 63);
            this.lblTenHH.Name = "lblTenHH";
            this.lblTenHH.Size = new System.Drawing.Size(51, 14);
            this.lblTenHH.TabIndex = 2;
            this.lblTenHH.Text = "Tên HH :";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Enabled = false;
            this.txtMaHH.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHH.Location = new System.Drawing.Point(99, 34);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(103, 20);
            this.txtMaHH.TabIndex = 1;
            // 
            // lblMaHH
            // 
            this.lblMaHH.AutoSize = true;
            this.lblMaHH.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHH.Location = new System.Drawing.Point(24, 37);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(50, 14);
            this.lblMaHH.TabIndex = 0;
            this.lblMaHH.Text = "Mã HH : ";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToResizeRows = false;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.GridColor = System.Drawing.Color.LightGreen;
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 0);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(807, 266);
            this.dgvHangHoa.TabIndex = 2;
            this.dgvHangHoa.Click += new System.EventHandler(this.dgvHangHoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHangHoa);
            this.panel1.Location = new System.Drawing.Point(60, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 266);
            this.panel1.TabIndex = 3;
            // 
            // DanhSachHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpNhanVien);
            this.Name = "DanhSachHH";
            this.Size = new System.Drawing.Size(870, 423);
            this.Load += new System.EventHandler(this.DanhSachHH_Load);
            this.grpNhanVien.ResumeLayout(false);
            this.grpNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label lbnDonVi;
        private System.Windows.Forms.Label lblNoiSX;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label lblTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label lblMaHH;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNhomHang;
        private System.Windows.Forms.ComboBox cmbNCC;
        private System.Windows.Forms.Label lblNhomHang;
        private System.Windows.Forms.TextBox txtNoiSX;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
