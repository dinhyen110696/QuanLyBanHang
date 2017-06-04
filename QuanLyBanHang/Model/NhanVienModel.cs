using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NhanVienModel
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Luong { get; set; }
        public NhanVienModel(string ma, string ten,string gt, string dc, DateTime ns,string l)
        {
            MaNV = ma;
            TenNV = ten;
            GioiTinh = gt;
            DiaChi = dc;
            NgaySinh = ns;
            Luong = l;
        }
        public NhanVienModel() { }
    }
}
