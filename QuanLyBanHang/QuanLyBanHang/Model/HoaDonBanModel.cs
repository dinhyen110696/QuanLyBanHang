using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HoaDonBanModel
    {
        public string MaHDB { get; set; }
        public DateTime NgayBan { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string tongtien { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
     
        public HoaDonBanModel(string ma, DateTime nb, string manv)
        {
            MaHDB = ma;
            NgayBan = nb;
            MaNV = manv;
        }
        public HoaDonBanModel(string ma,DateTime nb,string manv,string makh)
        {
            MaHDB = ma;
            NgayBan = nb;
            MaNV = manv;
            MaKH = makh;
         
            
        }
        public HoaDonBanModel(string ma, DateTime nb, string manv,string ten, string makh,string tenkh)
        {
            MaHDB = ma;
            NgayBan = nb;
            MaNV = manv;
            TenNV = ten;
            MaKH = makh;
            TenKH = tenkh;
       
            
        }
        public HoaDonBanModel(string ma, string tt,string diem)
        {
            MaHDB = ma;
            
            tongtien = tt;
 
        }
        public HoaDonBanModel(string ma)
        {

            MaHDB = ma;
        }
        public HoaDonBanModel() { }
    }
}
