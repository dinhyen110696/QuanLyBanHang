using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.UC.ChucNang_UC
{
    public partial class DanhSachTroGiup : UserControl
    {
        public DanhSachTroGiup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // MessageBox.Show("Nhà cung cấp chưa có trong dữ liệu trước đó. Trước tiên, hãy vào NHÀ CUNG CẤP để thêm nhà cung cấp đó vào");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Nhân viên thêm mới cần có mã không trùng với các nhân viên trước đó");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // MessageBox.Show("Nhóm hàng của bạn không tồn tại. Trước tiên, hãy vào NHÓM HÀNG để thêm nhóm hàng đó vào");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Có thể kho hàng của bạn chưa cập nhật nhân viên quản lý, hoặc nhân viên này mới đến chưa có trong dữ liệu trước đó. Hay vào NHÂN VIÊN xem nhân viên đó có tồn tại không, nếu không hãy tiến hành thêm mới nhân viên đó vào, nếu không vào KHO và sửa nhân viên quản lý!");
        }
    }
}
