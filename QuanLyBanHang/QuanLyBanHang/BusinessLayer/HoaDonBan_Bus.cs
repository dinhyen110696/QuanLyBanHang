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
   public class HoaDonBan_Bus
    {
        KetNoiDB kn = new KetNoiDB();
        public HoaDonBan_Bus()
        {
            kn.StrConnection = @"server=HP\SQLEXPRESS;database=QLBH; Integrated Security = True";

        }
        public DataTable XemDS()
        {
            return kn.getData("select HOADONBAN.*,TenNV,TenKH from HOADONBAN,NHANVIEN,KHACHHANG where HOADONBAN.MaNV = NHANVIEN.MaNV and HOADONBAN.MaKH=KHACHHANG.MaKH", new SqlParameter[0], CommandType.Text);
        }

        /*public DataTable TongTien(HoaDonBanModel hdb)
        {
            //SqlParameter[] sp = new SqlParameter[1];
            //sp[0] = new SqlParameter("@mahh", SqlDbType.Char, 10);
            //sp[0].Value = hdb.MaHDB;
            //kn.ThuTuc("TT", sp);
            //return kn.getData("TT", sp, CommandType.StoredProcedure);
            return kn.getData("select  sum(ThanhTien) as TongTien from CHITIETPHIEUBAN, HOADONBAN where CHITIETPHIEUBAN.MaHDB = HOADONBAN.MaHDB and HOADONBAN.MaHDB = "+hdb.MaHDB, new SqlParameter[0], CommandType.Text);
        }*/
        public DataTable LayDSNV()
        {
            return kn.getData("select TenNV,MaNV from NHANVIEN", new SqlParameter[0], CommandType.Text);

        }
        public DataTable LayDSKH()
        {
            return kn.getData("select TenKH,MaKH from KHACHHANG", new SqlParameter[0], CommandType.Text);

        }
        public void ThemHDB(HoaDonBanModel hdb)
        {

            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@mahd", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ngay", SqlDbType.DateTime);
            sp[2] = new SqlParameter("@manv", SqlDbType.Char, 10);
            sp[3] = new SqlParameter("@makh", SqlDbType.Char, 10);


            sp[0].Value = hdb.MaHDB;
            sp[1].Value = hdb.NgayBan;
            sp[2].Value = hdb.MaNV;
            sp[3].Value = hdb.MaKH;
            kn.ThuTuc("them_hdb", sp);
        }
        public void SuaHDB(HoaDonBanModel hdb)
        {
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@mahd", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ngay", SqlDbType.DateTime);
            sp[2] = new SqlParameter("@manv", SqlDbType.Char, 10);
            sp[3] = new SqlParameter("@makh", SqlDbType.Char, 10);

            sp[0].Value = hdb.MaHDB;
            sp[1].Value = hdb.NgayBan;
            sp[2].Value = hdb.MaNV;
            sp[3].Value = hdb.MaKH;
            kn.ThuTuc("sua_hdb", sp);

        }
        public void XoaHDB(HoaDonBanModel hdb)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@mahd", SqlDbType.Char, 10);

            sp[0].Value = hdb.MaHDB;
            kn.ThuTuc("xoa_hdb", sp);
        }
    }
}
