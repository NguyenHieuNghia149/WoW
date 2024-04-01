--Them fullname & exp vao post
--Bo IDJF o Worker

--DROP TABLE Saves
--DROP TABLE Orders
--DROP TABLE Post
--DROP TABLE Job
--DROP TABLE JobField
--DROP TABLE Worker
--DROP TABLE Customer
--DROP TRIGGER tg_Insert_Post
--GO


SELECT * FROM Customer

--1--Sua phong chu customer
--DROP TABLE Orders
--DROP TABLE Saves
--DROP TABLE Requirement
--DROP TABLE Customer

Create table dbo.Customer(	
	OrderNum INT IDENTITY (1,1),
	CID Nchar(20),
	CEmail char(50),
	CPassword Nchar(50),
	Fullname Nchar(100),
	Gender Nchar(10),
	CBirthday Datetime,
	City NCHAR(20),
	District NCHAR(20),
	PhoneNum NCHAR(20) UNIQUE,
	CAddress Nchar(500),
	primary key (CEmail)
)

go 
create table dbo.JobField
(
	OrderNum INT IDENTITY (1,1),
	IDJF Nchar(20) primary key,
	FieldName NChar(100),
)

go
create table dbo.Job(
	OrderNum int identity(1,1),
	IDJ Nchar(20) PRIMARY KEY,
	IDJF Nchar(20),
	JobName Nchar(100),
	foreign key (IDJF)  references JobField(IDJF)
)

go
create table dbo.Worker(
	OderNum INT IDENTITY (1,1),
	WID Nchar(20) PRIMARY KEY,
	WEmail char(50),
	WPassword char(50),
	Fullname Nvarchar(150),
	Gender Nchar(10),
	Birthday DateTime,
	City Nchar(100),
	District Nchar(100),
	PhoneNum Nchar(20),
	WAddress text,
)

go
create table dbo.Post(
	OrderNum INT IDENTITY (1,1),
	IDP Nchar(20) primary key,
	WID Nchar(20),
	Fullname Nchar(100),
	Email Nchar(20),
	IDJ NChar(20),
	JobName NChar(100),
	WTime NChar(20), 
	Cost NChar(20),
	PhoneNum Nchar(20),
	Detail text,
	City Nchar(100),
	District Nchar(100),
	Experience Nchar(20),
	foreign key (WID) references Worker(WID),
	foreign key (IDJ) references Job(IDJ)
)

go
create table dbo.Orders(
	OrderNum INT IDENTITY (1,1),
	CEmail char(50),
	IDP Nchar(20),
	Timestart datetime,
	TimeEnd datetime,
	primary key (CEmail,IDP),
	foreign key (CEmail) references Customer(CEmail),
	foreign key (IDP) references Post(IDP)
)

go
create table dbo.Saves(
 	OrderNum INT IDENTITY (1,1),
	CID Nchar(20),
	IDP NChar(20),
	CEmail char(50),
	primary key (IDP,CEmail),
	foreign key (CEmail) references Customer(CEmail),
	foreign key (IDP) references Post(IDP)
)
GO
----Nhap vao Customer
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress)
VALUES (N'C00001',N'Nam@gmail.com',N'Nam@gmail.com',N'Võ Hoài Nam',N'Male','1981-07-01',N'Hà Nội',N'Ba Đình',N'01928192839',N'Hà Nội, Ba Đình')
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress)
VALUES (N'C00002',N'Phuong@gmail.com',N'Phuong@gmail.com',N'Nguyễn Hoàng Phương',N'Female','1979-10-12',N'Hồ Chí Minh',N'Quận 9',N'08992102938',N'Hồ Chí Minh, Quận 9')
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress)
VALUES (N'C00003',N'Ha@gmail.com',N'Ha@gmail.com',N'Lê Thị Hà',N'Female','1999-01-09',N'Quảng Bình',N'Ba Đồn',N'09816238428',N'Quảng Bình, Ba Đồn')
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress)
VALUES (N'C00004',N'Hoi@gmail.com',N'Hoi@gmail.com',N'Đinh Thị Hợi',N'Female','1981-11-09',N'Bến Tre',N'Mỏ Cày',N'09212837119',N'Bến Tre, Mỏ Cày')
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress)
VALUES (N'C00005',N'Ngan@gmail.com',N'Ngan@gmail.com',N'Võ Văn Ngân',N'Female','1981-02-28',N'Hà Tĩnh',N'Thạch Hà',N'0873628332',N'Hà Tĩnh, Thạch Hà')
GO

