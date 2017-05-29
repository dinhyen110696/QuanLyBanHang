using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using Model;

namespace QuanLyBanHang.UC.KhachHang_UC
{
    public partial class DS_KH : UserControl
    {
        KhachHang_Bus kh_b = new KhachHang_Bus();
        private int checkButton = 0;
        DataTable dt = new DataTable();

        public void InDanhSach()
        {
            dt = kh_b.XemDS();
            dgvKhachHang.DataSource = dt;
        }
        public DS_KH()
        {
            InitializeComponent();
            InDanhSach();
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvKhachHang.SelectedRows[0];
                txtMaKH.Text = dr.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = dr.Cells["TenKH"].Value.ToString();
                txtSDT.Text = dr.Cells["SDT"].Value.ToString();
                dateTimePickerNS_KH.Text = dr.Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
                txtDTL.Text = dr.Cells["DiemTL"].Value.ToString();
               
               
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            dateTimePickerNS_KH.Enabled = true;
            txtDTL.Enabled = true;

            btnThem.Enabled = false;
            
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            dateTimePickerNS_KH.Enabled = false;
            

            btnThem.Enabled = false;
          
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            dateTimePickerNS_KH.Enabled = false;
            

            btnThem.Enabled = true;
            
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                try
                {
                   
                    KhachHangModel kh = new KhachHangModel(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, dateTimePickerNS_KH.Value,txtDTL.Text);
                    kh_b.ThemKH(kh);
                    MessageBox.Show("Thêm mới nhân viên thành công ");
                    InDanhSach();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
            else if (checkButton == 3)
            {
                try
                {
                    KhachHangModel kh = new KhachHangModel();
                    kh.MaKH = txtMaKH.Text;
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        kh_b.XoaKH(kh);
                        MessageBox.Show("Xóa nhân viên thành công ");
                        InDanhSach();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            dateTimePickerNS_KH.Enabled = false;
            txtDTL.Enabled = false;

            btnThem.Enabled = true;
          
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("TenKH like '%{0}%'", txtTimKiem.Text);
            dt.DefaultView.RowFilter = str;
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                string str1 = string.Format("MaKH like '%{0}%'", txtTimKiem.Text);
                dt.DefaultView.RowFilter = str1;
            }
        }
    }
}
