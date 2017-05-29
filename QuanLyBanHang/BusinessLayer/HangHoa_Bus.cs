using DAL;
using System.Data;
using System.Data.SqlClient;
using Model;
using System.Collections.Generic;
using System.Collections;

namespace BusinessLayer

{
    public class HangHoa_Bus
    {
        KetNoiDB kn = new KetNoiDB();
        public HangHoa_Bus()
        {
            kn.StrConnection = @"server=HP\SQLEXPRESS;database=QLBH; Integrated Security = True";

        }
        public DataTable dsMa()
        {
            return kn.getData("SELECT MaHH FROM HANGHOA", new SqlParameter[0], CommandType.Text);
        }
        public DataTable XemDS()
        {
            return kn.getData("select MaHH,TenHH,NoiSX,DonVi,dongia,TenNCC,TenNhom from HANGHOA,NHACUNGCAP,NHOMHANG where HANGHOA.MaNCC=NHACUNGCAP.MaNCC and HANGHOA.MaNhom=NHOMHANG.MaNhom", new SqlParameter[0], CommandType.Text);
        }
        public DataTable LayDSNCC()
        {
           
           return kn.getData("select TenNCC,MaNCC from NHACUNGCAP", new SqlParameter[0], CommandType.Text);

        }
        public DataTable LayDSNhomhang()
        {
         
            return kn.getData("select TenNhom,MaNhom from NHOMHANG", new SqlParameter[0], CommandType.Text);

        }
        public void ThemHH(HangHoaModel hh)
        {

            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@mahh", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@tenhh", SqlDbType.NVarChar, 50);
            sp[2] = new SqlParameter("@noisx", SqlDbType.NVarChar, 50);
            sp[3] = new SqlParameter("@donvi", SqlDbType.NVarChar,10);
            sp[4] = new SqlParameter("@mancc", SqlDbType.Char, 10);
            sp[5] = new SqlParameter("@manhom", SqlDbType.Char, 10);
            sp[6] = new SqlParameter("@gia", SqlDbType.Money, 20);
            
            sp[0].Value = hh.MaHH;
            sp[1].Value = hh.TenHH;
            sp[2].Value = hh.NoiSX;
            sp[3].Value = hh.DonVi;
            sp[4].Value = hh.MaNCC;
            sp[5].Value = hh.MaNhom;
            if (hh.DonGia != "")
            {
                sp[6].Value = hh.DonGia;
            }
            else
                sp[6].Value = "0";
            kn.ThuTuc("them_hh", sp);
        }
        public void SuaHH(HangHoaModel hh)
        {
            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@mahh", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@tenhh", SqlDbType.NVarChar, 50);
            sp[2] = new SqlParameter("@noisx", SqlDbType.NVarChar, 50);
            sp[3] = new SqlParameter("@donvi", SqlDbType.NVarChar, 50);
            sp[4] = new SqlParameter("@mancc", SqlDbType.Char, 10);
            sp[5] = new SqlParameter("@manhom", SqlDbType.NVarChar, 10);
            sp[6] = new SqlParameter("@gia", SqlDbType.Money, 20);

            sp[0].Value = hh.MaHH;
            sp[1].Value = hh.TenHH;
            sp[2].Value = hh.NoiSX;
            sp[3].Value = hh.DonVi;
            sp[4].Value = hh.MaNCC;
            sp[5].Value = hh.MaNhom;
            if (hh.DonGia != "")
            {
                sp[6].Value = hh.DonGia;
            }
            else
                sp[6].Value = "0";
            kn.ThuTuc("sua_hh", sp);

        }
        public void XoaHH(HangHoaModel hh)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@mahh", SqlDbType.Char, 10);

            sp[0].Value = hh.MaHH;
            kn.ThuTuc("xoa_hh", sp);
        }
    }
}
