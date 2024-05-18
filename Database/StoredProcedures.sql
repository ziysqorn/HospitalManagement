create certificate AESCert
encryption by password = 'Sigm@44444'
with subject = 'Certificate for AES Algor'
create symmetric key SymKey 
with algorithm = AES_256
encryption by certificate AESCert
go

create proc PROC_CREATE_NV(
    @Name NVARCHAR(100),
    @DateOfBirth DATE,
    @Sex BIT,
    @PersonalId VARCHAR(20),
    @Email VARCHAR(100),
    @PhoneNumber VARCHAR(20),
    @Salary INT,
    @Role NVARCHAR(50),
    @Address NVARCHAR(200),
    @PhongBanID INT,
    @BoPhanID INT
)
AS
BEGIN
    Open Symmetric Key SymKey Decryption By Certificate AESCert with password = 'Sigm@44444'
    INSERT INTO NhanVien (Name, DateOfBirth, Sex, PersonalId, Email, PhoneNumber, Salary, Role, Address, PhongBanID, BoPhanID)
    VALUES (@Name, @DateOfBirth, @Sex, @PersonalId, @Email, @PhoneNumber, ENCRYPTBYKEY(KEY_GUID('SymKey'), CONVERT(varbinary(max), @Salary)), @Role, @Address, @PhongBanID, @BoPhanID);
	Close Symmetric Key SymKey
END

EXEC PROC_CREATE_NV 
    @Name = 'Nguyen Van A',
    @DateOfBirth = '1990-01-01',
    @Sex = 0,
    @PersonalId = '123456789',
    @Email = 'nguyenvana@example.com',
    @PhoneNumber = '0123456789',
    @Salary = 1000,
    @Role = 'Employee',
    @Address = '123 Example Street, City, Country',
    @PhongBanID = null,
    @BoPhanID = null;
------------------------------------------------------
create proc PROC_READ_NV
@NhanVienID int = null
AS
BEGIN
    Open Symmetric Key SymKey Decryption By Certificate AESCert with password = 'Sigm@44444'
    if(@NhanVienID IS NOT NULL)
	begin
     SELECT NhanVien.ID, NhanVien.Name as 'Name', DateOfBirth, Sex, PersonalId, Email, PhoneNumber, CONVERT(int, DECRYPTBYKEY(Salary)) as 'Salary', Role, Address, PhongBan.Name as 'PhongBan', BoPhan.Name as 'BoPhan'
     FROM NhanVien
	 join PhongBan on PhongBan.ID = NhanVien.PhongBanID
	 join BoPhan on BoPhan.ID = NhanVien.BoPhanID
	 where NhanVien.ID = @NhanVienID;
	end
	else
	begin
     SELECT NhanVien.ID, NhanVien.Name as 'Name', DateOfBirth, Sex, PersonalId, Email, PhoneNumber, CONVERT(int, DECRYPTBYKEY(Salary)) as 'Salary', Role, Address, PhongBan.Name as 'PhongBan', BoPhan.Name as 'BoPhan'
	 FROM NhanVien
	 join PhongBan on PhongBan.ID = NhanVien.PhongBanID
	 join BoPhan on BoPhan.ID = NhanVien.BoPhanID
	end
	Close Symmetric Key SymKey
END


exec PROC_READ_NV
------------------------------------------------------
create proc PROC_UPDATE_NV
    @NhanVienID INT,
    @Name NVARCHAR(100),
    @DateOfBirth DATE,
    @Sex BIT,
    @PersonalId VARCHAR(20),
    @Email VARCHAR(100),
    @PhoneNumber VARCHAR(20),
    @Salary INT,
    @Role NVARCHAR(50),
    @Address NVARCHAR(200),
    @PhongBanID INT,
    @BoPhanID INT
AS
BEGIN
    Open Symmetric Key SymKey Decryption By Certificate AESCert with password = 'Sigm@44444'
    UPDATE NhanVien
    SET Name = @Name,
        DateOfBirth = @DateOfBirth,
        Sex = @Sex,
        PersonalId = @PersonalId,
        Email = @Email,
        PhoneNumber = @PhoneNumber,
        Salary = ENCRYPTBYKEY(KEY_GUID('SymKey'), CONVERT(varbinary(max), @Salary)),
        Role = @Role,
        Address = @Address,
        PhongBanID = @PhongBanID,
        BoPhanID = @BoPhanID
    WHERE ID = @NhanVienID;
	Close Symmetric Key SymKey 
