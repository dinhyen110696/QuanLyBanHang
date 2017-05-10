namespace QuanLyBanHang.UC.TrangChu_UC
{
    partial class HeThongUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThongUC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangKys = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btnDangKys);
            this.groupBox1.Controls.Add(this.btnThongTin);
            this.groupBox1.Location = new System.Drawing.Point(0, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 571);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnDangKys
            // 
            this.btnDangKys.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangKys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangKys.BackgroundImage")));
            this.btnDangKys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangKys.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangKys.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDangKys.Location = new System.Drawing.Point(31, 218);
            this.btnDangKys.Name = "btnDangKys";
            this.btnDangKys.Size = new System.Drawing.Size(180, 162);
            this.btnDangKys.TabIndex = 7;
            this.btnDangKys.Text = "Đăng ký";
            this.btnDangKys.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangKys.UseVisualStyleBackColor = false;
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.LightGreen;
            this.btnThongTin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongTin.BackgroundImage")));
            this.btnThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThongTin.Location = new System.Drawing.Point(31, 59);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(180, 142);
            this.btnThongTin.TabIndex = 6;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongTin.UseVisualStyleBackColor = false;
            // 
            // HeThongUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.groupBox1);
            this.Name = "HeThongUC";
            this.Size = new System.Drawing.Size(246, 588);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnDangKys;
    }
}
