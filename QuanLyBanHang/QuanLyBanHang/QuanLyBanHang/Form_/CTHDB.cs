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
    public partial class CTHDB : Form
    {
         CTHDB_Bus hh_b = new CTHDB_Bus();
        private int checkButton = 0;
        DataTable dt = new DataTable();

        public void InDS()
        {
            ChiTietPhieuBanModel hh = new ChiTietPhieuBanModel(txtHDB.Text);
            dt = hh_b.XemDS(hh);
            dgvCTHDB.DataSource = dt;

            float tt = 0;
            if (dgvCTHDB.RowCount > 1)
            {
                for (int i = 0; i < dgvCTHDB.RowCount - 1; i++)
                {
                    tt += float.Parse(dgvCTHDB.Rows[i].Cells["ThanhTien"].Value.ToString());
                }
                txtTT.Text = tt.ToString();
            }
            else txtTT.Text = tt.ToString();

        }
        public CTHDB()
        {
            InitializeComponent();
            InDS();
            cmbTenHH.DataSource = hh_b.LayDSHH();
            cmbTenHH.DisplayMember = "TenHH";
            cmbTenHH.ValueMember = "MaHH";
            
            txtHDB.Enabled = false;
            txtTT.Enabled = false;
            txtSL.Enabled = false;
            txtGia.Enabled = false;
            txtThanhTien.Enabled = false;
           
            
        }
        public void formLoad(HoaDonBanModel hdb)
        {
            txtHDB.Text = hdb.MaHDB;
            dtpNgayBan.Value = hdb.NgayBan;
            cmbNhanVien.Text = hdb.TenNV;
            txtTT.Text = hdb.tongtien;
            InDS();
        }

        private void dgvCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCTHDB_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvCTHDB.SelectedRows[0];
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
            txtGia.Enabled = false;
            txtThanhTien.Enabled = true;
            txtHDB.Enabled = false;
            txtTT.Enabled = false;
            cmbNhanVien.Enabled = false;
            dtpNgayBan.Enabled = false;

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
            txtHDB.Enabled = false;
            txtTT.Enabled = false;
            cmbNhanVien.Enabled = false;
            dtpNgayBan.Enabled = false;

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
            txtHDB.Enabled = false;
            txtTT.Enabled = false;
            cmbNhanVien.Enabled = false;
            dtpNgayBan.Enabled = false;

            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                try
                {
                    ChiTietPhieuBanModel hh = new ChiTietPhieuBanModel(txtHDB.Text, cmbTenHH.SelectedValue.ToString(), cmbTenHH.Text,txtSL.Text, txtGia.Text, txtThanhTien.Text);
                    hh_b.ThemCTPB(hh);

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
                    ChiTietPhieuBanModel hh = new ChiTietPhieuBanModel(txtHDB.Text, cmbTenHH.SelectedValue.ToString(),cmbTenHH.Text, txtSL.Text, txtGia.Text, txtThanhTien.Text);
                        //(txtMaHDB.Text, dtpNgayBan.Value, cmbNV.SelectedValue.ToString());
                    hh_b.SuaCTPB(hh);
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
                    ChiTietPhieuBanModel hh = new ChiTietPhieuBanModel(txtHDB.Text, cmbTenHH.SelectedValue.ToString());
                    hh_b.XoaCTPB(hh);
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
      

        private void txtGia_Click(object sender, EventArgs e)
        {
            
        }

        private void txtGia_MouseClick(object sender, MouseEventArgs e)
        {
           
           
        }   
       
     
        private void cmbTenHH_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           

        }

        private void txtSL_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        { 

        }

        private void txtThanhTien_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSL.Text != "")
            {
               
                txtThanhTien.Text = (int.Parse(txtGia.Text) * int.Parse(txtSL.Text)).ToString();

            }
            else
                txtThanhTien.Text = "0";

        }
    }
}
