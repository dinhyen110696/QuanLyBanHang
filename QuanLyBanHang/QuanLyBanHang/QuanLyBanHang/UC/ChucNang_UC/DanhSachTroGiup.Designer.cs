namespace QuanLyBanHang.UC.ChucNang_UC
{
    partial class DanhSachTroGiup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachTroGiup));
            this.TabHuongDan = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlHangHoa = new System.Windows.Forms.Panel();
            this.tabControlChucNang = new System.Windows.Forms.TabControl();
            this.TabHuongDan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHangHoa.SuspendLayout();
            this.tabControlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabHuongDan
            // 
            this.TabHuongDan.BackColor = System.Drawing.Color.Azure;
            this.TabHuongDan.Controls.Add(this.panel4);
            this.TabHuongDan.Controls.Add(this.pnlHangHoa);
            this.TabHuongDan.Location = new System.Drawing.Point(4, 34);
            this.TabHuongDan.Name = "TabHuongDan";
            this.TabHuongDan.Padding = new System.Windows.Forms.Padding(3);
            this.TabHuongDan.Size = new System.Drawing.Size(1284, 596);
            this.TabHuongDan.TabIndex = 1;
            this.TabHuongDan.Text = "HƯỚNG DẪN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 528);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1043, 28);
            this.panel4.TabIndex = 2;
            // 
            // pnlHangHoa
            // 
            this.pnlHangHoa.AutoScroll = true;
            this.pnlHangHoa.Controls.Add(this.pictureBox1);
            this.pnlHangHoa.Location = new System.Drawing.Point(3, 33);
            this.pnlHangHoa.Name = "pnlHangHoa";
            this.pnlHangHoa.Size = new System.Drawing.Size(1049, 500);
            this.pnlHangHoa.TabIndex = 1;
            // 
            // tabControlChucNang
            // 
            this.tabControlChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlChucNang.Controls.Add(this.TabHuongDan);
            this.tabControlChucNang.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlChucNang.Location = new System.Drawing.Point(0, -4);
            this.tabControlChucNang.Multiline = true;
            this.tabControlChucNang.Name = "tabControlChucNang";
            this.tabControlChucNang.Padding = new System.Drawing.Point(25, 8);
            this.tabControlChucNang.SelectedIndex = 0;
            this.tabControlChucNang.Size = new System.Drawing.Size(1292, 634);
            this.tabControlChucNang.TabIndex = 1;
            // 
            // DanhSachTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlChucNang);
            this.Name = "DanhSachTroGiup";
            this.Size = new System.Drawing.Size(1292, 626);
            this.TabHuongDan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHangHoa.ResumeLayout(false);
            this.tabControlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage TabHuongDan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlHangHoa;
        private System.Windows.Forms.TabControl tabControlChucNang;
    }
}
