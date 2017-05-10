using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;
using System;



namespace BusinessLayer
{
    public class CTHDN_Bus
    {
    KetNoiDB kn = new KetNoiDB();
    public CTHDN_Bus()
    {
        kn.StrConnection = @"server=HP\SQLEXPRESS;database=QLBH; Integrated Security = True";

    }
    public DataTable XemDS(ChiTietPhieuNhapModel ct)
    {
        //return kn.getData("select CHITIETPHIEUBAN.*,TenNV from CHITIETPHIEUBAN left join NHANVIEN on CHITIETPHIEUBAN.MaNV = NHANVIEN.MaNV ", new SqlParameter[0], CommandType.Text);
        SqlParameter[] sp = new SqlParameter[1];
        sp[0] = new SqlParameter("@mahdn", SqlDbType.Char, 10);
        sp[0].Value = ct.MaHDN;
        return kn.getData("xem_ctpn", sp, CommandType.StoredProcedure);
        //return kn.getData("select CHITIETPHIEUBAN.*,TenHH from CHITIETPHIEUBAN left join HANGHOA on CHITIETPHIEUBAN.MaHH=HANGHOA.MaHH,HOADONBAN WHERE CHITIETPHIEUBAN.MaHDB=HOADONBAN.MaHDB", new SqlParameter[0], CommandType.Text);
        //return kn.getData("xem_ctpb");
    }
    public DataTable LayDSHH()
    {
        return kn.getData("select MaHH,TenHH from HANGHOA ", new SqlParameter[0], CommandType.Text);
    }

    public void ThemCTPN(ChiTietPhieuNhapModel ctpn)
    {
        SqlParameter[] sp = new SqlParameter[5];
        sp[0] = new SqlParameter("@mahdn", SqlDbType.Char, 10);
        sp[1] = new SqlParameter("@mahh", SqlDbType.Char, 10);
        sp[2] = new SqlParameter("@sl", SqlDbType.Char,10);
        sp[3] = new SqlParameter("@gia", SqlDbType.Money, 20);
        sp[4] = new SqlParameter("@tt", SqlDbType.Money, 20);
        sp[0].Value = ctpn.MaHDN;
        sp[1].Value = ctpn.MaHH;
        sp[2].Value = ctpn.SoLuong;
        if (ctpn.DonGia != "")
        {
            sp[3].Value = ctpn.DonGia;
        }
        else
            sp[3].Value = "0";

        if (ctpn.thanhtien != "")
        {
            sp[4].Value = ctpn.thanhtien;
        }
        else
            sp[4].Value = "0";
        kn.ThuTuc("them_ctpn", sp);
    }
    public void SuaCTPN(ChiTietPhieuNhapModel ctpn)
    {
        SqlParameter[] sp = new SqlParameter[5];
        sp[0] = new SqlParameter("@mahdn", SqlDbType.Char, 10);
        sp[1] = new SqlParameter("@mahh", SqlDbType.Char, 10);
        sp[2] = new SqlParameter("@sl", SqlDbType.NVarChar, 50);
        sp[3] = new SqlParameter("@gia", SqlDbType.Money, 20);
        sp[4] = new SqlParameter("@tt", SqlDbType.Money, 20);
        sp[0].Value = ctpn.MaHDN;
        sp[1].Value = ctpn.MaHH;
        sp[2].Value = ctpn.SoLuong;
        if (ctpn.DonGia != "")
        {
            sp[3].Value = ctpn.DonGia;
        }
        else
            sp[3].Value = "0";
        if (ctpn.thanhtien != "")
        {
            sp[4].Value = ctpn.thanhtien;
        }
        else
            sp[4].Value = "0";
        kn.ThuTuc("sua_ctpn", sp);
    }

    /*public DataTable LayDSHH(string v)
    {
        throw new NotImplementedException();
        return kn.getdata("select MaHH,TenHH,dongia from HANGHOA " + v); //, new SqlParameter[0], CommandType.Text);
    }*/

    public void XoaCTPN(ChiTietPhieuNhapModel ctpn)
    {
        SqlParameter[] sp = new SqlParameter[2];
        sp[0] = new SqlParameter("@mahdn", SqlDbType.Char, 10);
        sp[1] = new SqlParameter("@mahh", SqlDbType.Char, 10);
        sp[0].Value = ctpn.MaHDN;
        sp[1].Value = ctpn.MaHH;
        kn.ThuTuc("xoa_ctpn", sp);
    }
}
}
