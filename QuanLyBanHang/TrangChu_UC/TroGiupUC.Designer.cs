namespace QuanLyBanHang.UC.TrangChu_UC
{
    partial class TroGiupUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TroGiupUC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCauHoi = new System.Windows.Forms.Button();
            this.btnLienHe = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btnCauHoi);
            this.groupBox1.Controls.Add(this.btnLienHe);
            this.groupBox1.Controls.Add(this.btnHuongDan);
            this.groupBox1.Location = new System.Drawing.Point(0, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 571);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.BackColor = System.Drawing.Color.Plum;
            this.btnCauHoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCauHoi.BackgroundImage")));
            this.btnCauHoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCauHoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauHoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauHoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCauHoi.Location = new System.Drawing.Point(32, 355);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(184, 138);
            this.btnCauHoi.TabIndex = 8;
            this.btnCauHoi.Text = "Câu hỏi ";
            this.btnCauHoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCauHoi.UseVisualStyleBackColor = false;
            // 
            // btnLienHe
            // 
            this.btnLienHe.BackColor = System.Drawing.Color.Plum;
            this.btnLienHe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLienHe.BackgroundImage")));
            this.btnLienHe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLienHe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLienHe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLienHe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLienHe.Location = new System.Drawing.Point(32, 207);
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.Size = new System.Drawing.Size(184, 142);
            this.btnLienHe.TabIndex = 7;
            this.btnLienHe.Text = "Liên hệ";
            this.btnLienHe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLienHe.UseVisualStyleBackColor = false;
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.BackColor = System.Drawing.Color.Plum;
            this.btnHuongDan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.BackgroundImage")));
            this.btnHuongDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuongDan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuongDan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHuongDan.Location = new System.Drawing.Point(32, 59);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(184, 142);
            this.btnHuongDan.TabIndex = 6;
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuongDan.UseVisualStyleBackColor = false;
            // 
            // TroGiupUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.groupBox1);
            this.Name = "TroGiupUC";
            this.Size = new System.Drawing.Size(246, 588);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnCauHoi;
        private System.Windows.Forms.Button btnLienHe;
    }
}
