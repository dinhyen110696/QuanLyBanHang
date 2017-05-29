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
using Model;
using QuanLyBanHang.Form_;
using BusinessLayer;

namespace QuanLyBanHang.UC.HoaDonBan_UC
{
    public partial class DanhSachHDN : UserControl
    {
        HoaDonNhap_Bus hh_b = new HoaDonNhap_Bus();
        private int checkButton = 0;
        DataTable dt = new DataTable();
        public void InDS()
        {
            dt = hh_b.XemDS();
            dgvHDN.DataSource = dt;
        }
        public DanhSachHDN()
        {
            InitializeComponent();
            InDS();
            cmbNV.DataSource = hh_b.LayDSNV();
            cmbNV.DisplayMember = "TenNV";
            cmbNV.ValueMember = "MaNV";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaHDN.Enabled = true;
            dtpNgayNhap.Enabled = true;
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
            txtMaHDN.Enabled = false;
            dtpNgayNhap.Enabled = true;
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

            txtMaHDN.Enabled = false;
            dtpNgayNhap.Enabled = false;
            cmbNV.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHDN.Clear();
            cmbNV.SelectedValue = "";

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaHDN.Enabled = false;
            dtpNgayNhap.Enabled = false;
            cmbNV.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                try
                {
                    HoaDonNhapModel hh = new HoaDonNhapModel(txtMaHDN.Text, dtpNgayNhap.Value, cmbNV.SelectedValue.ToString());
                    hh_b.ThemHDN(hh);
                    MessageBox.Show("Thêm mới thành công!");
                    
                    HoaDonNhapModel CT = new HoaDonNhapModel(txtMaHDN.Text, dtpNgayNhap.Value, cmbNV.SelectedValue.ToString(), cmbNV.Text);
                    CTHDN ds = new CTHDN();
                    ds.formLoad1(CT);
                    ds.Show();
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
                    HoaDonNhapModel hh = new HoaDonNhapModel(txtMaHDN.Text, dtpNgayNhap.Value, cmbNV.SelectedValue.ToString(),cmbNV.Text);
                    hh_b.SuaHDN(hh);
           
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
                    HoaDonNhapModel hh = new HoaDonNhapModel(txtMaHDN.Text);
                    hh_b.XoaHDN(hh);
                   
                    MessageBox.Show("Xóa thành công!");
                    InDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtMaHDN.Clear();
            cmbNV.SelectedValue = "";


            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaHDN.Enabled = false;
            dtpNgayNhap.Enabled = false;
            cmbNV.Enabled = false;
            checkButton = 0;
        }

        private void dgvHDN_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvHDN.SelectedRows[0];
                txtMaHDN.Text = dr.Cells["MaHDN"].Value.ToString();
                dtpNgayNhap.Text = dr.Cells["NgayNhap"].Value.ToString();
                cmbNV.Text = dr.Cells["TenNV"].Value.ToString();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("MaHDN like '%{0}%'", txtTimKiem.Text);
            dt.DefaultView.RowFilter = str;
            if (dgvHDN.SelectedRows.Count == 0)
            {
                string str1 = string.Format("TenNV  like '%{0}%'", txtTimKiem.Text);
                dt.DefaultView.RowFilter = str1;
            }
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Chọn một hóa đơn trước khi xem chi tiết !");
            }
            else
            {

                HoaDonNhapModel hh = new HoaDonNhapModel(txtMaHDN.Text, dtpNgayNhap.Value, cmbNV.SelectedValue.ToString(), cmbNV.Text);

                CTHDN ds = new CTHDN();
                ds.formLoad1(hh);
                ds.Show();
            }
        }
    }
}
