﻿create table HANGHOA(
MaHH char(10) primary key,
TenHH nvarchar(50),
NoiSX nvarchar(50),
DonVi nvarchar(10),
MaNCC char(10) ,
MaNhom char(10) 
)
alter table HANGHOA
  add constraint ZK foreign key (MaNCC) references NHACUNGCAP(MaNCC)
alter table HANGHOA
  add constraint XK foreign key (MaNhom) references NHOMHANG(MaNhom)


SELECT * FROM HANGHOA
INSERT INTO HANGHOA VALUES('HH01',N'SỮA RỬA MẶT KR',N'HÀN QUỐC',N'LỌ','NCC01','NH01')
INSERT INTO HANGHOA VALUES('HH02',N'KEM DƯỠNG DA JP',N'NHẬT BẢN',N'HỘP','NCC02','NH01')
INSERT INTO HANGHOA VALUES('HH03',N'VỞ KẺ NGANG',N'VIỆT NAM',N'TẬP','NCC03','NH04')
INSERT INTO HANGHOA VALUES('HH04',N'BÚT BI',N'VIỆT NAM',N'CHIẾC','NCC03','NH04')
INSERT INTO HANGHOA VALUES('HH05',N'CHẢO CHỐNG DÍNH',N'VIỆT NAM',N'CHIẾC','NCC08','NH06')
INSERT INTO HANGHOA VALUES('HH06',N'THỊT GÀ',N'VIỆT NAM',N'KG','NCC07','NH03')
INSERT INTO HANGHOA VALUES('HH07',N'ÁO SƠ MI',N'VIỆT NAM',N'CHIẾC','NCC04','NH02')
INSERT INTO HANGHOA VALUES('HH08',N'COCA COLA',N'MỸ',N'CHAI','NCC05','NH05')
INSERT INTO HANGHOA VALUES('HH09',N'GIÀY THỂ THAO',N'VIỆT NAM',N'ĐÔI','NCC06','NH02')
INSERT INTO HANGHOA VALUES('HH10',N'VÁY',N'HÀN QUỐC',N'CHIẾC','NCC06','NH02')

INSERT INTO HANGHOA VALUES('HH11',N'ẤM SIÊU TỐC',N'VIỆT NAM',N'CHIẾC','NCC08','NH06')
INSERT INTO HANGHOA VALUES('HH12',N'BẾP GAS',N'VIỆT NAM',N'CHIẾC','NCC08','NH06')
INSERT INTO HANGHOA VALUES('HH13',N'BẾP TỪ',N'VIỆT NAM',N'CHIẾC','NCC08','NH06')
INSERT INTO HANGHOA VALUES('HH14',N'BÚT CHÌ MÀU',N'VIỆT NAM',N'CHIẾC','NCC03','NH04')
INSERT INTO HANGHOA VALUES('HH15',N'CỤC TẨY',N'VIỆT NAM',N'CHIẾC','NCC03','NH04')
INSERT INTO HANGHOA VALUES('HH16',N'THƯỚC KẺ',N'VIỆT NAM',N'CHIẾC','NCC03','NH04')
INSERT INTO HANGHOA VALUES('HH17',N'NƯỚC HOA HỒNG KR',N'HÀN QUỐC',N'LỌ','NCC01','NH01')
INSERT INTO HANGHOA VALUES('HH18',N'XỊT KHOÁNG KR',N'HÀN QUỐC',N'LỌ','NCC01','NH01')
INSERT INTO HANGHOA VALUES('HH19',N'TRỊ NÁM KR',N'HÀN QUỐC',N'LỌ','NCC01','NH01')
INSERT INTO HANGHOA VALUES('HH20',N'KEM CHỐNG NẮNG JP',N'NHẬT BẢN',N'LỌ','NCC02','NH01')
 INSERT INTO HANGHOA VALUES('HH21',N'SỮA TẮM JP',N'NHẬT BẢN',N'HỘP','NCC02','NH01')
