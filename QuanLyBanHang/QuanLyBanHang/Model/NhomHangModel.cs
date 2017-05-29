using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class NhomHangModel
    {
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public string MaKho { get; set; }
        public NhomHangModel(string manhom,string ten,string makho)
        {
            MaNhom = manhom;
            TenNhom = ten;
            MaKho = makho;
        }
        public NhomHangModel() { }
    }
}
