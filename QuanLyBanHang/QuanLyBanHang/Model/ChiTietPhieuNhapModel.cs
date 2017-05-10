using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChiTietPhieuNhapModel
    {
        public string MaHDN { get; set; }
        public string MaHH { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string thanhtien { get; set; }
        public string TenHH { get; set; }

        public ChiTietPhieuNhapModel(string MA)
        {
            MaHDN = MA;
        }
        public ChiTietPhieuNhapModel(string ma, string ma2)
        {
            MaHDN = ma;
            MaHH = ma2;
        }

        public ChiTietPhieuNhapModel(string ma, string ma2, string sl, string dg, string tt)
        {
            MaHDN = ma;
            MaHH = ma2;
            SoLuong = sl;
            DonGia = dg;
            thanhtien = tt;
        }
        public ChiTietPhieuNhapModel(string ma, string ma2, string ten, string sl, string dg, string tt)
        {
            MaHDN = ma;
            MaHH = ma2;
            TenHH = ten;
            SoLuong = sl;
            DonGia = dg;
            thanhtien = tt;
        }
        public ChiTietPhieuNhapModel() { }
    }
}
