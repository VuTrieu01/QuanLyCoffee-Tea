--Tao database QuanLyCoffeeAndTea
Create Database QuanLyCoffeeAndTea
go

Use QuanLyCoffeeAndTea
go

--Tao bang NHANVIEN
Create table NHANVIEN(
NhanVienID int IDENTITY(1,1),
TenNV nvarchar(50),
NgaySinh Datetime,
GioiTinh nvarchar(5),
SDT char(10),
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
DanhMucID int IDENTITY(1,1),
TenDM nvarchar(50),
Primary Key(DanhMucID))
go

--Tao bang THUCDON
Create table THUCDON(
ThucDonID int IDENTITY(1,1),
TenThucDon nvarchar(50),
KichCo nvarchar(50),
HinhAnh image,
Gia float,
DanhMucID int not null,
Primary Key(ThucDonID),
foreign key (DanhMucID) references DANHMUC)
go

--Tao bang SANPHAM
Create table SANPHAM(
SanPhamID int IDENTITY(1,1),
TenSanPham nvarchar(50),
HinhAnh image,
Gia float,
DanhMucID int not null,
Primary Key(SanPhamID),
foreign key (DanhMucID) references DANHMUC)
go

--Tao bang THIETBI
Create table THIETBI(
ThietBiID int IDENTITY(1,1),
TrangThai bit,
Primary Key(ThietBiID))
go

--Tao bang HOADON
Create table HOADON(
HoaDonID int IDENTITY(1,1),
ThietBiID int,
NgayHD Datetime,
TrangThai bit,
Primary Key(HoaDonID),
foreign key (ThietBiID) references THIETBI)
go

--Tao bang CHITIETHOADON
Create table CHITIETHOADON(
IDCTHD int IDENTITY(1,1),
HoaDonID int,
ThucDonID int,
SanPhamID int,
NhanVienID int not null,
SoLuong int,
GhiChu nvarchar(100),
ThanhTien float,
Primary Key(IDCTHD),
foreign key (HoaDonID) references HOADON,
foreign key (ThucDonID) references THUCDON,
foreign key (SanPhamID) references SANPHAM,
foreign key (NhanVienID) references NHANVIEN)
go


--Them du lieu HOADON
INSERT INTO [dbo].[HOADON]
           ([ThietBiID]
           ,[NgayHD]
           ,[TrangThai])
     VALUES
           (1
           ,2022-01-02
           ,0)
GO

INSERT INTO [dbo].[HOADON]
           ([ThietBiID]
           ,[NgayHD]
           ,[TrangThai])
     VALUES
           (2
           ,2022-01-02
           ,0)
GO

INSERT INTO [dbo].[HOADON]
           ([ThietBiID]
           ,[NgayHD]
           ,[TrangThai])
     VALUES
           (3
           ,2022-01-02
           ,1)
GO

INSERT INTO [dbo].[HOADON]
           ([ThietBiID]
           ,[NgayHD]
           ,[TrangThai])
     VALUES
           (4
           ,2022-01-02
           ,0)
GO

--Them du lieu CHITIETHOADON
INSERT INTO [dbo].[CHITIETHOADON]
           ([HoaDonID]
           ,[ThucDonID]
           ,[SanPhamID]
           ,[NhanVienID]
           ,[SoLuong]
           ,[GhiChu]
           ,[ThanhTien])
     VALUES
           (1, 28, NULL, 2, 1, NULL, 20000)
GO

INSERT INTO [dbo].[CHITIETHOADON]
           ([HoaDonID]
           ,[ThucDonID]
           ,[SanPhamID]
           ,[NhanVienID]
           ,[SoLuong]
           ,[GhiChu]
           ,[ThanhTien])
     VALUES
           (1, 29, NULL, 2, 1, NULL, 25000)
GO

INSERT INTO [dbo].[CHITIETHOADON]
           ([HoaDonID]
           ,[ThucDonID]
           ,[SanPhamID]
           ,[NhanVienID]
           ,[SoLuong]
           ,[GhiChu]
           ,[ThanhTien])
     VALUES
           (2, 28, NULL, 2, 1, NULL, 20000)
GO

INSERT INTO [dbo].[CHITIETHOADON]
           ([HoaDonID]
           ,[ThucDonID]
           ,[SanPhamID]
           ,[NhanVienID]
           ,[SoLuong]
           ,[GhiChu]
           ,[ThanhTien])
     VALUES
           (2, 29, NULL, 2, 1, NULL, 25000)
GO

INSERT INTO [dbo].[CHITIETHOADON]
           ([HoaDonID]
           ,[ThucDonID]
           ,[SanPhamID]
           ,[NhanVienID]
           ,[SoLuong]
           ,[GhiChu]
           ,[ThanhTien])
     VALUES
           (3, 28, NULL, 2, 1, NULL, 20000)
GO

INSERT INTO [dbo].[CHITIETHOADON]
           ([HoaDonID]
           ,[ThucDonID]
           ,[SanPhamID]
           ,[NhanVienID]
           ,[SoLuong]
           ,[GhiChu]
           ,[ThanhTien])
     VALUES
           (3, 29, NULL, 2, 1, NULL, 25000)
GO

INSERT INTO [dbo].[CHITIETHOADON]
           ([HoaDonID]
           ,[ThucDonID]
           ,[SanPhamID]
           ,[NhanVienID]
           ,[SoLuong]
           ,[GhiChu]
           ,[ThanhTien])
     VALUES
           (4, 28, NULL, 2, 1, NULL, 20000)
GO

INSERT INTO [dbo].[CHITIETHOADON]
           ([HoaDonID]
           ,[ThucDonID]
           ,[SanPhamID]
           ,[NhanVienID]
           ,[SoLuong]
           ,[GhiChu]
           ,[ThanhTien])
     VALUES
           (4, 29, NULL, 2, 1, NULL, 25000)
GO