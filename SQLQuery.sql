CREATE DATABASE P201University

USE P201University

CREATE TABLE Kafedralar
(Id INT,Name NVARCHAR(100),CreatedAt DATETIME2)

CREATE TABLE Ixtisaslar
(Id INT,Name NVARCHAR(100), StudentLimit TINYINT)

DROP TABLE Kafedralar
DROP TABLE Ixtisaslar

CREATE TABLE Kafedralar
(Id INT  IDENTITY PRIMARY KEY,
 Name NVARCHAR(100) NOT NULL,
 CreatedAt DATETIME2
 )

 CREATE TABLE Ixtisaslar
 (
 Id INT IDENTITY PRIMARY KEY,
 Name NVARCHAR(100),
 StudentLimit INT,
 KafedraId INT FOREIGN KEY(KafedraId) REFERENCES Kafedralar(Id)
 )

 SELECT Id,Name,KafedraId FROM Ixtisaslar
 SELECT * FROM Ixtisaslar