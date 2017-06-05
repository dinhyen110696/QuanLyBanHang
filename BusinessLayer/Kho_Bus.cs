using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
   public class Kho_Bus
    {
        KetNoiDB kn = new KetNoiDB();
        public Kho_Bus()
        {
            kn.StrConnection = @"server=HP\SQLEXPRESS;database=QLBH; Integrated Security = True";

        }
        public DataTable XemDS()
        {
            return kn.getData("select KHO.*,TenNV from KHO left join NHANVIEN on KHO.MaNV = NHANVIEN.MaNV", new SqlParameter[0], CommandType.Text);
        }
        public DataTable dsMa()
        {
            return kn.getData("SELECT MaKho FROM KHO", new SqlParameter[0], CommandType.Text);
        }
        public DataTable LayDSNV()
        {

            return kn.getData("select TenNV,MaNV from NHANVIEN", new SqlParameter[0], CommandType.Text);

        }
        public void ThemKho(KhoModel k)
        {

            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@mak", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@tenk", SqlDbType.NVarChar, 50);
            sp[2] = new SqlParameter("@vitri", SqlDbType.NVarChar, 50);
            sp[3] = new SqlParameter("@manv", SqlDbType.Char, 10);
           

            sp[0].Value = k.MaKho;
            sp[1].Value = k.TenKho;
            sp[2].Value = k.ViTri;
            sp[3].Value = k.MaNV;
            kn.ThuTuc("them_kho", sp);
           
        }
        public void SuaKho(KhoModel k)
        {
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@mak", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@tenk", SqlDbType.NVarChar, 50);
            sp[2] = new SqlParameter("@vitri", SqlDbType.NVarChar, 50);
            sp[3] = new SqlParameter("@manv", SqlDbType.Char, 10);


            sp[0].Value = k.MaKho;
            sp[1].Value = k.TenKho;
            sp[2].Value = k.ViTri;
            sp[3].Value = k.MaNV;
            kn.ThuTuc("sua_kho", sp);

        }
        public void XoaKho(KhoModel k)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@mak", SqlDbType.Char, 10);

            sp[0].Value = k.MaKho;
            kn.ThuTuc("xoa_kho", sp);
        }
    }
}
