 
USE master;
GO

CREATE DATABASE KoifishDB;
GO

USE KoifishDB;
GO

 
CREATE TABLE FishInformation (
    FishID INT PRIMARY KEY,                     
    Species VARCHAR(50),                      
    Age INT,                                   
    Size_cm FLOAT,                             
    DateAcquired DATE                          
);

 
CREATE TABLE HealthRecords (
    RecordID INT PRIMARY KEY,                  
    FishID INT,                                 
    CheckupDate DATE,                           
    HealthStatus VARCHAR(100),                  
    Treatment VARCHAR(200),                     
    Notes TEXT,                                 
    FOREIGN KEY (FishID) REFERENCES FishInformation(FishID)  
);

 
CREATE TABLE UserAccounts (
    UserID INT PRIMARY KEY,                     
    Username VARCHAR(50) NOT NULL UNIQUE,       
    Password NVARCHAR(60) NOT NULL,             
    Email VARCHAR(100) NOT NULL UNIQUE          
);

 
INSERT INTO UserAccounts (UserID, Username, Password, Email) 
VALUES 
(1, 'adminUser', '123@', 'admin@example.com'), 
(2, 'johnDoe', '234@', 'john.doe@example.com');

 
INSERT INTO FishInformation (FishID, Species, Age, Size_cm, DateAcquired)
VALUES 
(1, 'Kohaku', 2, 35.5, '2023-03-12'),  
(2, 'Shiro Utsuri', 3, 40.0, '2022-06-20'), 
(3, 'Midori Goi', 1, 25.0, '2023-09-05');

 
INSERT INTO HealthRecords (RecordID, FishID, CheckupDate, HealthStatus, Treatment, Notes) 
VALUES 
(1, 1, '2024-01-10', 'Healthy', 'None', 'Growing well. No signs of disease.'),
(2, 2, '2023-12-15', 'Minor Fin Rot', 'Treated with salt bath', 'Responding well to treatment.'),
(3, 3, '2024-01-05', 'Healthy', 'None', 'No health issues observed.');