----Nhap vao JobField
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00001',N'Housing')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00002',N'Vehicle')
GO

----Nhap vao Job
INSERT INTO Job(IDJ,IDJF,JobName) VALUES (N'J00001',N'JF00001',N'Painting Walls')
INSERT INTO Job(IDJ,IDJF,JobName) VALUES (N'J00002',N'JF00001',N'Fixing Furnitures')
INSERT INTO Job(IDJ,IDJF,JobName) VALUES (N'J00003',N'JF00002',N'Resembling Cars')
INSERT INTO Job(IDJ,IDJF,JobName) VALUES (N'J00004',N'JF00002',N'Fixing Cars')
INSERT INTO Job(IDJ,IDJF,JobName) VALUES (N'J00005',N'JF00002',N'Washing Cars')
GO

SELECT * FROM Worker

----Nhap vao Worker
INSERT INTO Worker(WID,WPassword,FullName,WEmail,Gender,Birthday,City,District,PhoneNum,WAddress)
VALUES (N'W00001',N'Anh@gmail.com',N'Nguyễn Nhật Ánh',N'Anh@gmail.com',N'Male','1981-07-01',N'Hà Nội',N'Ba Đình',N'01928192839',NULL)
INSERT INTO Worker(WID,WPassword,FullName,WEmail,Gender,Birthday,City,District,PhoneNum,WAddress)
VALUES (N'W00002',N'Nhu@gmail.com',N'Trần Ngọc Như',N'Nhu@gmail.com',N'Female','1979-10-12',N'Hồ Chí Minh',N'Quận 9',N'08992102938',NULL)
INSERT INTO Worker(WID,WPassword,FullName,WEmail,Gender,Birthday,City,District,PhoneNum,WAddress)
VALUES (N'W00003',N'Hung@gmail.com',N'Lê Việt Hùng',N'Hung@gmail.com',N'Male','1999-01-09',N'Quảng Bình',N'Ba Đồn',N'09816238428',NULL)
INSERT INTO Worker(WID,WPassword,FullName,WEmail,Gender,Birthday,City,District,PhoneNum,WAddress)
VALUES (N'W00004',N'Hoa@gmail.com',N'Hoàng Quỳnh Hoa',N'Hoa@gmail.com',N'Female','1981-11-09',N'Bến Tre',N'Mỏ Cày',N'09212837119',NULL)
INSERT INTO Worker(WID,WPassword,FullName,WEmail,Gender,Birthday,City,District,PhoneNum,WAddress)
VALUES (N'W00005',N'Viet@gmail.com',N'Lê Văn Việt',N'Viet@gmail.com',N'Male','1981-02-28',N'Hà Tĩnh',N'Thạch Hà',N'0873628332',NULL)
GO

------------------------POST-------------------------
DROP TABLE Post

create table dbo.Post(
	OrderNum INT IDENTITY (1,1),
	IDP Nchar(20) primary key,
	WID Nchar(20),
	Fullname Nchar(100),
	Email Nchar(20),
	IDJ NChar(20),
	JobName NChar(100),
	WTime NChar(20), 
	Cost NChar(20),
	PhoneNum Nchar(20),
	Detail text,
	City Nchar(100),
	District Nchar(100),
	Experience Nchar(20),
	foreign key (WID) references Worker(WID),
	foreign key (IDJ) references Job(IDJ)
)

Go
----Trigger nhap vao Post (Nhap nhung thong tin con lai)

