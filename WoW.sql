
USE WorldofWork
go
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
	img varbinary(max),
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
	img varbinary(max),
)

go

CREATE TABLE Post (
    [OrderNum]   INT             IDENTITY (1, 1) NOT NULL,
    [IDP]        INT      unique,
    [WID]        NCHAR (20)      NULL,
    [Fullname]   NCHAR (100)     NULL,
    [Email]      NCHAR (20)      NULL,
    [JobField]   NCHAR (100)     NULL,
    [JobName]    NCHAR (100)     NULL,
    [WTime]      NCHAR (20)      NULL,
    [Cost]       NCHAR (20)      NULL,
    [PhoneNum]   NCHAR (20)      NULL,
    [Detail]     TEXT            NULL,
    [City]       NCHAR (100)     NULL,
    [District]   NCHAR (100)     NULL,
    [Experience] NCHAR (20)      NULL,
    [img]        VARBINARY (MAX) NULL,
	[Address]    NVARCHAR(max) NUll,
    PRIMARY KEY CLUSTERED ([IDP] ASC),
    FOREIGN KEY ([WID]) REFERENCES [dbo].[Worker] ([WID]),
);

create table dbo.Orders(
	OrderNum INT IDENTITY (1,1),
	CEmail char(50),
	IDP int,
	ODate datetime,
	FromHours int,
	FromMinutes int,
	OStatus Nchar(100),
	foreign key (CEmail) references Customer(CEmail),
)
go

create table dbo.Saves(
 	OrderNum INT IDENTITY (1,1),
	CID Nchar(20),
	IDP int,
	CEmail char(50),
	primary key (IDP,CEmail),
	foreign key (CEmail) references Customer(CEmail),
)
GO
----Nhap vao Customer
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress,img)
VALUES (N'C00001',N'Nam@gmail.com',N'Nam@gmail.com',N'Võ Hoài Nam',N'Male','1981-07-01',N'Hà Nội',N'Ba Đình',N'01928192839',N'Hà Nội, Ba Đình',null)
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress,img)
VALUES (N'C00002',N'Phuong@gmail.com',N'Phuong@gmail.com',N'Nguyễn Hoàng Phương',N'Female','1979-10-12',N'Hồ Chí Minh',N'Quận 9',N'08992102938',N'Hồ Chí Minh, Quận 9',null)
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress,img)
VALUES (N'C00003',N'Ha@gmail.com',N'Ha@gmail.com',N'Lê Thị Hà',N'Female','1999-01-09',N'Quảng Bình',N'Ba Đồn',N'09816238428',N'Quảng Bình, Ba Đồn',null)
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress,img)
VALUES (N'C00004',N'Hoi@gmail.com',N'Hoi@gmail.com',N'Đinh Thị Hợi',N'Female','1981-11-09',N'Bến Tre',N'Mỏ Cày',N'09212837119',N'Bến Tre, Mỏ Cày',null)
INSERT INTO Customer(CID,CEmail,CPassword,Fullname,Gender,CBirthday,City,District,PhoneNum,CAddress,img)
VALUES (N'C00005',N'Ngan@gmail.com',N'Ngan@gmail.com',N'Võ Văn Ngân',N'Female','1981-02-28',N'Hà Tĩnh',N'Thạch Hà',N'0873628332',N'Hà Tĩnh, Thạch Hà',null)
GO

----Nhap vao JobField
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00001',N'Repair and maintenance')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00002',N'Electricians')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00003',N'Cleaning service')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00004',N'Mechanics')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00005',N'Carpentry')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00006',N'Plumbing')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00007',N'Transport')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00008',N'Digital and Technology')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF00009',N'Family and Care')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF000010',N'Financial and accounting')
INSERT INTO JobField(IDJF,FieldName) VALUES (N'JF000011',N'Different')
GO

