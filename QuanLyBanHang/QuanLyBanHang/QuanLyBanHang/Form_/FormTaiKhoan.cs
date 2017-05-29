using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using Model;
namespace QuanLyBanHang.Form_
{
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa điền tên đăng nhập");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Bạn chưa điền Mật khẩu");
            }
            else if (txtPass2.Text == "")
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu");
            }
            else if (txtPass2.Text != txtPass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không chính xác");
            }
            else
            {
                try
                {
                    TaiKhoan_Bus tk_b = new TaiKhoan_Bus();
                    TaiKhoanModel tk = new TaiKhoanModel(txtName.Text, txtPass.Text, txtHoTen.Text, txtDiaChi.Text, dateTimePicker1.Value, txtEmail.Text, txtSDT.Text);
                    tk_b.DangKyTK(tk);
                    MessageBox.Show("Đăng ký thành công!");
                }
                
                catch(SqlException ex)
                {
                    MessageBox.Show("Tài khoản này đã tồn tại! Chọn tên đăng nhập khác !");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtName.Text = ""; txtPass.Text = ""; txtHoTen.Text = ""; txtDiaChi.Text = ""; txtEmail.Text = ""; txtSDT.Text = "";txtPass2.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