--DROP TRIGGER tg_Insert_Post
CREATE TRIGGER tg_Insert_Post ON Post 
FOR INSERT, UPDATE AS
BEGIN
	DECLARE @PhoneNum NCHAR(20), @City NCHAR(20), @District NCHAR(20), @Email CHAR(20),
		@IDJ NCHAR(20), @JobName NCHAR(20), @WID NCHAR(20), @Fullname NCHAR(100), @IDP NCHAR(20)

	SELECT @JobName = new.JobName, @IDP = new.IDP, @Email = Email FROM INSERTED new

	SELECT @PhoneNum = PhoneNum FROM Worker WHERE WEmail = @Email
	SELECT @Email = WEmail FROM Worker WHERE WEmail = @Email
	SELECT @Fullname = Fullname FROM Worker WHERE WEmail = @Email
	SELECT @City = City FROM Worker WHERE WEmail = @Email
	SELECT @District = District FROM Worker WHERE WEmail = @Email
	SELECT @IDJ = IDJ FROM Job WHERE JobName = @JobName

	UPDATE Post SET PhoneNum = @PhoneNum, City = @City, District =  @District, 
		IDJ = @IDJ, Fullname = @Fullname, @WID = WID WHERE IDP = @IDP
END
GO

----Procedure nhap vao Post co WID
CREATE PROCEDURE pd_Insert_Post_(@IDP NCHAR(20),@Email CHAR(20),@JobName NCHAR(20),
	@WTime NCHAR(20),@Cost NCHAR(20),@Detail NCHAR(20),@Experience NCHAR(20)) AS
BEGIN
	DECLARE @WID NCHAR(20)
	SELECT @WID = WID FROM Worker WHERE WEmail = @Email
	
	INSERT INTO Post(IDP,Email,JobName,WTime,Cost,Detail,Experience, WID)
	VALUES(@IDP,@Email,@JobName,@WTime,@Cost,@Detail,@Experience,@WID)
END
GO

----Procedure update vao Post co WID
CREATE PROCEDURE pd_Update_Post_(@IDP NCHAR(20),@Email CHAR(20),@JobName NCHAR(20),
	@WTime NCHAR(20),@Cost NCHAR(20),@Detail NCHAR(20),@Experience NCHAR(20)) AS
BEGIN
	DECLARE @WID NCHAR(20)
	SELECT @WID = WID FROM Worker WHERE WEmail = @Email
	
	UPDATE Post SET Email = @Email,JobName = @JobName,WTime = @WTime,
		Cost = @Cost,Detail = @Detail,Experience = @Experience, WID = @WID WHERE IDP = @IDP
END
GO

----Procedure delete vao Post co WID
CREATE PROCEDURE pd_delete_Post_Order(@IDP NCHAR(20)) AS
BEGIN
	DELETE FROM Orders WHERE IDP = @IDP
	DELETE FROM Post WHERE IDP = @IDP
END

----Nhap vao Post (k co WID)
EXEC pd_Insert_Post_ N'P00001',N'Anh@gmail.com',N'Painting Walls',N'4-5',N'20',NULL,N'1-2'
EXEC pd_Insert_Post_ N'P00002',N'Nhu@gmail.com',N'Painting Walls',N'4-5',N'20',NULL,N'1-2'
EXEC pd_Insert_Post_ N'P00003',N'Hung@gmail.com',N'Resembling Cars',N'3-4',N'35',NULL,N'1-2'
EXEC pd_Insert_Post_ N'P00004',N'Hoa@gmail.com',N'Resembling Cars',N'3-4',N'35',NULL,N'1-2'
EXEC pd_Insert_Post_ N'P00005',N'Viet@gmail.com',N'Resembling Cars',N'3-4',N'35',NULL,N'1-2'
EXEC pd_Insert_Post_ N'P00006',N'Viet@gmail.com',N'Painting Walls',N'3-4',N'35',NULL,N'1-2'

DELETE FROM Post WHERE IDP = N'P00006'

------------------------------------------------------------------------------------------------

----Nhap vao Orders
INSERT INTO Orders(CEmail,IDP,Timestart,TimeEnd)
VALUES(N'Nam@gmail.com',N'P00001','2024-01-10','2024-01-12')
INSERT INTO Orders(CEmail,IDP,Timestart,TimeEnd)
VALUES(N'Phuong@gmail.com',N'P00001','2024-02-15','2024-02-17')
INSERT INTO Orders(CEmail,IDP,Timestart,TimeEnd)
VALUES(N'Ha@gmail.com',N'P00002','2024-02-20','2024-01-21')
INSERT INTO Orders(CEmail,IDP,Timestart,TimeEnd)
VALUES(N'Hoi@gmail.com',N'P00002','2024-03-13','2024-03-15')
INSERT INTO Orders(CEmail,IDP,Timestart,TimeEnd)
VALUES(N'Ngan@gmail.com',N'P00002','2024-03-20','2024-03-22')
GO