INSERT INTO HANGHOA VALUES('HH22',N'KEM NỀN BB',N'NHẬT BẢN',N'HỘP','NCC02','NH01')
INSERT INTO HANGHOA VALUES('HH23',N'THỊT BÒ',N'VIỆT NAM',N'KG','NCC07','NH03')
INSERT INTO HANGHOA VALUES('HH24',N'CÁ HỒI',N'VIỆT NAM',N'KG','NCC07','NH03')
INSERT INTO HANGHOA VALUES('HH25',N'TÔM',N'VIỆT NAM',N'KG','NCC07','NH03')
INSERT INTO HANGHOA VALUES('HH26',N'GHẸ',N'VIỆT NAM',N'KG','NCC07','NH03')
INSERT INTO HANGHOA VALUES('HH27',N'SÒ',N'VIỆT NAM',N'KG','NCC07','NH03')
INSERT INTO HANGHOA VALUES('HH28',N'GIÀY LƯỜI',N'VIỆT NAM',N'ĐÔI','NCC06','NH02')
INSERT INTO HANGHOA VALUES('HH29',N'DÉP',N'VIỆT NAM',N'ĐÔI','NCC06','NH02')
INSERT INTO HANGHOA VALUES('HH30',N'ÁO PHÔNG NỮ',N'VIỆT NAM',N'CHIẾC','NCC04','NH02')
INSERT INTO HANGHOA VALUES('HH31',N'QUẦN JEAN',N'VIỆT NAM',N'CHIẾC','NCC04','NH02')
INSERT INTO HANGHOA VALUES('HH32',N'QUẦN SOOC',N'VIỆT NAM',N'CHIẾC','NCC04','NH02')



create table CHITIETPHIEUBAN(
MaHDB char(10) ,
MaHH char(10),
SoLuong int,
DonGia money,
primary key(MaHDB,MaHH)
)
alter table CHITIETPHIEUBAN
  add constraint MK foreign key (MaHDB) references HOADONBAN(MaHDB)
alter table CHITIETPHIEUBAN
  add constraint NK foreign key (MaHH) references HANGHOA(MaHH)
alter table CHITIETPHIEUBAN
  add ThanhTien int
  alter table CHITIETPHIEUBAN alter column ThanhTien money

INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH01',1,110000,110000)
INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH02',1,210000,210000)
INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH03',1,15000,15000)
INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH04',1,25000,25000)
INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH05',1,260000,260000)
INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH06',1,110000,110000)
INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH07',1,210000,210000)
INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH08',1,23000,23000)
INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH09',1,210000,210000)
INSERT INTO CHITIETPHIEUBAN VALUES('PB01','HH10',1,160000,160000)

INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH11',1,110000,110000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH12',1,410000,410000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH13',1,360000,360000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH14',1,25000,25000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH15',1,11000,11000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH16',1,20000,20000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH17',1,110000,110000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH18',1,135000,135000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH19',1,410000,410000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN02','HH20',1,140000,140.000)

INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH21',1,70.000,70.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH22',1,210.000,210.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH23',1,160.000,160.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH24',1,210.000,210.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH25',1,210.000,210.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH26',1,160.000,160.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH27',1,110.000,110.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH28',1,110.000,110.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH29',1,25.000,25.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH30',1,60.000,60.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH31',1,260.000,260.000)
INSERT INTO CHITIETPHIEUBAN VALUES('PN03','HH32',1,160.000,160.000)

INSERT INTO CHITIETPHIEUBAN VALUES('PN04','HH32',1,160.000,160.000)





create table CHITIETPHIEUNHAP(
MaHDN char(10),
MaHH char(10) ,
SoLuong int,
DonGia money,
primary key (MaHDN,MaHH)
)
alter table CHITIETPHIEUNHAP
  add constraint DK foreign key (MaHDN) references HOADONNHAP(MaHDN) 
