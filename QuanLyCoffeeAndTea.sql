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

--Tao bang DANHMUCTHUCDON
Create table DANHMUCTHUCDON(
DanhMucTDID int IDENTITY(1,1),
TenDM nvarchar(50),
Primary Key(DanhMucTDID))
go

--Tao bang DANHMUCSANPHAM
Create table DANHMUCSANPHAM(
DanhMucSPID int IDENTITY(1,1),
TenDM nvarchar(50),
Primary Key(DanhMucSPID))
go

--Tao bang THUCDON
Create table THUCDON(
ThucDonID int IDENTITY(1,1),
TenThucDon nvarchar(50),
HinhAnh image,
Gia float,
DanhMucTDID int not null,
Primary Key(ThucDonID),
foreign key (DanhMucTDID) references DANHMUCTHUCDON)
go

--Tao bang SANPHAM
Create table SANPHAM(
SanPhamID int IDENTITY(1,1),
TenSanPham nvarchar(50),
QuyCach nvarchar(30),
HinhAnh image,
Gia float,
DanhMucSPID int not null,
Primary Key(SanPhamID),
foreign key (DanhMucSPID) references DANHMUCSANPHAM)
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

--Them du lieu NHANVIEN
INSERT INTO [dbo].[NHANVIEN]
           ([TenNV]
           ,[NgaySinh]
           ,[GioiTinh]
           ,[SDT]
           ,[ChucVu])
     VALUES
           ('Nguyễn Ngọc Vũ Triều', 2001-03-10, 'Nam'
           ,0125698745, 'Admin')
GO

INSERT INTO [dbo].[NHANVIEN]
           ([TenNV]
           ,[NgaySinh]
           ,[GioiTinh]
           ,[SDT]
           ,[ChucVu])
     VALUES
           ('Nguyễn Thị A', 2001-03-10, 'Nữ'
           ,0123658749, 'User')
GO

--Them du lieu ACCOUNT
INSERT INTO [dbo].[ACCOUNT]
           ([UserID]
           ,[Password]
           ,[Quyen]
           ,[NhanVienID])
     VALUES
           ('admin', '1', 1, 1)
GO

INSERT INTO [dbo].[ACCOUNT]
           ([UserID]
           ,[Password]
           ,[Quyen]
           ,[NhanVienID])
     VALUES
           ('user', '1', 0, 2)
GO

--Them du lieu DANHMUCTHUCDON
INSERT INTO [dbo].[DANHMUCTHUCDON]
           ([TenDM])
     VALUES
           ('Thức uống')
GO

INSERT INTO [dbo].[DANHMUCTHUCDON]
           ([TenDM])
     VALUES
           ('Snacks')
GO

INSERT INTO [dbo].[DANHMUCTHUCDON]
           ([TenDM])
     VALUES
           ('Bakery')
GO

--Them du lieu DANHMUCSANPHAM
INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Trà hộp')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Trà túi lọc')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Trà túi tam giác')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Trà hộp giấy')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Lễ hộp')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Trà hộp xám')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Trà gói')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Trà Thái Nguyên')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Trà gói cao cấp')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Trà vạn lý hương')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Cà phê Set')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Cà phê phin nhôm')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Cà phê mùi')
GO

INSERT INTO [dbo].[DANHMUCSANPHAM]
           ([TenDM])
     VALUES
           ('Cà phê hạt')
GO

--Them du lieu THIETBI

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO

INSERT INTO [dbo].[THIETBI]
           ([TrangThai])
     VALUES
           (0)
GO