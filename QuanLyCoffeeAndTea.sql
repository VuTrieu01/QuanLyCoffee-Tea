--Tao database QuanLyCoffeeAndTea
Create Database QuanLyCoffeeAndTea
go

Use QuanLyCoffeeAndTea
go

--Tao bang NHANVIEN
Create table NHANVIEN(
NhanVienID int not null,
TenNV nvarchar(50),
NgaySinh Datetime,
GioiTinh bit,
SDT int,
ChucVu nvarchar(20),
Primary Key(NhanVienID))
go

--Tao bang ACCOUNT
Create table ACCOUNT(
UserID char(10) not null,
[Password] char(10),
Quyen bit,
NhanVienID int not null,
Primary Key(UserID, NhanVienID),
foreign key (NhanVienID) references NHANVIEN)
go

--Tao bang DANHMUC
Create table DANHMUC(
DanhMucID int not null,
TenDM nvarchar(50),
Primary Key(DanhMucID))
go

--Tao bang THUCDON
Create table THUCDON(
ThucDonID int not null,
TenThucDon nvarchar(50),
Gia float,
DanhMucID int not null,
Primary Key(ThucDonID),
foreign key (DanhMucID) references DANHMUC)
go

--Tao bang SANPHAM
Create table SANPHAM(
SanPhamID int not null,
TenSanPham nvarchar(50),
Gia float,
DanhMucID int not null,
Primary Key(SanPhamID),
foreign key (DanhMucID) references DANHMUC)
go

--Tao bang THIETBI
Create table THIETBI(
ThietBiID int not null,
TrangThai bit,
Primary Key(ThietBiID))
go

--Tao bang HOADON
Create table HOADON(
HoaDonID int not null,
ThucDonID int,
SanPhamID int,
ThietBiID int,
NhanVienID int not null,
NgayHD Datetime,
SoLuong int,
ThanhTien float,
Primary Key(HoaDonID),
foreign key (ThucDonID) references THUCDON,
foreign key (SanPhamID) references SANPHAM,
foreign key (ThietBiID) references THIETBI,
foreign key (NhanVienID) references NHANVIEN)
go