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

namespace UI.UCcontrol.NhanVien
{
    public partial class DanhSach : UserControl
    {
        NhanVien_Bus nv_b = new NhanVien_Bus();
        private int checkButton=0;
        DataTable dt = new DataTable();

        public void InDanhSach()
        {
            dt = nv_b.XemDS();
            dgvNhanVien.DataSource = dt;
        }
        public DanhSach()
        {
            InitializeComponent();
            InDanhSach();

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {

           try
            {
                DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
                txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();
                txtTenNV.Text =dr.Cells["TenNV"].Value.ToString();
                dateTimePickerNS_NV.Text = dr.Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
                txtLuong.Text = dr.Cells["Luong"].Value.ToString();
                string gt = dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString();
                if (gt.ToUpper().Contains("NAM"))//Contains("NAM")||gt.Contains("nam")||gt.Contains("Nam"))
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else if (gt.ToUpper().Contains("NỮ"))
                {
                    rdoNu.Checked = true;
                    rdoNam.Checked = false;
                }
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }
        public string NextID()
        {
            //string sql = "SELECT MaHH FROM HANGHOA";
            // Lấy DataTable từ câu truy vấn truyền vào (Apdapter Fill DataTable)
            dt = nv_b.dsMa();
            int[] arrCode = new int[dt.Rows.Count];
            int code;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                code = int.Parse(dt.Rows[i]["MaNV"].ToString().Remove(0, 2));
                arrCode[i] = code;
            }
            code = arrCode.Max() + 1;
            string nextID = "NV" + code;
            return nextID;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string nextID = NextID();
            txtMaNV.Text = nextID.ToString();
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = true;
            txtLuong.Enabled = true;
            txtDiaChi.Enabled = true;
            dateTimePickerNS_NV.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 1;
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtLuong.Enabled = false;
            txtDiaChi.Enabled = false;
            dateTimePickerNS_NV.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 3;
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = true;
            txtLuong.Enabled = true;
            txtDiaChi.Enabled = true;
            dateTimePickerNS_NV.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 2;
            
        }

        private void grpNhanVien_Enter(object sender, EventArgs e)
        {

        }

        private void lblLuong_Click(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtLuong.Enabled = false;
            txtDiaChi.Enabled = false;
            dateTimePickerNS_NV.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;

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
                    string gt;
                    if (rdoNam.Checked == true) gt = "NAM";
                    else gt = "NỮ";
                    NhanVienModel nv = new NhanVienModel(txtMaNV.Text, txtTenNV.Text, gt, txtDiaChi.Text, dateTimePickerNS_NV.Value, txtLuong.Text);
                    nv_b.ThemNV(nv);
                    MessageBox.Show("Thêm mới nhân viên thành công ");
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
                    NhanVienModel nv = new NhanVienModel(txtMaNV.Text, txtTenNV.Text, rdoNam.Checked == true ? "NAM" : "NỮ", txtDiaChi.Text, dateTimePickerNS_NV.Value, txtLuong.Text);
                    nv_b.SuaNV(nv);
                    MessageBox.Show("Sửa nhân viên thành công! ");
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
                    NhanVienModel nv = new NhanVienModel();
                    nv.MaNV = txtMaNV.Text;
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        nv_b.XoaNV(nv);
                        MessageBox.Show("Xóa nhân viên thành công ");
                        InDanhSach();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtLuong.Enabled = false;
            txtDiaChi.Enabled = false;
            dateTimePickerNS_NV.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
           // txtTimKiem.Font = new Font(Fo, FontStyle.Italic)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("TenNV like '%{0}%'", txtTimKiem.Text);
            dt.DefaultView.RowFilter = str;
            if (dgvNhanVien.SelectedRows.Count==0)
            {
                string str1 = string.Format("MaNV like '%{0}%'", txtTimKiem.Text);
                dt.DefaultView.RowFilter = str1;
            }
           
        }

        private void DanhSach_Load(object sender, EventArgs e)
        {

        }
    }
}