--SELECT * FROM Worker

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
----Procedure nhap vao Post co WID
-- DROP PROCEDURE pd_Insert_Post_
CREATE PROCEDURE pd_Insert_Post_(@IDP int,@Email CHAR(20),@JobName NCHAR(20),
	@WTime NCHAR(20),@Cost NCHAR(20),@Detail NCHAR(20),@Experience NCHAR(20),@PhoneNum NCHAR(20), 
	@City NVARCHAR(100), @District NVARCHAR(100),@JobField NCHAR(100),@img varbinary(max), @Address NVARCHAR(MAX)  ) AS
BEGIN
	DECLARE @WID NCHAR(20), @Fullname NCHAR(100)
	SELECT @WID = WID FROM Worker WHERE WEmail = @Email
	SELECT @Fullname = Fullname FROM Worker WHERE WEmail = @Email

	INSERT INTO Post(IDP,Email,JobName,WTime,Cost,Detail,Experience,PhoneNum,City,District,JobField,img,WID,FullName,Address)
	VALUES(@IDP,@Email,@JobName,@WTime,@Cost,@Detail,@Experience,@PhoneNum,@City,@District,@JobField,@img,@WID,@FullName,@Address)
END
GO

-- SELECT * FROM Post
EXEC pd_Insert_Post_ 1,'Anh@gmail.com','Sua xe','3-4','20','Toi rua xe rat nhanh','3-4','089918293812',N'Hà Nội',N'Quận Cầu Giấy','Repair and maintenance',NULL
EXEC pd_Insert_Post_ 2,'Hung@gmail.com','Sua xe','3-4','20','Toi rua xe rat nhanh','3-4','089918293812',N'Hà Nội',N'Quận Cầu Giấy','Repair and maintenance',NULL

-- SELECT MAX(IDP) + 1 AS IDPNext FROM Post

----Procedure delete vao Post co WID
CREATE PROCEDURE pd_delete_Post_Order
(@IDP int) AS
BEGIN
	DELETE FROM Orders WHERE IDP = @IDP
	DELETE FROM Post WHERE IDP = @IDP
END

------------------------------------------------------------------------------------------------

go
----Nhap vao Orders

----Nhap vao Saves
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00001',3,'Nam@gmail.com')
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00002',3,N'Phuong@gmail.com')
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00003',4,N'Ha@gmail.com')
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00004',5,N'Hoi@gmail.com')
INSERT INTO Saves(CID,IDP,CEmail) VALUES(N'C00005',5,N'Ngan@gmail.com')
GO

-- SELECT Customer.Fullname as fullname,Orders.OrderNum as OrderNum, Customer.CEmail as CEmail, Customer.PhoneNum as phonenumber,Post.IDP as IDpost, Post.JobName as jobname, Post.Cost as cost, Post.Experience as experience, Post.WTime as time, Orders.IDP, OStatus, ODate, FromHours, FromMinutes, Post.Fullname as WorkerName,Customer.CAddress as CAddress FROM Post,Orders, Customer WHERE Post.IDP = Orders.IDP and Post.Email = 'Anh@gmail.com' and Customer.CEmail = Orders.CEmail

----------Data cho FRequirement_Jobs----------
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
	Primary key (RequireID,CEmail),
	foreign key (CEmail)  references Customer(CEmail),
)
GO

--Procedure nhap Requirement---
CREATE PROCEDURE pd_Requirement_Insert(@RequireID INT,@CEmail Char(50),@JobName Nchar(500),@Detail Nchar(500)) AS
BEGIN
	DECLARE @CGender Nchar(20),@FullName Nchar(20),@City Nchar(20),
		@District Nchar(20),@PhoneNum Nchar(20),@CAddress Nchar(500)
	SELECT @CGender = Gender, @FullName = FullName, @City = City,
		@District = District, @PhoneNum = PhoneNum, @CAddress = CAddress
		FROM Customer
		WHERE @CEmail = CEmail
	INSERT INTO Requirement(RequireID,CEmail,CGender,FullName,City,District,PhoneNum,CAddress,JobName,Detail)
	VALUES (@RequireID,@CEmail,@CGender,@FullName,@City,@District,@PhoneNum,@CAddress,@JobName,@Detail)