END

EXEC PROC_UPDATE_NV
    @NhanVienID = 2,
    @Name = 'Nguyen Van B',
    @DateOfBirth = '1995-02-02',
    @Sex = 0,
    @PersonalId = '987654321',
    @Email = 'nguyenvanb@example.com',
    @PhoneNumber = '0987654321',
    @Salary = 1500,
    @Role = 'Manager',
    @Address = '456 Example Street, City, Country',
    @PhongBanID = null,
    @BoPhanID = null;
---------------------------------
create proc PROC_CREATE_BS
    @Name NVARCHAR(100),
    @DateOfBirth DATE,
    @PersonalID VARCHAR(20),
    @PhoneNumber VARCHAR(20),
    @Address NVARCHAR(200),
    @Sex BIT,
    @Email VARCHAR(100),
    @Salary INT
AS
BEGIN
    Open Symmetric Key SymKey Decryption By Certificate AESCert with password = 'Sigm@44444'
    INSERT INTO BacSi (Name, DateOfBirth, PersonalID, PhoneNumber, Address, Sex, Email, Salary)
    VALUES (@Name, @DateOfBirth, @PersonalID, @PhoneNumber, @Address, @Sex, @Email, ENCRYPTBYKEY(KEY_GUID('SymKey'), CONVERT(varbinary(max), @Salary)))
	Close Symmetric Key SymKey
END

EXEC PROC_CREATE_BS
    @Name = 'Nguyen Van C',
    @DateOfBirth = '1980-03-03',
    @PersonalID = '9876543210',
    @PhoneNumber = '0987654321',
    @Address = '789 Example Street, City, Country',
    @Sex = 1,
    @Email = 'nguyenvanc@example.com',
    @Salary = 2000;
---------------------------------
CREATE PROCEDURE PROC_READ_BS
@BacSiID int = null
AS
BEGIN
    Open Symmetric Key SymKey Decryption By Certificate AESCert with password = 'Sigm@44444'
    if(@BacSiID IS NOT NULL)
	begin
     SELECT ID, Name, DateOfBirth, PersonalID, PhoneNumber, Address, Sex, Email, CONVERT(int, DECRYPTBYKEY(Salary)) as 'Salary'
     FROM BacSi where ID = @BacSiID;
	end
	else
	begin
     SELECT ID, Name, DateOfBirth, PersonalID, PhoneNumber, Address, Sex, Email, CONVERT(int, DECRYPTBYKEY(Salary)) as 'Salary'
     FROM BacSi
	end
	Close Symmetric Key SymKey
END

exec PROC_READ_BS 
---------------------------------
create proc PROC_UPDATE_BS
    @BacSiID INT,
    @Name NVARCHAR(100),
    @DateOfBirth DATE,
    @PersonalID VARCHAR(20),
    @PhoneNumber VARCHAR(20),
    @Address NVARCHAR(200),
    @Sex BIT,
    @Email VARCHAR(100),
    @Salary INT
AS
BEGIN
    Open Symmetric Key SymKey Decryption By Certificate AESCert with password = 'Sigm@44444'
    UPDATE BacSi
    SET Name = @Name,
        DateOfBirth = @DateOfBirth,
        PersonalID = @PersonalID,
        PhoneNumber = @PhoneNumber,
        Address = @Address,
        Sex = @Sex,
        Email = @Email,
        Salary = ENCRYPTBYKEY(KEY_GUID('SymKey'), CONVERT(varbinary(max), @Salary))
    WHERE ID = @BacSiID;
	Close Symmetric Key SymKey
END

EXEC PROC_UPDATE_BS
    @BacSiID = 1,
    @Name = 'Nguyen Van D',
    @DateOfBirth = '1975-04-04',
    @PersonalID = '0123456789',
    @PhoneNumber = '0123456789',
    @Address = '123 Example Street, City, Country',
    @Sex = 0,
    @Email = 'nguyenvand@example.com',
    @Salary = 2500;