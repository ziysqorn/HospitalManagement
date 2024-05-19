use HospitalManagement
go

-- PhongBan
INSERT INTO PhongBan (Name) VALUES (N'Phòng Tài vụ');
INSERT INTO PhongBan (Name) VALUES (N'Phòng Bán thuốc');
INSERT INTO PhongBan (Name) VALUES (N'Phòng Khám C');
INSERT INTO PhongBan (Name) VALUES (N'Phòng Khám D');
INSERT INTO PhongBan (Name) VALUES (N'Phòng Khám E');

-- DVKhamBenh
INSERT INTO DVKhamBenh (Name, Price) VALUES (N'Xét nghiệm máu', 100000);
INSERT INTO DVKhamBenh (Name, Price) VALUES (N'Siêu âm bụng', 150000);
INSERT INTO DVKhamBenh (Name, Price) VALUES (N'Chụp cắt lớp MRI', 500000);
INSERT INTO DVKhamBenh (Name, Price) VALUES (N'Khám nội soi', 300000);
INSERT INTO DVKhamBenh (Name, Price) VALUES (N'X-quang phổi', 200000);

-- Thuoc
INSERT INTO Thuoc (Name, Price) VALUES (N'Paracetamol', 20000);
INSERT INTO Thuoc (Name, Price) VALUES (N'Amoxicillin', 30000);
INSERT INTO Thuoc (Name, Price) VALUES (N'Ibuprofen', 25000);
INSERT INTO Thuoc (Name, Price) VALUES (N'Dexamethasone', 40000);
INSERT INTO Thuoc (Name, Price) VALUES (N'Loperamide', 35000);

-- PhongKham
INSERT INTO PhongKham (Name) VALUES (N'Phòng khám 1');
INSERT INTO PhongKham (Name) VALUES (N'Phòng khám 2');
INSERT INTO PhongKham (Name) VALUES (N'Phòng khám 3');
INSERT INTO PhongKham (Name) VALUES (N'Phòng khám 4');
INSERT INTO PhongKham (Name) VALUES (N'Phòng khám 5');

-- BenhNhan
INSERT INTO BenhNhan (Name, DateOfBirth, PersonalID, PhoneNumber, Address) VALUES (N'Trần Duy Quân', '1990-01-01', '123456789', '0987654321', N'123 Đường ABC, Quận XYZ, Thành phố HCM');
INSERT INTO BenhNhan (Name, DateOfBirth, PersonalID, PhoneNumber, Address) VALUES (N'Phạm Thành Nhân', '1985-02-02', '987654321', '0123456781', N'456 Đường DEF, Quận UVW, Thành phố HCM');
INSERT INTO BenhNhan (Name, DateOfBirth, PersonalID, PhoneNumber, Address) VALUES (N'Đặng Quốc Hưng', '1995-03-03', '456789123', '0987654323', N'789 Đường GHI, Quận MNO, Thành phố HCM');
INSERT INTO BenhNhan (Name, DateOfBirth, PersonalID, PhoneNumber, Address) VALUES (N'Nguyễn Nguyên Khang', '1980-04-04', '789123456', '0123456782', N'101 Đường JKL, Quận PQR, Thành phố HCM');
INSERT INTO BenhNhan (Name, DateOfBirth, PersonalID, PhoneNumber, Address) VALUES (N'Nguyễn Mậu Thành Đạt', '1998-05-05', '321654987', '0987654326', N'202 Đường STU, Quận XYZ, Thành phố HCM');

-- BacSi
-- Thêm dòng dữ liệu thứ nhất
EXEC PROC_CREATE_BS 
    @Name = N'Nguyễn Văn A',
    @DateOfBirth = '1975-01-01',
    @PersonalID = 'BS001',
    @PhoneNumber = '0987654321',
    @Address = N'Dia chi bac si 1',
    @Sex = 0,
    @Email = 'bacsi1@example.com',
    @Salary = 500000;

-- Thêm dòng dữ liệu thứ hai
EXEC PROC_CREATE_BS 
    @Name = N'Lê Văn B',
    @DateOfBirth = '1980-02-02',
    @PersonalID = 'BS002',
    @PhoneNumber = '0123456781',
    @Address = N'Dia chi bac si 2',
    @Sex = 0,
    @Email = 'bacsi2@example.com',
    @Salary = 600000;

-- Thêm dòng dữ liệu thứ ba
EXEC PROC_CREATE_BS 
    @Name = N'Lâm Văn C',
    @DateOfBirth = '1985-03-03',
    @PersonalID = 'BS003',
    @PhoneNumber = '0987654322',
    @Address = N'Dia chi bac si 3',
    @Sex = 0,
    @Email = 'bacsi3@example.com',
    @Salary = 700000;

