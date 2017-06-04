/*Truy vấn nhân viên*/
--thêm nhân viên
create proc them_nv (
@manv char(10),
@ten nvarchar(50),
@gt nchar(10),
@ns datetime,
@diachi nvarchar(50),
@luong int
)
as 
insert into NHANVIEN(MaNV,TenNV,GioiTinh,NgaySinh,DiaChi,Luong)
values (@manv,@ten,@gt,@ns,@diachi,@luong)
go
  --xóa

create proc xoa_nv (
@manv char(10)
)
as 
delete NHANVIEN where MaNV=@manv
go
  --sửa
create proc sua_nv (
@manv char(10),
@ten nvarchar(50),
@gt nchar(10),
@ns datetime,
@diachi nvarchar(50),
@luong int
)
as
begin
update NHANVIEN
set TenNV=@ten,GioiTinh=@gt,NgaySinh=@ns,DiaChi=@diachi,Luong=@luong
where MaNV=@manv
end
go
  --Tìm kiếm
create proc load_nv (
@manv char(10)
)
as select *from NHANVIEN where MaNV like @manv 
go
--khách hàng
--thêm nhân viên
create proc them_kh(
@makh char(10),
@ten nvarchar(50),
@sdt char(15),
@ns datetime,
@diachi nvarchar(50),
@diem int
)
as 
insert into khachhang(MaKH,TenKH,NgaySinh,DiaChi,SDT,DiemTL)
values (@makh,@ten,@ns,@diachi,@sdt,@diem)
go
  --xóa

create proc xoa_kh (
@ma char(10)
)
as 
delete khachhang where MaKH=@ma
go
  

  --Tìm kiếm
create proc load_kh (
@ma char(10)
)
as select *from KHACHHANG where MaKH like @ma 
go
--NHÓM HÀNG
create proc them_nh(
@ma char(10),
@ten nvarchar(50),
@makho char(10)
) as
insert into NHOMHANG(MaNhom,TenNhom,MaKho)
values (@ma,@ten,@makho)
go

create proc sua_nh(
@ma char(10),
@ten nvarchar(50),
@makho char(10)
) as
update NHOMHANG
set TenNhom=@ten,MaKho=@makho
where MaNhom=@ma
go
 create proc xoa_nh(
 @ma char(10)
 ) as
 delete NHOMHANG where MaNhom=@ma 
 go

 create proc load_nh (
@ma char(10)
)
as select *from NHOMHANG where MaNhom like @ma 
go
--kho
create proc them_kho(
@mak char(10),
@tenk nvarchar(50),
@vitri nvarchar(50),
@manv char(10)
) as insert into KHO(MaKho,TenKho,ViTri,MaNV)
values (@mak,@tenk,@vitri,@manv)
go 

create proc sua_kho(
@mak char(10),
@tenk nvarchar(50),
@vitri nvarchar(50),
@manv char(10)
) as update KHO
set TenKho=@tenk,ViTri=@vitri,MaNV=@manv
where MaKho=@mak
go

create proc xoa_kho(
@mak char(10)
) as 
delete KHO where MaKho=@mak
go

--NCC
create proc them_ncc(
@ma varchar(10),
@ten nvarchar(50),
@diachi nvarchar(50),
@sdt nvarchar(15)
) as insert into NHACUNGCAP(MaNCC,TenNCC,DiaChi,SDT)
values (@ma,@ten,@diachi,@sdt)
go

create proc sua_ncc(
@ma varchar(10),
@ten nvarchar(50),
@diachi nvarchar(50),
@sdt nvarchar(15)
) as update NHACUNGCAP
set TenNCC=@ten,DiaChi=@diachi,SDT=@sdt
where MaNCC=@ma
go
create proc xoa_ncc(
@ma varchar(10)
) as delete NHACUNGCAP where MaNCC=@ma 
go

--Hàng hóa
  --thêm
alter proc them_hh (
@mahh char(10),
@tenhh nvarchar(50),
@noisx nvarchar(50),
@donvi nvarchar(10),
@mancc char(10),
@manhom char(10),
@gia money
) as
insert into HANGHOA(MaHH,TenHH,NoiSX,DonVi,MaNCC,MaNhom,dongia)
values (@mahh,@tenhh,@noisx,@donvi,@mancc,@manhom,@gia)
go

alter proc sua_hh(
@mahh char(10),
@tenhh nvarchar(50),
@noisx nvarchar(50),
@mancc char(10),
@manhom char(10),
@donvi nvarchar(10),
@gia money
) as
update HANGHOA
set TenHH=@tenhh,NoiSX=@noisx,MaNCC=@mancc,MaNhom=@manhom,DonVi=@donvi,dongia=@gia
where MaHH=@mahh
go 

