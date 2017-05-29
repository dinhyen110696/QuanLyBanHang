using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using QuanLyBanHang.UC.TrangChu_UC;
using QuanLyBanHang.UC.ChucNang_UC;
using QuanLyBanHang.Form_;
using Model;
namespace UI.form_
{
    public partial class frmMain : Form
    {
        DanhSachChucNang dscn ;
        DanhSachTroGiup dstg;
        DanhSachHeThong dsht;
        DanhSachThongKe dstk;
        DanhMucUC dsuc;
        ChucNang cnuc;
        HeThongUC htuc;
        TroGiupUC tguc;
        //TaiKhoanModel tk;
        public frmMain()
        {
            InitializeComponent(); 
            panel3.Visible = false;
            pnlChucNang.Controls.Add(panel3);
            btnHome.Visible=false;
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //FormDangNhap frm = new FormDangNhap();
            //frm.ShowDialog();
            //tk = frm.LayTTDN();
            //lblXinChao.Text = "Xin chào : " + frm.Name;
            
        }
      
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbDanhSach_Click(object sender, EventArgs e)
        {
           
        }

        private void TabHangHoa_Click(object sender, EventArgs e)
        {
            
        }

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc không ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }          
        }

        private void tabNhomHang_Click(object sender, EventArgs e)
        {
           
        }

        private void tabKho_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControlNhomHang_Click(object sender, EventArgs e)
        {
           
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            pnl2.Visible = false;
            pnl1.Visible = false;
            pnlChucNang.Controls.Remove(dstg);
            pnlChucNang.Controls.Remove(dsht);
            pnlChucNang.Controls.Remove(dstk);
            dscn = new DanhSachChucNang();
            pnlChucNang.Controls.Add(dscn);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnHome.Visible = false;
            pnlChucNang.Controls.Remove(dscn);
            pnl2.Visible = true;
            pnl1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnChucNang_MouseMove(object sender, MouseEventArgs e)
        {
            //pnl1.Controls.Remove(dsuc);
        }

        private void btnChucNang_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnChucNang_MouseHover(object sender, EventArgs e)
        {

           
        }

        private void btnChucNang_MouseEnter(object sender, EventArgs e)
        {
            pnl1.Controls.Clear();
            dsuc = new DanhMucUC();
            pnl1.Controls.Add(dsuc);
        }

        private void btnChucNang_MouseEnter_1(object sender, EventArgs e)
        {
            pnl1.Controls.Clear();
            cnuc = new ChucNang();
            pnl1.Controls.Add(cnuc);
        }

        private void btnChucNang_Click_1(object sender, EventArgs e)
        {
            pnl2.Visible = false;
            pnl1.Visible = false;
           
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            pnl2.Visible = false;
            pnl1.Visible = false;
            pnlChucNang.Controls.Remove(dstg);
            pnlChucNang.Controls.Remove(dscn);
            pnlChucNang.Controls.Remove(dstk);
            dsht = new DanhSachHeThong();
            //dsht.SetLabel(tk);
            pnlChucNang.Controls.Add(dsht);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (panel3.Visible == false)
            {    
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void btnHeThong_MouseEnter(object sender, EventArgs e)
        {
            pnl1.Controls.Clear();
            htuc = new HeThongUC();
            pnl1.Controls.Add(htuc);
        }

        private void btnTroGiup_MouseEnter(object sender, EventArgs e)
        {
            pnl1.Controls.Clear();
            tguc = new TroGiupUC();
            pnl1.Controls.Add(tguc);
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            pnl2.Visible = false;
            pnl1.Visible = false;
            pnlChucNang.Controls.Remove(dscn);
            pnlChucNang.Controls.Remove(dsht);
            pnlChucNang.Controls.Remove(dstk);
            dstg = new DanhSachTroGiup();
            pnlChucNang.Controls.Add(dstg);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          if(MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản này?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                this.Enabled= false;
                frmMain frm = new frmMain();
                //FormDangNhap frm1 = new FormDangNhap();
                frm1.ShowDialog();
            }
               
        }
    }
}