-- Thêm dòng dữ liệu thứ tư
EXEC PROC_CREATE_BS 
    @Name = N'Nguyễn Thị Ngọc D',
    @DateOfBirth = '1990-04-04',
    @PersonalID = 'BS004',
    @PhoneNumber = '0123456783',
    @Address = N'Dia chi bac si 4',
    @Sex = 1,
    @Email = 'bacsi4@example.com',
    @Salary = 800000;

-- Thêm dòng dữ liệu thứ năm
EXEC PROC_CREATE_BS 
    @Name = N'Phan Thị E',
    @DateOfBirth = '1995-05-05',
    @PersonalID = 'BS005',
    @PhoneNumber = '0987654324',
    @Address = N'Dia chi bac si 5',
    @Sex = 1,
    @Email = 'bacsi5@example.com',
    @Salary = 900000;


-- BoPhan
INSERT INTO BoPhan (Name, PhongBanID) VALUES (N'Bộ phận quản lý', 3);
INSERT INTO BoPhan (Name, PhongBanID) VALUES (N'Bộ phận tiếp tân', 4);
INSERT INTO BoPhan (Name, PhongBanID) VALUES (N'Bộ phận kế toán', 1);
INSERT INTO BoPhan (Name, PhongBanID) VALUES (N'Quản lý tài nguyên', null);
INSERT INTO BoPhan (Name, PhongBanID) VALUES (N'Quản lý tài vụ', null);
INSERT INTO BoPhan (Name, PhongBanID) VALUES (N'Quản lý chuyên môn', null);


-- NhanVien
EXEC PROC_CREATE_NV 
    @Name = N'Ten Nhan Vien 1',
    @DateOfBirth = '1990-01-01',
    @Sex = 1,
    @PersonalId = 'NV001',
    @Email = 'nhanvien1@example.com',
    @PhoneNumber = '0987654321',
    @Salary = 100000,
    @Role = N'Nhan Vien A',
    @Address = N'Dia chi nhan vien 1',
    @PhongBanID = 1,
    @BoPhanID = 3;

-- Thêm dòng dữ liệu thứ hai
EXEC PROC_CREATE_NV 
    @Name = N'Ten Nhan Vien 2',
    @DateOfBirth = '1995-02-02',
    @Sex = 0,
    @PersonalId = 'NV002',
    @Email = 'nhanvien2@example.com',
    @PhoneNumber = '0123456782',
    @Salary = 110000,
    @Role = N'Nhan Vien B',
    @Address = N'Dia chi nhan vien 2',
    @PhongBanID = 1,
    @BoPhanID = NULL;

-- Thêm dòng dữ liệu thứ ba
EXEC PROC_CREATE_NV 
    @Name = N'Ten Nhan Vien 3',
    @DateOfBirth = '1985-03-03',
    @Sex = 1,
    @PersonalId = 'NV003',
    @Email = 'nhanvien3@example.com',
    @PhoneNumber = '0987654323',
    @Salary = 120000,
    @Role = N'Nhan Vien C',
    @Address = N'Dia chi nhan vien 3',
    @PhongBanID = 2,
    @BoPhanID = NULL;

-- Thêm dòng dữ liệu thứ tư
EXEC PROC_CREATE_NV 
    @Name = N'Ten Nhan Vien 4',
    @DateOfBirth = '1992-04-04',
    @Sex = 0,
    @PersonalId = 'NV004',
    @Email = 'nhanvien4@example.com',
    @PhoneNumber = '0123456784',
    @Salary = 130000,
    @Role = N'Nhan Vien D',
    @Address = N'Dia chi nhan vien 4',
    @PhongBanID = 3,
    @BoPhanID = 4;

-- Thêm dòng dữ liệu thứ năm
EXEC PROC_CREATE_NV 
    @Name = N'Ten Nhan Vien 5',
    @DateOfBirth = '1997-05-05',
    @Sex = 1,
    @PersonalId = 'NV005',
    @Email = 'nhanvien5@example.com',
    @PhoneNumber = '0987654325',
    @Salary = 140000,
    @Role = N'Nhan Vien E',
    @Address = N'Dia chi nhan vien 5',
    @PhongBanID = 3,
    @BoPhanID = 5;
EXEC PROC_CREATE_NV 
    @Name = N'Ten Nhan Vien 6',
    @DateOfBirth = '1995-10-12',
    @Sex = 1,
    @PersonalId = 'NV006',
    @Email = 'nhanvien6@example.com',
    @PhoneNumber = '0987654326',
    @Salary = 1500000,
    @Role = N'Nhan Vien E',
    @Address = N'Dia chi nhan vien 6',
    @PhongBanID = 3,
    @BoPhanID = 6;
EXEC PROC_CREATE_NV 
    @Name = N'Ten Nhan Vien 7',
    @DateOfBirth = '1998-11-13',
    @Sex = 1,
    @PersonalId = 'NV007',
    @Email = 'nhanvien7@example.com',
    @PhoneNumber = '0987654327',
    @Salary = 2000000,
    @Role = N'Nhan Vien E',
    @Address = N'Dia chi nhan vien 7',
    @PhongBanID = 4,
    @BoPhanID = 2;