create proc xoa_hh(
@mahh char(10)
) as select * from HANGHOA 
delete HANGHOA where MaHH=@mahh
go
--tìm kiếm
 alter proc load_hh(
 @mahh char(10)
 ) AS select *from HANGHOA where MaHH like @mahh
 go

 --hóa đơn bán
 alter proc them_hdb(
 @mahd char(10),
 @ngay datetime,
 @manv char(10),
 @makh char(10)
 ) as
 insert into HOADONBAN(MaHDB,NgayBan,MaNV,MaKH)
 values(@mahd,@ngay,@manv,@makh)
 go

 alter proc sua_hdb(
 @mahd char(10),
 @ngay datetime,
 @manv char(10),
 @makh char(10)
 ) as
 update HOADONBAN
 set NgayBan=@ngay,MaNV=@manv,MaKH=@makh
 where MaHDB=@mahd
 go

  create proc xoa_hdb(
  @mahd char(10)
  ) as
  delete HOADONBAN where MaHDB=@mahd
  go
  create proc load_hdb(
 @mahdb char(10)
 ) AS select *from HOADONBAN where MaHDB like @mahdb
 go
--chi tiết phiếu bán
ALTER proc xem_gia(@mahh char(10))
as
begin 
select HANGHOA.MaHH,HANGHOA.dongia
from HANGHOA
WHERE HANGHOA.MaHH=@mahh 
END
xem_gia 'HH10'
 alter proc them_ctpb(
 @mahdb char(10),
 @mahh char(10),
 @sl int,
 @gia money,
 @tt money
 ) as 
 insert into CHITIETPHIEUBAN (MaHDB,Mahh,SoLuong,DonGia,ThanhTien)
 values (@mahdb,@mahh,@sl,@gia,@tt)
 go

 --them_ctpb 'PB02','HH01',1,110000.0000

 alter proc xem_ctpb(@mahdb char(10)) 
 as
 begin
   select HANGHOA.MaHH,TenHH,SoLuong,CHITIETPHIEUBAN.DonGia,ThanhTien
   from CHITIETPHIEUBAN,HANGHOA
   where MaHDB=@mahdb AND CHITIETPHIEUBAN.MaHH=HANGHOA.MaHH
end
go 
xem_ctpb 'PB01'

alter proc TT(@MaHDB char(10))
as 
begin
select  sum(ThanhTien) as TongTien
from CHITIETPHIEUBAN,HOADONBAN
where CHITIETPHIEUBAN.MaHDB=HOADONBAN.MaHDB and HOADONBAN.MaHDB=@MaHDB
end 
go
TT 'PB01'

create proc thanhtien(@sl int,@gia money,@tt money) as
begin
select SoLuong=@sl,DonGia=@gia
from CHITIETPHIEUBAN
where SoLuong!=null and DonGia!=null and @tt=(select SoLuong*DonGia from CHITIETPHIEUBAN)
end

 alter proc sua_ctpb(
 @mahdb char(10),
 @mahh char(10),
 @sl int,
 @gia money,
 @tt money
 ) as 
 update CHITIETPHIEUBAN 
 set SoLuong=@sl,DonGia=@gia,ThanhTien=@tt
 where MaHH=@mahh and MaHDB=@mahdb
 go
 
 alter proc xoa_ctpb(
 @mahdb char(10),
 @mahh char(10)
 ) as
 delete CHITIETPHIEUBAN WHERE MaHDB=@mahdb AND MaHH=@mahh
 go

 --hóa đơn nhập
 create proc them_hdn(
 @mahd char(10),
 @ngay date,
 @manv char(10)
 ) as 
 insert into HOADONNHAP (MaHDN,NgayNhap,MaNV)
 values (@mahd,@ngay,@manv)
 go

 create proc sua_hdn(
 @mahd char(10),
 @ngay date,
 @manv char(10)
 ) as
 update HOADONNHAP 
 set NgayNhap=@ngay,MaNV=@manv
 where MaHDN=@mahd
 go

 create proc xoa_hdn(
 @ma char(10)
 ) as
 delete HOADONNHAP where MaHDN=@ma 
 go
 --chi tiết phiếu nhập
 alter proc them_ctpn(
 @mahdn char(10),
 @mahh char(10),
 @sl int,
 @gia money,
 @tt money
 ) as
 insert into CHITIETPHIEUNHAP (MaHDN,MaHH,SoLuong,DonGia,ThanhTien)
 values (@mahdn,@mahh,@sl,@gia,@tt)
 go

 ALTER proc sua_ctpn(
 @mahdn char(10),
 @mahh char(10),
 @sl int,
 @gia money,
 @tt money
 ) as
 update CHITIETPHIEUNHAP 
 set SoLuong=@sl,DonGia=@gia,ThanhTien=@tt
 where MaHDN=@mahdn and MaHH=@mahh
 go

 ALTER proc xoa_ctpn(
 @mahdn char(10),
 @mahh char(10)
 ) as
 delete CHITIETPHIEUNHAP where  MaHH=@mahh and MaHDN=@mahdn
 go
 create proc xem_ctpn(@mahdn char(10)) 
 as
 begin
   select HANGHOA.MaHH,TenHH,SoLuong,CHITIETPHIEUNHAP.DonGia,ThanhTien
   from CHITIETPHIEUNHAP,HANGHOA
   where MaHDN=@mahdn AND CHITIETPHIEUNHAP.MaHH=HANGHOA.MaHH
