using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
   public class HoaDonNhap_Bus
    {
        KetNoiDB kn = new KetNoiDB();
        public HoaDonNhap_Bus()
        {
            kn.StrConnection = @"server=HP\SQLEXPRESS;database=QLBH; Integrated Security = True";

        }
        public DataTable XemDS()
        {
            return kn.getData("select HOADONNHAP.*,TenNV from HOADONNHAP left join NHANVIEN on HOADONNHAP.MaNV = NHANVIEN.MaNV", new SqlParameter[0], CommandType.Text);
        }
        public DataTable LayDSNV()
        {
            return kn.getData("select TenNV,MaNV from NHANVIEN", new SqlParameter[0], CommandType.Text);

        }

        public void ThemHDN(HoaDonNhapModel hdn)
        {

            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@mahd", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ngay", SqlDbType.DateTime);
            sp[2] = new SqlParameter("@manv", SqlDbType.Char, 10);

            sp[0].Value = hdn.MaHDN;
            sp[1].Value = hdn.NgayNhap;
            sp[2].Value = hdn.MaNV;


            kn.ThuTuc("them_hdn", sp);
        }
        public void SuaHDN(HoaDonNhapModel hdn)
        {
            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@mahd", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ngay", SqlDbType.DateTime);
            sp[2] = new SqlParameter("@manv", SqlDbType.Char, 10);

            sp[0].Value = hdn.MaHDN;
            sp[1].Value = hdn.NgayNhap;
            sp[2].Value = hdn.MaNV;

            kn.ThuTuc("sua_hdn", sp);

        }
        public void XoaHDN(HoaDonNhapModel hdn)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@ma", SqlDbType.Char, 10);

            sp[0].Value = hdn.MaHDN;
            kn.ThuTuc("xoa_hdn", sp);
        }

    }
}
