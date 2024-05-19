use HospitalManagement
go

--create login QLTaiNguyen with password = 'SigmaTN', check_expiration = off, check_policy = off
--create login QLTaiVu with password = 'SigmaQLTV', check_expiration = off, check_policy = off
--create login QLChuyenMon with password = 'SigmaCM', check_expiration = off, check_policy = off
--create login BoPhanTiepTan with password = 'SigmaTT', check_expiration = off, check_policy = off
--create login NVTaiVu with password = 'SigmaNVTV', check_expiration = off, check_policy = off
--create login BacSi with password = 'SigmaBS', check_expiration = off, check_policy = off
--create login NVBanThuoc with password = 'SigmaNVBT', check_expiration = off, check_policy = off
--create login NVKeToan with password = 'SigmaNVKT', check_expiration = off, check_policy = off

-- Tạo các role cho hệ thống
create role QLTaiNguyen
go
create role QLTaiVu
go
create role QLChuyenMon
go
create role BoPhanTiepTan 
go
create role NVTaiVu
go
create role BacSi
go
create role NVBanThuoc
go
create role NVKeToan
go

-- Gán quyền cho các role
-- Role QLTaiNguyen
grant select, update, insert, delete on PhongBan to QLTaiNguyen
grant select on BoPhan to QLTaiNguyen
grant select, update, insert, delete on BacSi to QLTaiNguyen
grant select, update, insert, delete on NhanVien to QLTaiNguyen
grant select, update, insert, delete on CaTrucPhong to QLTaiNguyen
deny update (Salary) on BacSi to QLTaiNguyen
deny update (Salary) on NhanVien to QLTaiNguyen
GRANT EXECUTE ON OBJECT::dbo.PROC_CREATE_NV TO QLTaiNguyen;
GRANT EXECUTE ON OBJECT::dbo.PROC_CREATE_BS TO QLTaiNguyen;
GRANT CONTROL ON CERTIFICATE::AESCert TO QLTaiNguyen;
GRANT CONTROL ON SYMMETRIC KEY::SymKey TO QLTaiNguyen;
-- Role QLTaiVu
grant insert, select on Thuoc to QLTaiVu
grant update on Thuoc (Price) to QLTaiVu
grant insert, select on DVKhamBenh to QLTaiVu
grant update on DVKhamBenh (Price) to QLTaiVu
-- Role QLChuyenMon
grant select on ChiTietKhamBenh to QLChuyenMon
grant select on ToaThuoc to QLChuyenMon
grant select on ChiTietToaThuoc to QLChuyenMon
grant select on Thuoc to QLChuyenMon
grant select on DVKhamBenh to QLChuyenMon
grant select on ChiTietKhamBenh_DV to QLChuyenMon
grant select on BenhNhan to QLChuyenMon
grant select on BacSi (ID, Name) to QLChuyenMon
-- Role BoPhanTiepTan
grant select, update, insert, delete on BenhNhan to BoPhanTiepTan
grant select on ChiTietKhamBenh to BoPhanTiepTan
deny select on ChiTietKhamBenh(ToaThuocID) to BoPhanTiepTan
deny select on DVKhamBenh(Price) to BoPhanTiepTan
-- Role NVTaiVu
grant select on ChiTietKhamBenh_DV to NVTaiVu
grant update on ChiTietKhamBenh (TotalPrice) to NVTaiVu
grant select on ChiTietKhamBenh to NVTaiVu
grant select on DVKhamBenh to NVTaiVu
grant select on BacSi(ID, Name) to NVTaiVu
grant select on BenhNhan(ID, Name) to NVTaiVu
-- Role BacSi
grant select on ToaThuoc to BacSi
grant select on ChiTietToaThuoc to BacSi
grant select on Thuoc to BacSi
grant select on DVKhamBenh to BacSi
grant select on ChiTietKhamBenh_DV to BacSi
grant select on BenhNhan to BacSi
grant select on BacSi (ID, Name) to BacSi
grant select, insert, update on ChiTietKhamBenh to BacSi
grant select, insert, update, delete on ChiTietKhamBenh_DV to BacSi
grant select, insert, update, delete on ChiTietToaThuoc to BacSi
-- Role NVBanThuoc
grant select on BenhNhan (ID, Name, PersonalID) to NVBanThuoc
grant select on Thuoc to NVBanThuoc
grant select on ChiTietToaThuoc to NVBanThuoc
grant select on BacSi to NVBanThuoc
grant select on NhanVien to NVBanThuoc
grant select on ToaThuoc to NVBanThuoc 
grant update on ToaThuoc (PayDate, NhanVienID, TotalPrice) to NVBanThuoc 
grant select on ChiTietKhamBenh to NVBanThuoc 
deny select on ChiTietKhamBenh (Description) to NVBanThuoc 
-- Role NVKeToan
grant select on BacSi (ID, Name, PhoneNumber, Salary) to NVKeToan
grant update on BacSi (Salary) to NVKeToan
grant select on NhanVien (ID, Name, PhoneNumber, Salary) to NVKeToan
grant update on NhanVien (Salary) to NVKeToan
grant select on BoPhan to NVKeToan
grant select on PhongBan to NVKeToan
GRANT EXECUTE ON OBJECT::dbo.PROC_READ_NV TO NVKeToan;
GRANT EXECUTE ON OBJECT::dbo.PROC_UPDATE_NV TO NVKeToan;
GRANT EXECUTE ON OBJECT::dbo.PROC_READ_BS TO NVKeToan;
GRANT EXECUTE ON OBJECT::dbo.PROC_UPDATE_BS TO NVKeToan;
GRANT CONTROL ON CERTIFICATE::AESCert TO NVKeToan;
GRANT CONTROL ON SYMMETRIC KEY::SymKey TO NVKeToan;