-- CaTrucPhong
INSERT INTO CaTrucPhong (StartTime, EndTime, BacSiID, PhongKhamID) VALUES ('2024-05-01 08:00:00', '2024-05-01 17:00:00', 1, 1);
INSERT INTO CaTrucPhong (StartTime, EndTime, BacSiID, PhongKhamID) VALUES ('2024-05-01 08:00:00', '2024-05-01 17:00:00', 2, 2);
INSERT INTO CaTrucPhong (StartTime, EndTime, BacSiID, PhongKhamID) VALUES ('2024-05-01 08:00:00', '2024-05-01 17:00:00', 3, 3);
INSERT INTO CaTrucPhong (StartTime, EndTime, BacSiID, PhongKhamID) VALUES ('2024-05-01 08:00:00', '2024-05-01 17:00:00', 4, 4);
INSERT INTO CaTrucPhong (StartTime, EndTime, BacSiID, PhongKhamID) VALUES ('2024-05-01 08:00:00', '2024-05-01 17:00:00', 5, 5);

-- ToaThuoc
INSERT INTO ToaThuoc (PayDate, BenhNhanID, NhanVienID) VALUES ('2024-05-01', 1, 1);
INSERT INTO ToaThuoc (PayDate, BenhNhanID, NhanVienID) VALUES ('2024-05-01', 2, 2);
INSERT INTO ToaThuoc (PayDate, BenhNhanID, NhanVienID) VALUES ('2024-05-01', 3, 3);
INSERT INTO ToaThuoc (PayDate, BenhNhanID, NhanVienID) VALUES ('2024-05-01', 4, 4);
INSERT INTO ToaThuoc (PayDate, BenhNhanID, NhanVienID) VALUES ('2024-05-01', 5, 5);

-- ChiTietKhamBenh
INSERT INTO ChiTietKhamBenh (BacSiID, BenhNhanID, ToaThuocID, Description, NgayKham, TotalPrice) VALUES (1, 1, 1, N'Mô tả cho bệnh nhân 1', '2024-05-01', 100000);
INSERT INTO ChiTietKhamBenh (BacSiID, BenhNhanID, ToaThuocID, Description, NgayKham, TotalPrice) VALUES (2, 2, 2, N'Mô tả cho bệnh nhân 2', '2024-05-01', 150000);
INSERT INTO ChiTietKhamBenh (BacSiID, BenhNhanID, ToaThuocID, Description, NgayKham, TotalPrice) VALUES (3, 3, 3, N'Mô tả cho bệnh nhân 3', '2024-05-01', 200000);
INSERT INTO ChiTietKhamBenh (BacSiID, BenhNhanID, ToaThuocID, Description, NgayKham, TotalPrice) VALUES (4, 4, 4, N'Mô tả cho bệnh nhân 4', '2024-05-01', 250000);
INSERT INTO ChiTietKhamBenh (BacSiID, BenhNhanID, ToaThuocID, Description, NgayKham, TotalPrice) VALUES (5, 5, 5, N'Mô tả cho bệnh nhân 5', '2024-05-01', 300000);

-- ChiTietToaThuoc
INSERT INTO ChiTietToaThuoc (Amount, Description, ThuocID, ToaThuocID) VALUES (2, N'Mô tả cho thuốc 1', 1, 1);
INSERT INTO ChiTietToaThuoc (Amount, Description, ThuocID, ToaThuocID) VALUES (3, N'Mô tả cho thuốc 2', 2, 2);
INSERT INTO ChiTietToaThuoc (Amount, Description, ThuocID, ToaThuocID) VALUES (1, N'Mô tả cho thuốc 3', 3, 3);
INSERT INTO ChiTietToaThuoc (Amount, Description, ThuocID, ToaThuocID) VALUES (4, N'Mô tả cho thuốc 4', 4, 4);
INSERT INTO ChiTietToaThuoc (Amount, Description, ThuocID, ToaThuocID) VALUES (5, N'Mô tả cho thuốc 5', 5, 5);

-- ChiTietKhamBenh_DV
INSERT INTO ChiTietKhamBenh_DV (ChiTietID, DichVuID) VALUES (1, 1);
INSERT INTO ChiTietKhamBenh_DV (ChiTietID, DichVuID) VALUES (2, 2);
INSERT INTO ChiTietKhamBenh_DV (ChiTietID, DichVuID) VALUES (3, 3);
INSERT INTO ChiTietKhamBenh_DV (ChiTietID, DichVuID) VALUES (4, 4);
INSERT INTO ChiTietKhamBenh_DV (ChiTietID, DichVuID) VALUES (5, 5);