alter table CHITIETPHIEUNHAP
  add constraint OK foreign key (MaHH) references HANGHOA(MaHH)
 alter table CHITIETPHIEUNHAP
 add TongTien money
 
 

 INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH01',200,100000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH02',30,200000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH03',40,5000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH04',40,15000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH05',30,250000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH06',50,100000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH07',50,200000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH08',100,13000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH09',50,200000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH10',20,150000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH11',20,100000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH12',10,400000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH13',10,350000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH14',40,15000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH15',50,1000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH16',40,10000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH17',20,100000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH18',20,125000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH19',20,400000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH20',20,130000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH21',20,60000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH22',20,200000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH23',30,150000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH24',30,200000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH25',30,200000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH26',30,150000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH27',30,100000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH28',40,100000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH29',50,15000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH30',50,50000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH31',50,250000)
INSERT INTO CHITIETPHIEUNHAP VALUES('PN01','HH32',30,150000)




CREATE table HOADONBAN (
MaHDB char(10) primary key,
NgayBan date,
MaNV char(10)
)
ALTER TABLE HOADONBAN ADD MaKH char(10)
alter table HOADONBAN
  add constraint AK foreign key (MaNV) references NHANVIEN(MaNV)
alter table HOADONBAN
   add TongTien int 
alter table HOADONBAN
  add constraint QK foreign key (MaKH) references KHACHHANG(MaKH)

INSERT INTO HOADONBAN VALUES('PB01','2014/10/20','NV03',1333000)
INSERT INTO HOADONBAN VALUES('PB02','2014/10/21','NV06',1731000)
INSERT INTO HOADONBAN VALUES('PB03','2014/10/22','NV07',1860000)

INSERT INTO HOADONBAN VALUES('PB04','2014/10/22','NV07',1860000)




create table HOADONNHAP(
MaHDN char(10) primary key,
NgayNhap date,
MaNV char(10) 
)
alter table HOADONNHAP
  add constraint UK foreign key (MaNV) references NHANVIEN(MaNV)
alter table HOADONNHAP
 ADD TongTien money
INSERT INTO HOADONNHAP VALUES('PN01','2014/10/10','NV01')




create table KHO(
MaKho char(10) primary key,
TenKho nvarchar(50),
ViTri nvarchar(100),
MaNV char(10)
)
alter table KHO
add constraint EK FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
alter table KHO
 alter column vitri char(50)
INSERT INTO KHO VALUES('K01',N'MĨ PHẨM',N'KHO A','NV01')
INSERT INTO KHO VALUES('K02',N'THỜI TRANG',N'KHO B','NV01')
INSERT INTO KHO VALUES('K03',N'THỰC PHẨM',N'KHO C','NV03')
INSERT INTO KHO VALUES('K04',N'HỌC TẬP',N'KHO D','NV06')
INSERT INTO KHO VALUES('K05',N'ĐỒ UỐNG',N'KHO C','NV03')
INSERT INTO KHO VALUES('K06',N'GIA DỤNG',N'KHO E','NV06')



create table NHACUNGCAP(
MaNCC char(10) primary key,
TenNCC nvarchar(50),
DiaChi nvarchar(50),
SDT nvarchar(15)
)
SELECT *FROM NHACUNGCAP
INSERT INTO NHACUNGCAP VALUES('NCC01',N'KOREA-VIETNAM ',N'Q10-TP HCM',N'08888456')
INSERT INTO NHACUNGCAP VALUES('NCC02',N'JAPAN-VIETNAM',N'ĐỐNG ĐA-HÀ NỘI',N'04666321')
INSERT INTO NHACUNGCAP VALUES('NCC03',N'CÔNG TY GIẤY HẢI TIẾN',N'GIẢI PHÓNG-HÀ NỘI',N'04559863')
INSERT INTO NHACUNGCAP VALUES('NCC04',N'CÔNG TY MAY 10',N'GIA LÂM-HÀ NỘI',N'04232545')
INSERT INTO NHACUNGCAP VALUES('NCC05',N'COCA-COLA',N'Q8-TP HCM',N'08759963')
INSERT INTO NHACUNGCAP VALUES('NCC06',N'CÔNG TY TNHH MAI ANH',N'BA ĐÌNH-HÀ NỘI',N'0978556888')
INSERT INTO NHACUNGCAP VALUES('NCC07',N'TRANG TRẠI HTX',N'HẢI PHÒNG',N'0967453123')
INSERT INTO NHACUNGCAP VALUES('NCC08',N'GIA DỤNG SUN-HOUSE',N'HÀ NỘI',N'04123765')


