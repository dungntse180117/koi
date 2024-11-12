 
CREATE DATABASE KoifishDB;
GO

-- Sử dụng cơ sở dữ liệu
USE KoifishDB;
GO

-- Tạo bảng FishInformation
CREATE TABLE FishInformation (
    FishID INT PRIMARY KEY,                      -- Khóa chính
    Species VARCHAR(50),                         -- Loài cá
    Age INT,                                     -- Tuổi
    Size_cm FLOAT,                               -- Kích thước (cm)
    DateAcquired DATE                            -- Ngày thêm vào hệ thống
);

-- Tạo bảng HealthRecords
CREATE TABLE HealthRecords (
    RecordID INT PRIMARY KEY,                    -- Khóa chính
    FishID INT,                                  -- Khóa ngoại đến FishInformation
    CheckupDate DATE,                            -- Ngày kiểm tra
    HealthStatus VARCHAR(100),                   -- Tình trạng sức khỏe
    Treatment VARCHAR(200),                      -- Điều trị
    Notes TEXT,                                  -- Ghi chú
    FOREIGN KEY (FishID) REFERENCES FishInformation(FishID)  -- Khóa ngoại
);

-- Tạo bảng UserAccounts
CREATE TABLE UserAccounts (
    UserID INT PRIMARY KEY,                      -- Khóa chính
    Username VARCHAR(50) NOT NULL UNIQUE,        -- Tên người dùng, duy nhất
    Password NVARCHAR(60) NOT NULL,              -- Mật khẩu
    Email VARCHAR(100) NOT NULL UNIQUE,          -- Email, duy nhất
    Role INT NOT NULL DEFAULT 0                  -- Quyền (0: mặc định, 1: Admin, 2: User)
);

-- Thêm dữ liệu mẫu vào bảng UserAccounts
INSERT INTO UserAccounts (UserID, Username, Password, Email, Role) 
VALUES 
(1, 'adminUser', '123@', 'admin@example.com', 1),  -- Admin
(2, 'johnDoe', '234@', 'john.doe@example.com', 2); -- User thông thường

-- Thêm dữ liệu mẫu vào bảng FishInformation
INSERT INTO FishInformation (FishID, Species, Age, Size_cm, DateAcquired)
VALUES 
(1, 'Kohaku', 2, 35.5, '2023-03-12'),  
(2, 'Shiro Utsuri', 3, 40.0, '2022-06-20'), 
(3, 'Midori Goi', 1, 25.0, '2023-09-05');

-- Thêm dữ liệu mẫu vào bảng HealthRecords
INSERT INTO HealthRecords (RecordID, FishID, CheckupDate, HealthStatus, Treatment, Notes) 
VALUES 
(1, 1, '2024-01-10', 'Healthy', 'None', 'Growing well. No signs of disease.'),
(2, 2, '2023-12-15', 'Minor Fin Rot', 'Treated with salt bath', 'Responding well to treatment.'),
(3, 3, '2024-01-05', 'Healthy', 'None', 'No health issues observed.');

-- Kiểm tra dữ liệu trong bảng UserAccounts
SELECT * FROM UserAccounts;

-- Kiểm tra dữ liệu trong bảng FishInformation
SELECT * FROM FishInformation;

-- Kiểm tra dữ liệu trong bảng HealthRecords
SELECT * FROM HealthRecords;