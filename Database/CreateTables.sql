create database HospitalManagement
go
use HospitalManagement
go


create table PhongBan(
ID int identity(1,1) primary key,
Name nvarchar(50)
)

create table DVKhamBenh(
ID int identity(1,1) primary key,
Name nvarchar(200),
Price int
)

create table Thuoc(
ID int identity(1,1) primary key,
Name nvarchar(100),
Price int
)

create table PhongKham(
ID int identity(1,1) primary key,
Name nvarchar(100)
)

create table BenhNhan(
ID int identity(1,1) primary key,
Name nvarchar(100),
DateOfBirth date,
PersonalID varchar(20) unique,
PhoneNumber varchar(20) unique,
Address nvarchar(200)
)

create table BacSi(
ID int identity(1,1) primary key,
Name nvarchar(100),
DateOfBirth date,
PersonalID varchar(20) unique,
PhoneNumber varchar(20) unique,
Address nvarchar(200),
Sex bit,
Email varchar(100) unique,
Salary varbinary(max)
)

create table BoPhan(
ID int identity(1,1) primary key,
Name nvarchar(100),
PhongBanID int
foreign key (PhongBanID) references PhongBan(ID)
)

create table NhanVien(
ID int identity(1,1) primary key,
Name nvarchar(100),
DateOfBirth date,
Sex bit,
PersonalId varchar(20) unique,
Email varchar(100) unique,
PhoneNumber varchar(20) unique,
Salary varbinary(max),
Role nvarchar(50),
Address nvarchar(200),
PhongBanID int,
BoPhanID int,
foreign key (PhongBanID) references PhongBan(ID),
foreign key (BoPhanID) references BoPhan(ID)
)


create table CaTrucPhong(
StartTime datetime,
EndTime datetime,
BacSiID int,
PhongKhamID int
foreign key (BacSiID) references BacSi(ID),
foreign key (PhongKhamID) references PhongKham(ID)
)

create table ToaThuoc(
ID int identity(1,1) primary key,
PayDate date,
TotalPrice int,
BenhNhanID int,
NhanVienID int,
CTKB_ID int,
foreign key (BenhNhanID) references BenhNhan(ID),
foreign key (NhanVienID) references NhanVien(ID),
)

ALTER TABLE ToaThuoc
ADD CONSTRAINT FK_ToaThuoc_CTKB FOREIGN KEY (CTKB_ID)
    REFERENCES ChiTietKhamBenh(ID);

create table ChiTietKhamBenh(
ID int identity(1,1) primary key,
BacSiID int,
BenhNhanID int,
ToaThuocID int,
Description ntext,
NgayKham date,
TotalPrice int
foreign key (BacSiID) references BacSi(ID),
foreign key (BenhNhanID) references BenhNhan(ID),
foreign key (ToaThuocID) references ToaThuoc(ID)
)


create table ChiTietToaThuoc(
Amount int,
Description ntext,
ThuocID int,
ToaThuocID int
foreign key (ThuocID) references Thuoc(ID),
foreign key (ToaThuocID) references ToaThuoc(ID)
)

create table ChiTietKhamBenh_DV(
ChiTietID int,
DichVuID int,
foreign key (ChiTietID) references ChiTietKhamBenh(ID),
foreign key (DichVuID) references DVKhamBenh(ID)
)