create table NHOMHANG(
MaNhom char(10) primary key,
TenNhom nvarchar(50),
MaKho char(10) 
)
alter table NHOMHANG add constraint KK foreign key (MaKho) references KHO(MaKho)

INSERT INTO NHOMHANG VALUES('NH01',N'MĨ PHẨM','K01')
INSERT INTO NHOMHANG VALUES('NH02',N'THỜI TRANG','K02')
INSERT INTO NHOMHANG VALUES('NH03',N'THỰC PHẨM','K03')
INSERT INTO NHOMHANG VALUES('NH04',N'HỌC TẬP','K04')
INSERT INTO NHOMHANG VALUES('NH05',N'ĐỒ UỐNG','K05')
INSERT INTO NHOMHANG VALUES('NH06',N'GIA DỤNG','K06')


create table KHACHHANG(
MaKH char(10) primary key,
TenKH nvarchar(50),
NgaySinh datetime,
DiaChi nvarchar(50),
SDT int,
DiemTL int
)
alter TABLE KHACHHANG ALTER COLUMN SDT CHAR(15)
INSERT INTO KHACHHANG VALUES('KH01',N'ĐINH NGỌC ÁNH','22/11/1997',N'SƠN LA',013485677382,10)

create table NHANVIEN(
MaNV char(10) primary key,
TenNV nvarchar(30),
GioiTinh nvarchar(10) check(GioiTinh in(N'Nam',N'Nữ')),
NgaySinh date,
DiaChi nvarchar(50)
)
alter table NHANVIEN add Luong int 
alter table NHANVIEN alter column Luong money
		    					 
INSERT INTO NHANVIEN VALUES('NV01',N'PHẠM VĂN TUẤN',N'NAM','5/6/1993',N'CẦU GIẤY-HÀ NỘI')
INSERT INTO NHANVIEN VALUES('NV02',N'TRẦN THỊ THU PHƯƠNG',N'NỮ','1990/8/15',N'THANH XUÂN-HÀ NỘI')	
INSERT INTO NHANVIEN VALUES('NV03',N'ĐINH MẠNH TRƯỜNG ',N'NAM','1990/4/25',N'CẦU GIẤY-HÀ NỘI')	
INSERT INTO NHANVIEN VALUES('NV04',N'NGUYỄN THỊ THU HUYỀN',N'NỮ','1989/12/5',N'TỪ LIÊM-HÀ NỘI')	
INSERT INTO NHANVIEN VALUES('NV05',N'ĐINH THỊ YẾN',N'NỮ','1990/6/7',N'ĐỐNG ĐA-HÀ NỘI')	
INSERT INTO NHANVIEN VALUES('NV06',N'HOÀNG TUẤN ANH',N'NAM','1993/6/6',N'CẦU GIẤY-HÀ NỘI')	
INSERT INTO NHANVIEN VALUES('NV07',N'LÊ VĂN TÚ',N'NAM','1995/3/27',N'BA ĐÌNH-HÀ NỘI')	
INSERT INTO NHANVIEN VALUES('NV08',N'VŨ THỊ THU HÀ',N'NỮ','1993/2/18',N'THANH XUÂN-HÀ NỘI')	
INSERT INTO NHANVIEN VALUES('NV09',N'LÊ THỊ QUỲNH ',N'NỮ','1993/1/21',N'THANH XUÂN-HÀ NỘI')	
INSERT INTO NHANVIEN VALUES('NV10',N'BÙI VĂN HÙNG',N'NAM','1993/11/4',N'CẦU GIẤY-HÀ NỘI')	
	
