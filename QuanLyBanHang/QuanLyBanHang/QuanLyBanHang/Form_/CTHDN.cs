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

namespace QuanLyBanHang.Form_
{
    public partial class CTHDN : Form
    {
        CTHDN_Bus hh_b = new CTHDN_Bus();
        private int checkButton = 0;
        DataTable dt = new DataTable();
        public void InDS()
        {
            ChiTietPhieuNhapModel hh = new ChiTietPhieuNhapModel(txtHDN.Text);
            dt = hh_b.XemDS(hh);
            dgvCTHDN.DataSource = dt;
            float tt = 0;
            if (dgvCTHDN.RowCount > 1)
            {
                for (int i = 0; i < dgvCTHDN.RowCount - 1; i++)
                {
                    tt += float.Parse(dgvCTHDN.Rows[i].Cells["ThanhTien"].Value.ToString());
                }
                txtTT.Text = tt.ToString();
            }
            else txtTT.Text = tt.ToString();

        }
        public CTHDN()
        {
            InitializeComponent();
            InDS();
            cmbTenHH.DataSource = hh_b.LayDSHH();
            cmbTenHH.DisplayMember = "TenHH";
            cmbTenHH.ValueMember = "MaHH";
            txtHDN.Enabled = false;
            txtTT.Enabled = false;
            txtSL.Enabled = false;
            txtGia.Enabled = false;
            txtThanhTien.Enabled = false;
        }
        public void formLoad1(HoaDonNhapModel hdn)
        {
            txtHDN.Text = hdn.MaHDN;
            dtpNgayNhap.Value = hdn.NgayNhap;
            cmbNhanVien.Text = hdn.TenNV;
           
            InDS();
        }

        private void dgvCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCTHDN_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvCTHDN.SelectedRows[0];
                cmbTenHH.Text = dr.Cells["TenHH"].Value.ToString();
                txtSL.Text = dr.Cells["SoLuong"].Value.ToString();
                txtGia.Text = dr.Cells["DonGia"].Value.ToString();
                txtThanhTien.Text = dr.Cells["ThanhTien"].Value.ToString();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            cmbTenHH.Enabled = true;
            txtSL.Enabled = true;
            txtGia.Enabled = true;
            txtThanhTien.Enabled = true;
            txtHDN.Enabled = false;
            txtTT.Enabled = false;
            cmbNhanVien.Enabled = false;
            dtpNgayNhap.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            checkButton = 2;
            cmbTenHH.Enabled = false;
            txtSL.Enabled = true;
            txtGia.Enabled = true;
            txtThanhTien.Enabled = true;
            txtHDN.Enabled = false;
            txtTT.Enabled = false;
            cmbNhanVien.Enabled = false;
            dtpNgayNhap.Enabled = false;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            checkButton = 3;

            cmbTenHH.Enabled = false;
            txtSL.Enabled = false;
            txtGia.Enabled = false;
            txtThanhTien.Enabled = false;
            txtHDN.Enabled = false;
            txtTT.Enabled = false;
            cmbNhanVien.Enabled = false;
            dtpNgayNhap.Enabled = false;

            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cmbTenHH.SelectedValue = "";
            txtSL.Clear();
            txtGia.Clear();
            txtThanhTien.Clear();

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            cmbTenHH.Enabled = false;
            txtSL.Enabled = false;
            txtGia.Enabled = false;
            txtThanhTien.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                try
                {
                    ChiTietPhieuNhapModel hh = new ChiTietPhieuNhapModel(txtHDN.Text, cmbTenHH.SelectedValue.ToString(), cmbTenHH.Text, txtSL.Text, txtGia.Text, txtThanhTien.Text);
                    hh_b.ThemCTPN(hh);

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
                    ChiTietPhieuNhapModel hh = new ChiTietPhieuNhapModel(txtHDN.Text, cmbTenHH.SelectedValue.ToString(), cmbTenHH.Text, txtSL.Text, txtGia.Text, txtThanhTien.Text);
                    //(txtMaHDB.Text, dtpNgayBan.Value, cmbNV.SelectedValue.ToString());
                    hh_b.SuaCTPN(hh);
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
                    ChiTietPhieuNhapModel hh = new ChiTietPhieuNhapModel(txtHDN.Text, cmbTenHH.SelectedValue.ToString());
                    hh_b.XoaCTPN(hh);
                    MessageBox.Show("Xóa thành công!");
                    InDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            //txtMaHDB.Clear();
            cmbTenHH.SelectedValue = "";
            txtSL.Clear();
            txtGia.Clear();
            txtThanhTien.Clear();


            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            cmbTenHH.Enabled = false;
            txtSL.Enabled = false;
            txtGia.Enabled = false;
            txtThanhTien.Enabled = false;
            checkButton = 0;
        }
        
        private void txtThanhTien_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSL.Text != "" && txtGia.Text != "")
            {
                txtThanhTien.Text = (int.Parse(txtGia.Text) * int.Parse(txtSL.Text)).ToString();
            }
            else
                txtThanhTien.Text = "0";
        }
    }
}
