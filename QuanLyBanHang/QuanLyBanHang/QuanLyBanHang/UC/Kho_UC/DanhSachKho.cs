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
using Model;
using System.Data.SqlClient;

namespace QuanLyBanHang.UC.Kho_UC
{
    public partial class DanhSachKho : UserControl
    {
        Kho_Bus hh_b = new Kho_Bus();
        private int checkButton = 0;
        DataTable dt = new DataTable();
        public void InDS()
        {
            dt = hh_b.XemDS();
            dgvKho.DataSource = dt;
        }
        public DanhSachKho()
        {
            InitializeComponent();
            InDS();
            cmbNV.DataSource = hh_b.LayDSNV();
            cmbNV.DisplayMember = "TenNV";
            cmbNV.ValueMember = "MaNV";
        }

        private void lblNoiSX_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiSX_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKho_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvKho.SelectedRows[0];
                txtMaKho.Text = dr.Cells["MaKho"].Value.ToString();
                txtTenKho.Text = dr.Cells["TenKho"].Value.ToString();
                txtViTri.Text = dr.Cells["ViTri"].Value.ToString();               
                cmbNV.Text = dr.Cells["TenNV"].Value.ToString();
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaKho.Enabled = true;
            txtTenKho.Enabled = true;
            txtViTri.Enabled = true;
            cmbNV.Enabled = true;


            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            checkButton = 2;
            txtMaKho.Enabled = false;
            txtTenKho.Enabled = true;
            txtViTri.Enabled = true;
            cmbNV.Enabled = true;



            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            checkButton = 3;

            txtMaKho.Enabled = false;
            txtTenKho.Enabled = false;
            txtViTri.Enabled = false;
            cmbNV.Enabled = false;



            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtViTri.Clear();
            txtTenKho.Clear();
            txtMaKho.Clear();
            cmbNV.SelectedValue = "";

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaKho.Enabled = false;
            txtTenKho.Enabled = false;
            txtViTri.Enabled = false;
            cmbNV.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                try
                {
                    KhoModel hh = new KhoModel(txtMaKho.Text, txtTenKho.Text, txtViTri.Text,cmbNV.SelectedValue.ToString());
                    hh_b.ThemKho(hh);
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
                    KhoModel hh = new KhoModel(txtMaKho.Text, txtTenKho.Text, txtViTri.Text, cmbNV.SelectedValue.ToString());
                    hh_b.SuaKho(hh);
                    
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
                    KhoModel hh = new KhoModel(txtMaKho.Text, txtTenKho.Text, txtViTri.Text, cmbNV.SelectedValue.ToString());
                    hh_b.XoaKho(hh);
                    
                    MessageBox.Show("Xóa thành công!");
                    InDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtMaKho.Clear();
            txtTenKho.Clear();
            txtViTri.Clear();
            cmbNV.SelectedValue = "";


            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaKho.Enabled = false;
            txtTenKho.Enabled = false;
            txtViTri.Enabled = false;
            cmbNV.Enabled = false;
            checkButton = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("TenKho like '%{0}%'", txtTimKiem.Text);
            dt.DefaultView.RowFilter = str;
            if (dgvKho.SelectedRows.Count == 0)
            {
                string str1 = string.Format("MaKho like '%{0}%'", txtTimKiem.Text);
                dt.DefaultView.RowFilter = str1;
            }

        }
    }
}
