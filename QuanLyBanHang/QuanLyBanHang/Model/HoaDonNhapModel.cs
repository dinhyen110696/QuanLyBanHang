using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HoaDonNhapModel
    {
        public string MaHDN { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string tongtien { get; set; }

        public HoaDonNhapModel(string ma, DateTime nb, string manv)
        {
            MaHDN = ma;
            NgayNhap = nb;
            MaNV = manv;

        }
        public HoaDonNhapModel(string ma, DateTime nb, string manv, string ten)
        {
            MaHDN = ma;
            NgayNhap = nb;
            MaNV = manv;
            TenNV = ten;

        }
        public HoaDonNhapModel(string ma, string tt)
        {
            MaHDN = ma;

            tongtien = tt;
        }
        public HoaDonNhapModel(string ma)
        {

            MaHDN = ma;
        }
        public HoaDonNhapModel() { }
    }
}
