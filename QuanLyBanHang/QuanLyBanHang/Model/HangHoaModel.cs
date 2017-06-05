
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HangHoaModel
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string NoiSX { get; set; }
        public string DonVi { get; set; }
        public string MaNCC { get; set; }
        public string MaNhom { get; set; }
        public string DonGia { get; set; }
        public string TenNhom { get; set; }
      
        public HangHoaModel(string ma, string ten, string noisx, string dv, string mancc, string manhom,string dg)
        {
            MaHH = ma;
            TenHH = ten;
            NoiSX = noisx;
            DonVi = dv;
            MaNCC = mancc;
            MaNhom = manhom;
            DonGia = dg;
        }
        public HangHoaModel() { }
    }
}