end
go 
xem_ctpn 'PN01'
 --trigger 
   --xóa mã hóa đơn bán đồg thời xóa mã bên bảg chi tiết bán 
 create trigger tg_hdb on HOADONBAN 
 for delete
 as 
 begin 
 declare @mahdB char(10)
 select @mahdB=MaHDB from deleted
 delete from CHITIETPHIEUBAN where MaHDB=@mahdB
 end
 go
   --xóa mã hóa đơn nhập ->xóa mã bên chi tiết
   create trigger tg_hdn on HOADONNHAP
 for delete
 as 
 begin 
 declare @mahdn char(10)
 select @mahdn=MaHDN from deleted
 delete from CHITIETPHIEUNHAP where MaHDN=@mahdn
 end
 go
   --thêm mã hóa đơn ->đồg thời bên chi tiết cũg cập nhật thêm mã mới
   create trigger tg_Themhdn on HOADONNHAP
   for insert 
   as
   begin
   declare @ma varchar(10),@ngay datetime,@manv varchar(10)
   select @ma=MaHDN,@ngay=NgayNhap,@manv=MaNV
   from inserted
   insert into CHITIETPHIEUNHAP (MaHDN,ngaynhap,manv)
   values (@ma,@ngay,@manv)
   end
   go

   --thêm hóa đơn bán 
   create trigger tg_Themhdb on HOADONBAN
   for insert 
   as
   begin
   declare @ma varchar(10),@ngay datetime,@manv varchar(10)
   select @ma=MaHDB,@ngay=NgayBan,@manv=MaNV
   from inserted
   insert into CHITIETPHIEUNHAP (MaHDN) 
   values (@ma) 
   end
   go
   --SỬA HÓA ĐƠN BÁN
   create trigger tg_suahdb on HOADONBAN
   for update
   as
   begin
   declare @macu varchar(10),@mamoi varchar(10),@ngaymoi datetime,@ngaycu datetime,@manvcu varchar(10),@manvmoi varchar(10)
   select @macu=MaHDB,@ngaycu=NgayBan,@manvcu=MaNV from deleted
   select @mamoi=MaHDB,@ngaymoi=NgayBan,@manvmoi=MaNV from inserted
   update CHITIETPHIEUBAN
   set MaHDB=@mamoi,ngayban=@ngaymoi,manv=@manvmoi
   where MaHDB=@macu
   end 
   go
   --sửa hóa đơn nhập
   create trigger tg_suahdn on HOADONNHAP
   for update
   as
   begin
   declare @macu varchar(10),@mamoi varchar(10),@ngaymoi datetime,@ngaycu datetime,@manvcu varchar(10),@manvmoi varchar(10)
   select @macu=MaHDN,@ngaycu=NgayNhap,@manvcu=MaNV from deleted
   select @mamoi=MaHDN,@ngaymoi=NgayNhap,@manvmoi=MaNV from inserted
   update CHITIETPHIEUNHAP
   set MaHDN=@mamoi,ngaynhap=@ngaymoi,manv=@manvmoi
   where MaHDN=@macu
   end 
   go
   --khi  thêm hàg hóa thì sẽ thay đổi giá trị cột tổg tiền NHẬP

   CREATE TRIGGER UPDATE_TIEN ON CHITIETPHIEUNHAP
   FOR INSERT,UPDATE
   AS
   BEGIN
    UPDATE CHITIETPHIEUNHAP
	--đây là thành tiền của mỗi mã hàg 
    SET ThanhTien=(SELECT (SoLuong*DonGia)
                  FROM CHITIETPHIEUNHAP P2 
                  WHERE P1.MaHDN=P2.MaHDN AND P1.MaHH=P2.MaHH)
  FROM CHITIETPHIEUNHAP P1,inserted I
  WHERE P1.MaHDN=I.MaHDN AND P1.MaHH=I.MaHH
  UPDATE HOADONNHAP
  --đây là tổg giá trị của cả hóa đơn
  SET TongTien=(SELECT SUM(TongTien) FROM CHITIETPHIEUNHAP C 
				WHERE C.MaHDN=P.MaHDN
				GROUP BY MaHDN)
  FROM HOADONNHAP P,inserted I
  WHERE P.MaHDN=I.MaHDN
