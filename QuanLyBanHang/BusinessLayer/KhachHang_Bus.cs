using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class KhachHang_Bus
    {
        KetNoiDB kn = new KetNoiDB();
        public KhachHang_Bus()
        {
            kn.StrConnection = @"server=HP\SQLEXPRESS;database=QLBH; Integrated Security = True";

        }
        public DataTable XemDS()
        {
            return kn.getData("select * from KHACHHANG ", new SqlParameter[0], CommandType.Text);
        }
        public DataTable dsMa()
        {
            return kn.getData("SELECT MaKH FROM KHACHHANG", new SqlParameter[0], CommandType.Text);
        }
        public void ThemKH(KhachHangModel kh)
        {

            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@maKH", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ten", SqlDbType.NVarChar, 50);
            sp[2] = new SqlParameter("@sdt", SqlDbType.Char, 15);
            sp[3] = new SqlParameter("@ns", SqlDbType.DateTime);
            sp[4] = new SqlParameter("@diachi", SqlDbType.NVarChar, 10);
            sp[5] = new SqlParameter("@diem", SqlDbType.Char, 10);

            sp[0].Value = kh.MaKH;
            sp[1].Value = kh.TenKH;
            sp[2].Value = kh.SDT;
            sp[3].Value = kh.NgaySinh.ToShortDateString();
            sp[4].Value = kh.DiaChi;
            if (kh.DiemTL.ToString() != "")
            {
                sp[5].Value = kh.DiemTL;
            }
            else
                sp[5].Value = "0";
            kn.ThuTuc("them_kh", sp);
        }
        public void XoaKH(KhachHangModel kh)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("ma", SqlDbType.Char, 10);
            sp[0].Value = kh.MaKH;
            kn.ThuTuc("xoa_kh", sp);
        }
       
    }
}
