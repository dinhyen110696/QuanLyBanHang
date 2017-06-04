using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class KhachHangModel
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiemTL { get; set; }
        public KhachHangModel(string ma, string ten, string sdt, string dc, DateTime ns, string diem)
        {
            MaKH = ma;
            TenKH = ten;
            SDT = sdt;
            DiaChi = dc;
            NgaySinh = ns;
            DiemTL = diem;
        }
        public KhachHangModel() { }
    }
}
