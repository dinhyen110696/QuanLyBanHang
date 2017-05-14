using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace BusinessLayer
{
    public class CTHDB_Bus
    {
        KetNoiDB kn = new KetNoiDB();
        public CTHDB_Bus()
        {
            kn.StrConnection = @"server=HP\SQLEXPRESS;database=QLBH; Integrated Security = True";

        }
        public DataTable XemDS(ChiTietPhieuBanModel ct)
        {
            //return kn.getData("select CHITIETPHIEUBAN.*,TenNV from CHITIETPHIEUBAN left join NHANVIEN on CHITIETPHIEUBAN.MaNV = NHANVIEN.MaNV ", new SqlParameter[0], CommandType.Text);
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@mahdb", SqlDbType.Char, 10);
            sp[0].Value = ct.MaHDB;
            return kn.getData("xem_ctpb", sp, CommandType.StoredProcedure);
            //return kn.getData("select CHITIETPHIEUBAN.*,TenHH from CHITIETPHIEUBAN left join HANGHOA on CHITIETPHIEUBAN.MaHH=HANGHOA.MaHH,HOADONBAN WHERE CHITIETPHIEUBAN.MaHDB=HOADONBAN.MaHDB", new SqlParameter[0], CommandType.Text);
            //return kn.getData("xem_ctpb");
        }
        public DataTable LayDSHH()
        {
            return kn.getData("select MaHH,TenHH from HANGHOA ", new SqlParameter[0], CommandType.Text);
        }
        //public DataTable LayDSHH_TheoMa(string ma)
        //{
        //    string str = "select MaHH,TenHH ,dongia from HANGHOA where MaHH = '" + ma + "'";
        //    return kn.getData(str, new SqlParameter[0], CommandType.Text);
        //}
        //public DataTable LayGiaBan(ChiTietPhieuBanModel ctpb)
        //{
        //    SqlParameter[] sp = new SqlParameter[1];

        //    sp[0] = new SqlParameter("@mahh", SqlDbType.Char, 10);
        //    sp[0].Value = ctpb.MaHH;

        //    return kn.getData("xem_gia", sp,CommandType.StoredProcedure);
        //}

        public void ThemCTPB(ChiTietPhieuBanModel ctpb)
        {
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@mahdb", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@mahh", SqlDbType.Char, 10);
            sp[2] = new SqlParameter("@sl", SqlDbType.Char, 10);
            sp[3] = new SqlParameter("@gia", SqlDbType.Money);
            sp[4] = new SqlParameter("@tt", SqlDbType.Money);
            sp[0].Value = ctpb.MaHDB;
            sp[1].Value = ctpb.MaHH;
            sp[2].Value = ctpb.SoLuong;
            if (ctpb.DonGia != "")
            {
                sp[3].Value = ctpb.DonGia;
            }
            else
                sp[3].Value = "0";

            if (ctpb.thanhtien != "")
            {
                sp[4].Value = ctpb.thanhtien;
            }
            else
                sp[4].Value = "0";
            kn.ThuTuc("them_ctpb", sp);
        }
        public void SuaCTPB(ChiTietPhieuBanModel ctpb)
        {
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@mahdb", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@mahh", SqlDbType.Char, 10);
            sp[2] = new SqlParameter("@sl", SqlDbType.Char, 0);
            sp[3] = new SqlParameter("@gia", SqlDbType.Money);
            sp[4] = new SqlParameter("@tt", SqlDbType.Money);
            sp[0].Value = ctpb.MaHDB;
            sp[1].Value = ctpb.MaHH;
            sp[2].Value = ctpb.SoLuong;
            if (ctpb.DonGia != "")
            {
                sp[3].Value = ctpb.DonGia;
            }
            else
                sp[3].Value = "0";
            if (ctpb.thanhtien != "")
            {
                sp[4].Value = ctpb.thanhtien;
            }
            else
                sp[4].Value = "0";
            kn.ThuTuc("sua_ctpb", sp);
        }

        //public DataTable LayDSHH(string v)
        //{
        //    throw new NotImplementedException();
        //    return kn.getdata("select MaHH,TenHH,dongia from HANGHOA " + v); //, new SqlParameter[0], CommandType.Text);
        //}

        public void XoaCTPB(ChiTietPhieuBanModel ctpb)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@mahdb", SqlDbType.Char, 10);
            sp[1] = new SqlParameter("@mahh", SqlDbType.Char, 10);
            sp[0].Value = ctpb.MaHDB;
            sp[1].Value = ctpb.MaHH;
            kn.ThuTuc("xoa_ctpb", sp);
        }
    }
}
