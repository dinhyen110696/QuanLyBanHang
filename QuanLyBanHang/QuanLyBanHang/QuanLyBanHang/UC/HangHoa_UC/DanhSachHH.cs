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

namespace QuanLyBanHang.UC.HangHoa_UC
{
    public partial class DanhSachHH : UserControl
    {
        HangHoa_Bus hh_b = new HangHoa_Bus();
        private int checkButton=0;
        DataTable dt = new DataTable();
        public void InDS()
        {
            dt = hh_b.XemDS();
            dgvHangHoa.DataSource = dt;
        }
        public DanhSachHH()
        {
            InitializeComponent();
           
            InDS();

            cmbNCC.DataSource = hh_b.LayDSNCC();
            cmbNCC.DisplayMember = "TenNCC";
            cmbNCC.ValueMember = "MaNCC";
            cmbNhomHang.DataSource = hh_b.LayDSNhomhang();
            cmbNhomHang.DisplayMember = "TenNhom";
           
            cmbNhomHang.ValueMember = "MaNhom";
        }

        private void lblNoiSX_Click(object sender, EventArgs e)
        {

        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNS_NV_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbnDonVi_Click(object sender, EventArgs e)
        {

        }

        private void txtDonVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvHangHoa.SelectedRows[0];
                txtMaHH.Text = dr.Cells["MaHH"].Value.ToString();
                txtTenHH.Text = dr.Cells["TenHH"].Value.ToString();
                txtDonVi.Text = dr.Cells["DonVi"].Value.ToString();
                txtNoiSX.Text = dr.Cells["NoiSX"].Value.ToString();
                txtDonGia.Text = dr.Cells["DonGia"].Value.ToString();
                cmbNhomHang.Text = dr.Cells["TenNhom"].Value.ToString();
                cmbNCC.Text = dr.Cells["TenNCC"].Value.ToString();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaHH.Enabled = true;
            txtTenHH.Enabled = true;
            txtNoiSX.Enabled = true;
            txtDonVi.Enabled = true;
            txtDonGia.Enabled = true;
            cmbNCC.Enabled = true;
            cmbNhomHang.Enabled = true;


            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            checkButton = 2;
            txtTenHH.Enabled = true;
            txtNoiSX.Enabled = true;
            txtDonVi.Enabled = true;
            txtDonGia.Enabled = true;
            cmbNCC.Enabled = true;
            cmbNhomHang.Enabled = true;



            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            checkButton = 3;

            txtTenHH.Enabled = false;
            txtNoiSX.Enabled = false;
            txtMaHH.Enabled = false;
            txtDonVi.Enabled = false;
            txtDonGia.Enabled = false;
            cmbNCC.Enabled = false;
            cmbNhomHang.Enabled = false;



            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenHH.Clear();
            txtNoiSX.Clear();
            txtMaHH.Clear();
            txtDonVi.Clear();
            txtDonGia.Clear();

            cmbNhomHang.SelectedValue = "";
            cmbNCC.SelectedValue = "";


            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTenHH.Enabled = false;
            txtNoiSX.Enabled = false;
            txtMaHH.Enabled = false;
            txtDonVi.Enabled = false;
            txtDonGia.Enabled = false;
            cmbNCC.Enabled = false;
            cmbNhomHang.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                try
                {
                    HangHoaModel hh = new HangHoaModel(txtMaHH.Text, txtTenHH.Text, txtNoiSX.Text, txtDonVi.Text, 
                                                       cmbNCC.SelectedValue.ToString(), cmbNhomHang.SelectedValue.ToString(), txtDonGia.Text);
                    hh_b.ThemHH(hh);
                    
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
                    HangHoaModel hh = new HangHoaModel(txtMaHH.Text, txtTenHH.Text, txtNoiSX.Text, txtDonVi.Text, cmbNCC.SelectedValue.ToString(), 
                                                        cmbNhomHang.SelectedValue.ToString(), txtDonGia.Text);
                    hh_b.SuaHH(hh);
                    
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
                    HangHoaModel hh = new HangHoaModel(txtMaHH.Text, txtTenHH.Text, txtNoiSX.Text, txtDonVi.Text, cmbNCC.SelectedValue.ToString(), cmbNhomHang.SelectedValue.ToString(),txtDonGia.Text);
                    hh_b.XoaHH(hh);
                    
                    MessageBox.Show("Xóa thành công!");
                    InDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtTenHH.Clear();
            txtNoiSX.Clear();
            txtMaHH.Clear();
            txtDonVi.Clear();

            cmbNhomHang.SelectedValue = "";
            cmbNCC.SelectedValue = "";


            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTenHH.Enabled = false;
            txtNoiSX.Enabled = false;
            txtMaHH.Enabled = false;
            txtDonVi.Enabled = false;
            txtDonGia.Enabled = false;
            cmbNCC.Enabled = false;
            cmbNhomHang.Enabled = false;
            checkButton = 0;
        }

        private void DanhSachHH_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("TenHH like '%{0}%'", txtTimKiem.Text);
            dt.DefaultView.RowFilter = str;
            if (dgvHangHoa.SelectedRows.Count == 0)
            {
                string str1 = string.Format("MaHH like '%{0}%'", txtTimKiem.Text);
                dt.DefaultView.RowFilter = str1;
            }

        }
    }
}
