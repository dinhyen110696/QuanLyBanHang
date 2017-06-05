using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Model;

using System.Data.SqlClient;

namespace QuanLyBanHang.Form_
{
    public partial class FormDangNhap : Form
    {
        TaiKhoan_Bus tk_b = new TaiKhoan_Bus();
        TaiKhoanModel tk ;
        public string Name { get; set; }
        public FormDangNhap()
        {
            InitializeComponent();
            lblQLSV.BackColor = Color.Transparent;
            lblTenTruyCap.BackColor = Color.Transparent;
            lblMatKhau.BackColor = Color.Transparent;
            Name = "";

        }
        public TaiKhoanModel LayTTDN()
        {
            TaiKhoanModel tk = new TaiKhoanModel();
            tk.Name = txtTenTruyCap.Text;
            tk.Pass = txtMatKhau.Text;
            string[] lst = tk_b.LayDSTK(tk);
            tk.HoTen =lst[2];
            tk.Email =lst[5];
            tk.DiaChi =lst[3];
            tk.NgaySinh =Convert.ToDateTime(lst[4]) ;
            tk.SDT =lst[5];
            
            return tk;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            tk = new TaiKhoanModel();
            tk.Name = txtTenTruyCap.Text;
            tk.Pass = txtMatKhau.Text;



            dt = tk_b.LayTK(tk);
            //lấy dữ liệu bảng NhanVien


            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Sai thông tin đăng nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);         

            }
            else
            {
                Name = txtTenTruyCap.Text;
                this.Close();

            }

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        
    }
}