END
GO

EXEC pd_Requirement_Insert 1,'Nam@gmail.com','Fixing cars',
	'My car has a flat tire and scratches on the outside paint. I need a mechanic who can replace all 4 wheels because I think they are quite old, and replace the entire outside paint. My house has a garden and a hose, I need you to do it right at my house because I cant move my car anywhere.'
EXEC pd_Requirement_Insert 2,'Nam@gmail.com','Painting Walls',
	'The paint on the outside of our house is quite old and peeling quite a bit, so I needed a painter who could repaint the entire exterior with a white base coat and a coat of cream paint.'
GO


CREATE TABLE [dbo].[Review] (
    [IDP]   int      NOT NULL,
    [WID]    NCHAR (20)      NOT NULL,
    [Rating] FLOAT (53)      NULL,
    [Review] NVARCHAR (200)  NULL,
    [Img]    VARBINARY (MAX) NULL,
    [CEmail] CHAR (50)       NOT NULL,
    CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED ([CEmail] ASC),
    FOREIGN KEY ([IDP]) REFERENCES [dbo].[Post] ([IDP]),
    FOREIGN KEY ([WID]) REFERENCES [dbo].[Worker] ([WID])
);
--thêm view
go

CREATE VIEW PostsWithAverageRating AS
SELECT 
    p.IDP, 
    p.WTime, 
    p.JobName, 
    p.Cost, 
    p.Experience, 
    p.District, 
    p.WID, 
    p.Email,
    p.PhoneNum,
    jf.FieldName, -- Thêm trường IDJF từ bảng JobField thông qua bảng Job
    p.City,
	p.img,
    ROUND(ISNULL(AVG(r.Rating), 0), 0) AS Rating 
FROM 
    Post p 
LEFT JOIN 
    Review r ON p.IDP = r.IDP 
LEFT JOIN
    JobField jf ON p.JobField = jf.FieldName -- Liên kết bảng JobField để lấy IDJF
GROUP BY 
    p.IDP, p.WTime, p.JobName, p.Cost, p.Experience, p.District, p.WID, p.City, p.Email, p.PhoneNum, jf.FieldName,p.img; -- Thêm j.IDJF vào danh sách GROUP BY
GO

-- THEM BANG CHO WORKER BOOK
CREATE TABLE WorkerBook (
	OrderNum INT IDENTITY (1, 1),
	RequireID INT,
	WEmail char(20),
)
GO

CREATE FUNCTION fnCheckBook(@requireID INT, @wEmail Nchar(20))
RETURNS INT 
AS
BEGIN
DECLARE @n INT
IF(EXISTS(SELECT * FROM WorkerBook WHERE RequireID = @requireID AND WEmail = @wEmail))
	BEGIN
		SELECT @n = 1
	END
ELSE
	BEGIN
		SELECT @n = 0
	END
RETURN @n
END
GO

-- THEM BANG LUONG CHO WORKER
CREATE TABLE Salary(
	OrderNum INT IDENTITY (1, 1),
	ReceiveTime DATETIME,
	WID Nchar(20),
	WEmail char(50),
	Charge char(50),
	IDP int,
	foreign key (WID)  references Worker(WID)
)
GO

CREATE PROCEDURE spInsertSalary(@wEmail char(50), @idp int) AS
BEGIN
	DECLARE @wid Nchar(20), @receiveTime DATE, @charge char(50)
	SELECT @receiveTime = GETDATE()
	SELECT @wid = WID FROM Worker WHERE WEmail = @wEmail
	SELECT @charge = Cost FROM Post WHERE IDP = @idp
	INSERT INTO Salary(ReceiveTime,WID,WEmail,Charge,IDP) VALUES (@receiveTime,@wid,@wEmail,@charge,@idp)
