using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace businessLayer
{
    public class NhanVien_Bus
    {
        KetNoiDB kn = new KetNoiDB();
        public NhanVien_Bus()
        {
            kn.StrConnection = @"server=HP\SQLEXPRESS;database=QLBH; Integrated Security = True";

        }
        public DataTable XemDS()
        {
            return kn.getData("select * from NhanVien ", new SqlParameter[0],CommandType.Text);
        }
        public DataTable dsMa()
        {
            return kn.getData("SELECT MaNV FROM NHANVIEN", new SqlParameter[0], CommandType.Text);
        }
        public void ThemNV(NhanVienModel nv )
        {
          
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@manv", SqlDbType.Char,10 );
            sp[1] = new SqlParameter("@ten", SqlDbType.NVarChar, 50);
            sp[2] = new SqlParameter("@gt", SqlDbType.NChar, 10);
            sp[3] = new SqlParameter("@ns", SqlDbType.DateTime);
            sp[4] = new SqlParameter("@diachi", SqlDbType.NVarChar, 10);
            sp[5]= new SqlParameter("@luong", SqlDbType.Money,10);

            sp[0].Value = nv.MaNV;
            sp[1].Value = nv.TenNV;
            sp[2].Value = nv.GioiTinh;
            sp[3].Value = nv.NgaySinh.ToShortDateString();
            sp[4].Value = nv.DiaChi;
            if (nv.Luong != "")
            {
                sp[5].Value = nv.Luong;
            }
            else
                sp[5].Value = "0";
            kn.ThuTuc("them_nv", sp);
        }
        public void XoaNV(NhanVienModel nv)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("manv", SqlDbType.Char, 10);
            sp[0].Value = nv.MaNV;
            kn.ThuTuc("xoa_nv", sp);
        }
        public void SuaNV(NhanVienModel nv)
        {
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@manv", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ten", SqlDbType.NVarChar, 50);
            sp[2] = new SqlParameter("@gt", SqlDbType.NChar, 10);
            sp[3] = new SqlParameter("@ns", SqlDbType.DateTime);
            sp[4] = new SqlParameter("@diachi", SqlDbType.NVarChar, 10);
            sp[5] = new SqlParameter("@luong", SqlDbType.Money);

            sp[0].Value = nv.MaNV;
            sp[1].Value = nv.TenNV;
            sp[2].Value = nv.GioiTinh;
            sp[3].Value = nv.NgaySinh;
            sp[4].Value = nv.DiaChi;
           if (nv.Luong != "")
            {
                sp[5].Value = nv.Luong;
            }
            else
                sp[5].Value = "0";
            kn.ThuTuc("sua_nv", sp);

        }
    }
}
