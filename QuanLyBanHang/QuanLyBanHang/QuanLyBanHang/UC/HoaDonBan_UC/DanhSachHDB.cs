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
    public partial class DanhSachHDB : UserControl
    {
        HoaDonBan_Bus hh_b = new HoaDonBan_Bus();
        private int checkButton = 0;
        DataTable dt = new DataTable();
        public void InDS()
        {
            dt = hh_b.XemDS();
            dgvHDB.DataSource = dt;
        }
        public DanhSachHDB()
        {

            InitializeComponent();
            InDS();
            cmbNV.DataSource = hh_b.LayDSNV();
            cmbNV.DisplayMember = "TenNV";
            cmbNV.ValueMember = "MaNV";

            cmbKH.DataSource = hh_b.LayDSKH();
            cmbKH.DisplayMember = "TenKH";
            cmbKH.ValueMember = "MaKH";

            //HoaDonBanModel hdb = new HoaDonBanModel(txtMaHDB.Text);
            //txtTTien.Text = hh_b.TongTien(txtMaHDB.Text);
        }
        private void dgvHDB_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow dr = dgvHDB.SelectedRows[0];
                txtMaHDB.Text = dr.Cells["MaHDB"].Value.ToString();
                dtpNgayBan.Text = dr.Cells["NgayBan"].Value.ToString();
                cmbNV.Text = dr.Cells["TenNV"].Value.ToString();
                cmbKH.Text = dr.Cells["TenKH"].Value.ToString();

                //txtTTien.Text = dr.Cells["TongTien"].Value.ToString();
                //string mahh = txtMaHDB.Text.ToString().Trim();
                //HoaDonBanModel hh = new HoaDonBanModel(mahh);
                //DataTable dt_ = hh_b.TongTien(hh);
                //txtTTien.Text = dt_.Rows[0]["TongTien"].ToString();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaHDB.Enabled = true;
            dtpNgayBan.Enabled = true;
            cmbNV.Enabled = true;
            cmbKH.Enabled = true;

            // txtTTien.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            checkButton = 2;
            txtMaHDB.Enabled = false;
            dtpNgayBan.Enabled = true;
            cmbNV.Enabled = true;
            cmbKH.Enabled = true;
            //txtTTien.Enabled = false;


            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            checkButton = 3;

            txtMaHDB.Enabled = false;
            dtpNgayBan.Enabled = false;
            cmbNV.Enabled = false;
            cmbKH.Enabled = false;

            // txtTTien.Enabled = false;


            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHDB.Clear();
            cmbNV.SelectedValue = "";
            //txtTTien.Clear();

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaHDB.Enabled = false;
            dtpNgayBan.Enabled = false;
            cmbNV.Enabled = false;
            cmbKH.Enabled = false;

            //txtTTien.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            //CTHDB ds = new CTHDB();
            //ds.formLoad(CT);
            //ds.Show();
            if (checkButton == 1)
            {
                try
                {
                    HoaDonBanModel hh = new HoaDonBanModel(txtMaHDB.Text, dtpNgayBan.Value, cmbNV.SelectedValue.ToString(), cmbKH.SelectedValue.ToString());
                    hh_b.ThemHDB(hh);
                    MessageBox.Show("Thêm mới thành công!");

                    HoaDonBanModel CT = new HoaDonBanModel(txtMaHDB.Text, dtpNgayBan.Value, cmbNV.SelectedValue.ToString(), cmbNV.Text, cmbKH.SelectedValue.ToString(), cmbKH.Text);
                    CTHDB ds = new CTHDB();
                    ds.formLoad(CT);
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
                    HoaDonBanModel hh = new HoaDonBanModel(txtMaHDB.Text, dtpNgayBan.Value, cmbNV.SelectedValue.ToString());
                    hh_b.SuaHDB(hh);
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
                    HoaDonBanModel hh = new HoaDonBanModel(txtMaHDB.Text);
                    hh_b.XoaHDB(hh);
                    MessageBox.Show("Xóa thành công!");
                    InDS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtMaHDB.Clear();
            cmbNV.SelectedValue = "";
            // txtTTien.Clear();


            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaHDB.Enabled = false;
            dtpNgayBan.Enabled = false;
            cmbNV.Enabled = false;
            // txtTTien.Enabled = false;
            checkButton = 0;
        }



        private void btnXemCT_Click(object sender, EventArgs e)
        {
            if (txtMaHDB.Text == "")
            {
                MessageBox.Show("Chọn một hóa đơn trước khi xem chi tiết !");
            }
            else
            {

                HoaDonBanModel hh = new HoaDonBanModel(txtMaHDB.Text, dtpNgayBan.Value, cmbNV.SelectedValue.ToString(), cmbNV.Text, cmbKH.SelectedValue.ToString(), cmbKH.Text);

                CTHDB ds = new CTHDB();
                ds.formLoad(hh);
                ds.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("MaHDB like '%{0}%'", txtTimKiem.Text);
            dt.DefaultView.RowFilter = str;
            if (dgvHDB.SelectedRows.Count == 0)
            {
                string str1 = string.Format("TenNV  like '%{0}%'", txtTimKiem.Text);
                dt.DefaultView.RowFilter = str1;
            }
        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