END
GO

-- SELECT * FROM Salary

EXEC spInsertSalary 'Anh@gmail.com',1
INSERT INTO Salary(ReceiveTime,WID,WEmail,Charge,IDP) VALUES ('2024-01-01','W00001','Anh@gmail.com','100',1)
INSERT INTO Salary(ReceiveTime,WID,WEmail,Charge,IDP) VALUES ('2024-02-01','W00001','Anh@gmail.com','250',1)
INSERT INTO Salary(ReceiveTime,WID,WEmail,Charge,IDP) VALUES ('2024-03-01','W00001','Anh@gmail.com','150',1)
INSERT INTO Salary(ReceiveTime,WID,WEmail,Charge,IDP) VALUES ('2024-04-01','W00001','Anh@gmail.com','200',1)
GO

CREATE FUNCTION fnSelectSalary(@wEmail char(50), @month char(20))
RETURNS INT 
AS
BEGIN
	DECLARE @sumSalary INT
	SELECT @sumSalary = SUM(CAST(Charge AS INT)) FROM Salary WHERE WEmail = @wEmail AND @month = MONTH (ReceiveTime)
	RETURN @sumSalary
END
GO
--SELECT TOP 1 Post.JobName, Post.Cost, Orders.ODate, Orders.OStatus 
--FROM Orders 
--INNER JOIN Post ON Orders.IDP = Post.IDP 
--ORDER BY ODate DESC

--select * from Review



Create table Cities
(
	iD int primary key,
	City NVARCHAR(max),
	District NVARCHAR(max)
)
go

INSERT INTO Cities (ID, City, District) VALUES
(1, N'Hồ Chí Minh', N'Quận 1'),
(2, N'Hồ Chí Minh', N'Quận 2'),
(3, N'Hồ Chí Minh', N'Quận 3'),
(4, N'Hồ Chí Minh', N'Quận 4'),
(5, N'Hồ Chí Minh', N'Quận 5'),
(6, N'Hồ Chí Minh', N'Quận 6'),
(7, N'Hồ Chí Minh', N'Quận 7'),
(8, N'Hồ Chí Minh', N'Quận 8'),
(9, N'Hồ Chí Minh', N'Quận 9'),
(10, N'Hồ Chí Minh', N'Quận 10'),
(11, N'Hồ Chí Minh', N'Quận 11'),
(12, N'Hồ Chí Minh', N'Quận 12'),
(13, N'Hồ Chí Minh', N'Quận Bình Tân'),
(14, N'Hồ Chí Minh', N'Quận Bình Thạnh'),
(15, N'Hồ Chí Minh', N'Quận Gò Vấp'),
(16, N'Hồ Chí Minh', N'Quận Phú Nhuận'),
(17, N'Hồ Chí Minh', N'Quận Tân Bình'),
(18, N'Hồ Chí Minh', N'Quận Tân Phú'),
(19, N'Hồ Chí Minh', N'Quận Thủ Đức'),
(31, N'Hà Nội', N'Quận Ba Đình'),
(20, N'Hà Nội', N'Quận Hoàn Kiếm'),
(21, N'Hà Nội', N'Quận Tây Hồ'),
(22, N'Hà Nội', N'Quận Long Biên'),
(23, N'Hà Nội', N'Quận Cầu Giấy'),
(24, N'Hà Nội', N'Quận Đống Đa'),
(25, N'Hà Nội', N'Quận Hai Bà Trưng'),
(26, N'Hà Nội', N'Quận Hoàng Mai'),
(27, N'Hà Nội', N'Quận Thanh Xuân'),
(28, N'Hà Nội', N'Quận Nam Từ Liêm'),
(29, N'Hà Nội', N'Quận Bắc Từ Liêm'),
(30, N'Hà Nội', N'Quận Hà Đông');
GO