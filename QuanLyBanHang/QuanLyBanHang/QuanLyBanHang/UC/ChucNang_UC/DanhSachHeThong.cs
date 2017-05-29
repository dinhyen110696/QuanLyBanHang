using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Form_;
using Model;
namespace QuanLyBanHang.UC.ChucNang_UC
{
    public partial class DanhSachHeThong : UserControl
    {
        public DanhSachHeThong()
        {
            InitializeComponent();
        }
        public void SetLabel(TaiKhoanModel tk)
        {
            lblHoTen.Text = tk.HoTen;
            lblDiaChi.Text = tk.DiaChi;
            lblEmail.Text = tk.Email;
            lblNgaySinh.Text = tk.NgaySinh.ToShortDateString();
            lblSDT.Text = tk.SDT;
            lblTenDN.Text = tk.Name;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlKho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabCauHoi_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormTaiKhoan frmTk = new FormTaiKhoan();
            frmTk.ShowDialog();
        }

        private void DanhSachHeThong_Load(object sender, EventArgs e)
        {

        }
    }
}
