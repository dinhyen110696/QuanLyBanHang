using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChiTietPhieuBanModel
    {
        public string MaHDB { get; set; }
        public string MaHH { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string thanhtien { get; set; }
        public string TenHH { get; set; }
        public ChiTietPhieuBanModel(string MA)
        {
            MaHDB = MA;
        }
        public ChiTietPhieuBanModel(string ma,string ma2)
        {
            MaHDB = ma;
            MaHH = ma2;
        }
        
        public ChiTietPhieuBanModel( string ma,string ma2, string sl, string dg,string tt)
        {
            MaHDB = ma;
            MaHH = ma2;
            SoLuong = sl;
            DonGia = dg;
            thanhtien = tt;
        }
        public ChiTietPhieuBanModel(string ma,string ma2,string ten,string sl,string dg,string tt)
        {
            MaHDB = ma;
            MaHH = ma2;
            TenHH = ten;
            SoLuong = sl;
            DonGia = dg;
            thanhtien = tt;
        }
        public ChiTietPhieuBanModel() { }
    }
}
