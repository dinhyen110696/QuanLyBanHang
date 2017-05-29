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
    public class NhomHang_Bus
    {
        KetNoiDB kn = new KetNoiDB();
        public NhomHang_Bus()
        {
            kn.StrConnection = @"server=HP\SQLEXPRESS;database=QLBH; Integrated Security = True";

        }
        public DataTable XemDS()
        {
            return kn.getData("select NHOMHANG.*,TenKho from NHOMHANG left join KHO on KHO.MaKho = NHOMHANG.MaKho", new SqlParameter[0], CommandType.Text);
        }
        public DataTable LayDSKho()
        {

            return kn.getData("select TenKho,MaKho from KHO", new SqlParameter[0], CommandType.Text);

        }
        public DataTable LayDSNhomhang()
        {

            return kn.getData("select TenNhom,MaNhom from NHOMHANG", new SqlParameter[0], CommandType.Text);

        }
        public void ThemNH(NhomHangModel nh)
        {

            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@ma", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ten", SqlDbType.NVarChar, 50);
            sp[2] = new SqlParameter("@makho", SqlDbType.Char, 10);
            
            sp[0].Value = nh.MaNhom;
            sp[1].Value = nh.TenNhom;
            sp[2].Value = nh.MaKho;
            
            
            kn.ThuTuc("them_nh", sp);
        }
        public void SuaNH(NhomHangModel nh)
        {
            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@ma", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@ten", SqlDbType.NVarChar, 50);
            sp[2] = new SqlParameter("@makho", SqlDbType.Char, 10);

            sp[0].Value = nh.MaNhom;
            sp[1].Value = nh.TenNhom;
            sp[2].Value = nh.MaKho;
            kn.ThuTuc("sua_nh", sp);

        }
        public void XoaNH(NhomHangModel nh)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@ma", SqlDbType.Char, 10);

            sp[0].Value = nh.MaNhom;
            kn.ThuTuc("xoa_nh", sp);
        }
    }
}
