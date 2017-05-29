using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Data.SqlClient;
using Model;

namespace QuanLyBanHang.UC.NCC_UC
{
    public partial class DanhSachNCC : UserControl
    {
         NCC_Bus ncc_b = new NCC_Bus();
        private int checkButton = 0;
        DataTable dt = new DataTable();
        public void InDanhSach()
        {
            dt = ncc_b.XemDS();
            dgvNCC.DataSource = dt;
        }
        public DanhSachNCC()
        {
            InitializeComponent();
            InDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
       

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
           

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
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
                    NhaCungCapModel ncc = new NhaCungCapModel(txtMaNCC.Text, txtTenNCC.Text,txtSDT.Text, txtDiaChi.Text);
                    ncc_b.ThemNCC(ncc);
                    MessageBox.Show("Thêm mới nhà cung cấp thành công ");
                    InDanhSach();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (checkButton == 2)
            {
                try
                {
                    NhaCungCapModel ncc = new NhaCungCapModel(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
                    ncc_b.SuaNCC(ncc);
                    MessageBox.Show("Sửa thành công! ");
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
                    NhaCungCapModel ncc = new NhaCungCapModel(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        ncc_b.XoaNCC(ncc);
                        MessageBox.Show("Xóa nhà cung cấp thành công ");
                        InDanhSach();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
           
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void DanhSachNCC_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow dr = dgvNCC.SelectedRows[0];
                txtMaNCC.Text = dr.Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = dr.Cells["TenNCC"].Value.ToString();
               
                txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dr.Cells["SDT"].Value.ToString();
               
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //txtTimKiem.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("TenNCC like '%{0}%'", txtTimKiem.Text);
            dt.DefaultView.RowFilter = str;
            if (dgvNCC.SelectedRows.Count == 0)
            {
                string str1 = string.Format("MaNCC like '%{0}%'", txtTimKiem.Text);
                dt.DefaultView.RowFilter = str1;
            }
        }

        
    }
}