----Nhap vao Saves
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00001',N'P00003','Nam@gmail.com')
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00002',N'P00003',N'Phuong@gmail.com')
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00003',N'P00004',N'Ha@gmail.com')
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00004',N'P00005',N'Hoi@gmail.com')
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00005',N'P00005',N'Ngan@gmail.com')
GO

----------Data cho FRequirement_Jobs----------
--DROP TABLE Requirement
CREATE TABLE Requirement(
	OrderNum INT IDENTITY (1, 1),
	RequireID INT,
	CEmail Char(50),
	CGender Nchar(20),
	FullName Nchar(20),
	City Nchar(20),
	District Nchar(20),
	PhoneNum Nchar(20),
	CAddress Nchar(500),
	JobName Nchar(500),
	Detail Nchar(500),
	WGender Nchar(20),
	Cost Nchar(20),
	Primary key (RequireID,CEmail),
	foreign key (CEmail)  references Customer(CEmail),
)
GO

--2--Procedure nhap Requirement---
CREATE PROCEDURE pd_Requirement_Insert(@RequireID INT,@CEmail Char(50),
	@JobName Nchar(500),@Detail Nchar(500),@WGender Nchar(20),@Cost Nchar(20)) AS
BEGIN
	DECLARE @CGender Nchar(20),@FullName Nchar(20),@City Nchar(20),
		@District Nchar(20),@PhoneNum Nchar(20),@CAddress Nchar(500)
	SELECT @CGender = Gender, @FullName = FullName, @City = City,
		@District = District, @PhoneNum = PhoneNum, @CAddress = CAddress
		FROM Customer
		WHERE @CEmail = CEmail
	INSERT INTO Requirement(RequireID,CEmail,CGender,FullName,City,District,PhoneNum,CAddress,JobName,Detail,WGender,Cost)
	VALUES (@RequireID,@CEmail,@CGender,@FullName,@City,@District,@PhoneNum,@CAddress,@JobName,@Detail,@WGender,@Cost)
END
GO

EXEC pd_Requirement_Insert 1,'Nam@gmail.com','Painting Walls',
	'If you can create a beautiful picture for my house, Ill tip you 50% more','Everyone','45'
EXEC pd_Requirement_Insert 2,'Phuong@gmail.com','Painting Walls',
	'If you can create a beautiful picture for my house, Ill tip you 50% more','Everyone','45'
EXEC pd_Requirement_Insert 3,'Ha@gmail.com','Painting Walls',
	'If you can create a beautiful picture for my house, Ill tip you 50% more','Everyone','45'
EXEC pd_Requirement_Insert 4,'Hoi@gmail.com','Painting Walls',
	'If you can create a beautiful picture for my house, Ill tip you 50% more','Everyone','45'
EXEC pd_Requirement_Insert 5,'Ngan@gmail.com','Painting Walls',
	'If you can create a beautiful picture for my house, Ill tip you 50% more','Everyone','45'
GO

--SELECT * FROM Requirement
--SELECT * FROM Customer

--SELECT MAX(RequireID)+1 FROM Requirement
--SELECT * FROM Requirement WHERE CEmail = 'Nam@gmail.com'

--DELETE FROM Requirement WHERE CEmail = 'Nam@gmail.com' AND RequireID = 7

CREATE PROCEDURE pd_Requirement_Update (@RequireID INT,@CEmail Char(50),
	@JobName Nchar(500),@CAddress Nchar(500),@WGender Nchar(20),@Cost Nchar(20)) AS
BEGIN
	UPDATE Requirement SET JobName = @JobName , CAddress = @CAddress, WGender = @WGender, Cost = @Cost
	WHERE @CEmail = CEmail AND @RequireID = RequireID
END
GO