END 
GO
--khi xóa hàg hóa thì sẽ thay đổi giá trị cột tổng tiền NHẬP
  create TRIGGER DELETE_TIEN ON chitietphieunhap
  FOR DELETE
  AS
  BEGIN
  UPDATE HOADONNHAP
  SET TongTien=(SELECT SUM(ThanhTien) FROM CHITIETPHIEUNHAP C 
				WHERE C.MaHDN=P.MaHDN
				GROUP BY MaHDN)
  FROM HOADONNHAP P,deleted d
  WHERE P.MaHDN=d.MaHDN  
END
go
--update tien bang con tro phieu ban
DECLARE @MAPN NCHAR(10),@THANHTIEN MONEY,@TONGTIEN MONEY
DECLARE UPDATETIEN1 CURSOR FORWARD_ONLY
FOR SELECT MaHDB,(SoLuong*DonGia) FROM CHITIETPHIEUBAN
OPEN UPDATETIEN1
WHILE 0=0
BEGIN
 FETCH NEXT FROM UPDATETIEN1
 INTO @MAPN,@THANHTIEN
 IF @@FETCH_STATUS<>0
	BREAK
	
 UPDATE CHITIETPHIEUBAN
 SET ThanhTien=@THANHTIEN
 WHERE MaHDB=@MAPN

 UPDATE HOADONBAN
 SET TongTien=(SELECT SUM(ThanhTien) from CHITIETPHIEUBAN CP WHERE CP.MaHDB=P.MaHDB)
 FROM HOADONBAN P
 
END
CLOSE UPDATETIEN1
DEALLOCATE UPDATETIEN1

--update tien bang con tro phieu nhap
DECLARE @MAPB NCHAR(10),@THANHT MONEY,@TONGT MONEY
DECLARE UPDATETIEN2 CURSOR FORWARD_ONLY
FOR SELECT MaHDN,(SoLuong*DonGia) FROM CHITIETPHIEUNHAP
OPEN UPDATETIEN2
WHILE 0=0
BEGIN
 FETCH NEXT FROM UPDATETIEN2
 INTO @MAPB,@THANHT
 IF @@FETCH_STATUS<>0
	BREAK
	
 UPDATE CHITIETPHIEUNHAP
 SET ThanhTien=@THANHT
 WHERE MaHDN=@MAPB

 UPDATE HOADONNHAP
 SET TongTien=(SELECT SUM(ThanhTien) from CHITIETPHIEUNHAP CP WHERE CP.MaHDN=P.MaHDN)
 FROM HOADONNHAP P
 
END
CLOSE UPDATETIEN2
DEALLOCATE UPDATETIEN2

--khi  thêm hàg hóa thì sẽ thay đổi giá trị cột tổg tiền BÁN

   create TRIGGER UPDATE_TIEN ON CHITIETPHIEUBAN
   FOR INSERT,UPDATE
   AS
   BEGIN
    UPDATE CHITIETPHIEUBAN
	--đây là thành tiền của mỗi mã hàg 
    SET ThanhTien=(SELECT (SoLuong*DonGia)
                  FROM CHITIETPHIEUBAN P2 
                  WHERE P1.MaHDB=P2.MaHDB AND P1.MaHH=P2.MaHH)
   FROM CHITIETPHIEUBAN P1,inserted I
  WHERE P1.MaHDB=I.MaHDB AND P1.MaHH=I.MaHH

  update HOADONBAN
  SET TongTien=(select sum(ThanhTien) from CHITIETPHIEUBAN where CHITIETPHIEUBAN.MaHDB=P1.MaHDB)
  FROM HOADONBAN P1,inserted I
  WHERE P1.MaHDB=I.MaHDB
  END 
  GO
  


  --thốg kê hàg hóa tồn kho
  alter proc tk_tonkho(@ngaybd datetime,@ngaykt datetime)
  as
  begin
  if exists(select (b.SoLuong-a.SoLuong) from CHITIETPHIEUBAN a,CHITIETPHIEUNHAP b where  a.MaHH=b.MaHH and (b.SoLuong-a.SoLuong)>0 )
    begin
	   select b.MaHH,(b.SoLuong-a.SoLuong) as soluong
	   from CHITIETPHIEUBAN a,HOADONBAN c,CHITIETPHIEUNHAP b,HOADONNHAP d
	   where a.MaHH=b.MaHH and c.MaHDB=a.MaHDB and d.MaHDN=b.MaHDN and c.NgayBan between @ngaybd and @ngaykt 
	end
	else
	 print N'Hàng đã hết'
 end

 tk_tonkho '2016-10-20','2016-10-21'

