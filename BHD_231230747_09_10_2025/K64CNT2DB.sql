CREATE DATABASE K64CNT2DB
GO
Use K64CNT2DB
GO
CREATE TABLE QUAN_TRI(
     ID  INT PRIMARY KEY IDENTITY,
     TaiKhoan  varchar(25) UNIQUE ,
     MatKhau  varchar(255)  ,
     TrangThai  tinyint  
)
GO


CREATE TABLE LOAI_SAN_PHAM(
     ID  INT PRIMARY KEY IDENTITY,
     MaLoai  varchar(255) UNIQUE ,
     TenLoai  nvarchar(255)  ,
     TrangThai  tinyint  
)
GO

CREATE TABLE SAN_PHAM(
     ID  INT PRIMARY KEY IDENTITY,
     MaSanPham  varchar(255) UNIQUE ,
     TenSanPham  nvarchar(255)  ,
     HinhAnh  nvarchar(255)  ,
     SoLuong  int  ,
     DonGia  float  ,
     MaLoai  int REFERENCES LOAI_SAN_PHAM(ID) ,
     TrangThai  tinyint  ,
)
GO


CREATE TABLE KHACH_HANG(
     ID  INT PRIMARY KEY IDENTITY,
     MaKhachHang  varchar(255) UNIQUE ,
     HoTenKhachHang  nvarchar(255)  ,
     Email  varchar(255) UNIQUE ,
     MaKhau  varchar(255)  ,
     DienThoai  varchar(10) UNIQUE ,
     DiaChi  nvarchar(255)  ,
     NgayDangKy  Datetime  ,
     TrangThai  tinyint  
)
GO


CREATE TABLE HOA_DON(
     ID  INT PRIMARY KEY IDENTITY,
     MaHoaDon  varchar(255) UNIQUE ,
     MaKhaHang  int REFERENCES KHACH_HANG(ID) ,
     NgayHoaDon  Datetime  ,
     NgayNhan  Datetime  ,
     HoTenKhachHang  nvarchar(255)  ,
     Email  varchar(255)  ,
     DienThoai  varchar(10)  ,
     DiaChi  nvarchar(255)  ,
     TongTriGia  float  ,
     TrangThai  tinyint  
)
GO


CREATE TABLE CT_HOA_DON(
     ID  INT PRIMARY KEY IDENTITY,
     HoaDonID  int REFERENCES HOA_DON(ID) ,
     SanPhamID  int REFERENCES SAN_PHAM (ID) ,
     SoLuongMua  int  ,
     DonGiaMua  float  ,
     ThanhTien  float  ,
     TrangThai  tinyint  
)
GO