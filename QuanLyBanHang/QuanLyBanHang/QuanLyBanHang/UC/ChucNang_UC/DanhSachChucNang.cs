using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.UCcontrol.NhanVien;

using QuanLyBanHang.UC.HangHoa_UC;
using QuanLyBanHang.UC.NhomHang_UC;
using QuanLyBanHang.UC.Kho_UC;
using QuanLyBanHang.UC.HoaDonBan_UC;
using QuanLyBanHang.UC.NCC_UC;
using QuanLyBanHang.UC.KhachHang_UC;
namespace QuanLyBanHang.UC.ChucNang_UC
{
    public partial class DanhSachChucNang : UserControl
    {
        public DanhSachChucNang()
        {
            InitializeComponent();
             DanhSach ds = new DanhSach();
            pnlDSNV.Controls.Add(ds);
            DS_KH dskh = new DS_KH();
            pnlKhachHang.Controls.Add(dskh);
            DanhSachHH dshh = new DanhSachHH();
            pnlHangHoa.Controls.Add(dshh);
            DanhSachNhomHang dsnh = new DanhSachNhomHang();
            pnlNhomHang.Controls.Add(dsnh);
            DanhSachKho dsk = new DanhSachKho();
            pnlKho.Controls.Add(dsk);
            DanhSachHDB dshdb = new DanhSachHDB();
            pnlHDB.Controls.Add(dshdb);
            DanhSachHDN dshdn = new DanhSachHDN();
            pnlHDN.Controls.Add(dshdn);
            DanhSachNCC dsncc = new DanhSachNCC();
            pnlNhaCCC.Controls.Add(dsncc);
        }

        private void tsbDanhSach_Click(object sender, EventArgs e)
        {

        }
    }
}