--thốg kê các mặt hàg bán từ ngày này đến ngày kia (ngày,số hđ,sl,đơn giá,thành tiền)
 alter proc tk_daban (
@Date1 datetime,
@Date2 datetime)
as
select MaHDB, hh.MaHH,hh.TenHH,b.SoLuong,hh.DonVi,b.Tongtien,TenNCC
from HangHoa hh,NHACUNGCAP nc,
	(select MaHDB,MaHH,Sum(SoLuong) As SoLuong,Sum(ThanhTien) as Tongtien
	from CHITIETPHIEUBAN
	where MaHDB in (select MaHDB from HOADONBAN where NgayBan between @Date1 and @Date2)
	group by MaHDB,MaHH) b
where hh.MaHH=b.MaHH  and nc.MaNCC=hh.MaNCC
ORDER BY MaHDB 
go
tk_daban '2016-10-20','2016-10-21'
--thủ tục thốg kê hàg trong kho đã bán 
alter proc tk_kho(
@date datetime,
@Date2 datetime
) as
select TenKho,TenNHom,TenHH,a.soluong
FROM KHO,NHOMHANG,HANGHOA,(select MaHH,sum(SoLuong) as soluong
                   from CHITIETPHIEUBAN
				   where  MaHDB in (select MaHDB from HOADONBAN where NgayBan between @Date and @Date2)
				   group by MaHH  )a
where NHOMHANG.MaKho=KHO.MaKho and NHOMHANG.MaNhom=HANGHOA.MaNhom and a.MaHH=HANGHOA.MaHH
order by soluong desc
go
tk_kho '2014-10-20','2014-10-21'
--thống kê hàg còn trong kho
alter proc tk_tonkho1(
@date1 datetime
) as
select TenKho,TenNHom,TenHH,(b.soluong-a.soluong) as soluong
FROM KHO,NHOMHANG,HANGHOA,(select MaHH,sum(SoLuong) as soluong
                   from CHITIETPHIEUBAN
				   where  MaHDB in (select MaHDB from HOADONBAN where NgayBan <= @Date1 )
				   group by MaHH  )a,(select MaHH,sum(SoLuong) as soluong
                   from CHITIETPHIEUNHAP
				   where  MaHDN in (select MaHDN from HOADONNHAP where  NgayNhap <= @Date1)
				   group by MaHH  )b
where NHOMHANG.MaKho=KHO.MaKho and NHOMHANG.MaNhom=HANGHOA.MaNhom and a.MaHH=HANGHOA.MaHH
order by soluong desc
go
tk_tonkho1 '2014-10-21'

--thốg kê sl hàg hóa còn khi cho biết mã kho và mã nhóm
alter proc tk_tonkho2(
@makho varchar(10),
@manhom Nvarchar(50),
@date datetime
) as
select TenHH,(b.soluong-a.soluong) as soluong
FROM KHO,NHOMHANG,HANGHOA,(select MaHH,sum(SoLuong) as soluong
                   from CHITIETPHIEUBAN
				   where  MaHDB in (select MaHDB from HOADONBAN where NgayBan <= @Date )
				   group by MaHH  )a,(select MaHH,sum(SoLuong) as soluong
                   from CHITIETPHIEUNHAP
				   where  MaHDN in (select MaHDN from HOADONNHAP where  NgayNhap <= @Date)
				   group by MaHH  )b
where NHOMHANG.MaKho=KHO.MaKho and NHOMHANG.MaNhom=HANGHOA.MaNhom and a.MaHH=HANGHOA.MaHH and kho.MaKho=@makho and NHOMHANG.MaNhom=@manhom
order by soluong desc
go
tk_tonkho2 'K01','NH01', '2014-10-21'
--thốg kê hàg còn 

  select b.MaHDB,TongTien,MaHH,SoLuong,count(b.MaHDB) SoHD
  from CHITIETPHIEUBAN a,HOADONBAN b
  WHERE a.MaHDB=B.MaHDB and b.NgayBan between '2014-10-20' and '2014-10-22'
  group by b.MaHDB,TongTien,MaHH,SoLuong

--xem dsnv
create proc XemDSNV
as
select *from NHANVIEN
go