using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BusinessLayer;
namespace QuanLyBanHang.Form_
{
    public partial class ThemCTHDB : Form
    {
        public void loadForm(HoaDonBanModel hd)
        {
            lblMaHDB.Text = hd.MaHDB;
            CTHDN_Bus ct = new CTHDN_Bus();
            DataTable dt = ct.LayDSHH();
            cmbHangHoa.DataSource = dt;
            cmbHangHoa.DisplayMember = "TenHH";
            cmbHangHoa.ValueMember = "MaHH";
        }
        public ThemCTHDB()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
