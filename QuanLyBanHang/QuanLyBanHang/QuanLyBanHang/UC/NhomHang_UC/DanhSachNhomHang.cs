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
using businessLayer;
using Model;
using BusinessLayer;

namespace QuanLyBanHang.UC.NhomHang_UC
{
    public partial class DanhSachNhomHang : UserControl
    {
        NhomHang_Bus hh_b = new NhomHang_Bus();
        private int checkButton = 0;
        DataTable dt = new DataTable();

        public void InDS()
        {
            dt = hh_b.XemDS();
            dgvNhomHang.DataSource = dt;
        }
        public DanhSachNhomHang()
        {
            InitializeComponent();
            InDS();
            cmbKho.DataSource = hh_b.LayDSKho();
            cmbKho.DisplayMember = "TenKho";
            cmbKho.ValueMember = "MaKho";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaNhom.Enabled = true;
            txtTenNhom.Enabled = true;
            cmbKho.Enabled = true;


            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            checkButton = 2;
            txtMaNhom.Enabled = false;
            txtTenNhom.Enabled = true;
            cmbKho.Enabled = true;



            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            checkButton = 3;

            txtMaNhom.Enabled = false;
            txtTenNhom.Enabled = false;
            cmbKho.Enabled = false;



            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNhom.Clear();
            txtTenNhom.Clear();
            cmbKho.SelectedValue = "";

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaNhom.Enabled = false;
            txtTenNhom.Enabled = false;
            cmbKho.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                try
                {
                    NhomHangModel hh = new NhomHangModel(txtMaNhom.Text, txtTenNhom.Text, cmbKho.SelectedValue.ToString());
                    hh_b.ThemNH(hh);
                    
                    MessageBox.Show("Thêm mới thành công!");
                    InDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (checkButton == 2)
            {
                try
                {
                    NhomHangModel hh = new NhomHangModel(txtMaNhom.Text, txtTenNhom.Text,  cmbKho.SelectedValue.ToString());
                    hh_b.SuaNH(hh);
                    
                    MessageBox.Show("Sửa thành công!");
                    InDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (checkButton == 3)
            {
                try
                {
                    NhomHangModel hh = new NhomHangModel(txtMaNhom.Text, txtTenNhom.Text, cmbKho.SelectedValue.ToString());
                    hh_b.XoaNH(hh);
                    MessageBox.Show("Xóa thành công!");
                    InDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtMaNhom.Clear();
            txtTenNhom.Clear();
            cmbKho.SelectedValue = "";


            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaNhom.Enabled = false;
            txtTenNhom.Enabled = false;
            cmbKho.Enabled = false;
            checkButton = 0;
        }

        private void dgvNhomHang_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvNhomHang.SelectedRows[0];
                txtMaNhom.Text = dr.Cells["MaNhom"].Value.ToString();
                txtTenNhom.Text = dr.Cells["TenNhom"].Value.ToString();
                cmbKho.Text = dr.Cells["TenKho"].Value.ToString();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("TenNhom like '%{0}%'", txtTimKiem.Text);
            dt.DefaultView.RowFilter = str;
            if (dgvNhomHang.SelectedRows.Count == 0)
            {
                string str1 = string.Format("MaNhom like '%{0}%'", txtTimKiem.Text);
                dt.DefaultView.RowFilter = str1;
            }
        }
    }
}
