Create table dbo.Cusomter(	
	OrderNum INT IDENTITY (1,1),
	CID Nchar(20),
	CEmail char(50),
	CPassword char(50),
	Fullname Nchar(100),
	Gender Nchar(10),
	CBirthday DATE,
	City NCHAR(20),
	District NCHAR(20),
	PhoneNum NCHAR(20) UNIQUE,
	CAddress text,
	primary key(Cid)
)

go 
create table dbo.JobField
(
	OrderNum INT IDENTITY (1,1),
	IDJF Nchar(20) primary key,
	FieldName NChar(100),
)
create table dbo.Job(
	OrderNum int identity(1,1),
	IDJ Nchar(20) primary key,
	IDJF Nchar(20),
	JobName Nchar(100),
	foreign key (IDJF)  references JobField(IDJF)
)
create table dbo.Worker(
	OderNum INT IDENTITY (1,1),
	WID Nchar(20),
	WEmail char(50),
	WPassword char(50),
	Fullname Nchar(150),
	Gender Nchar(10),
	City Nchar(100),
	District Nchar(100),
	PhoneNum Nchar(20),
	WAddress text,
	IDJF NChar(20),
	foreign key (IDJF) references JobField(IDJF)
)

create table dbo.Post(
	OrderNum INT IDENTITY (1,1),
	IDP Nchar(20) primary key,
	WID Nchar(20),
	IDJ NChar(20),
	WTime NChar(20), 
	Cost NChar(20),
	PhoneNum Nchar(20),
	Detail text,
	City Nchar(100),
	District Nchar(100),
	foreign key (WID) references Worker(WID),
	foreign key (IDJ) references Job(IDJ)
)

create table dbo.Orders(
	OrderNum INT IDENTITY (1,1),
	CID Nchar(20),
	IDP Nchar(20),
	Timestart datetime,
	TimeEnd datetime,
	primary key (CID,IDP),
	foreign key (CID) references Customer(CID),
	foreign key (IDP) references Post(IDP)

)

go
create table dbo.Saves(
 	OrderNum INT IDENTITY (1,1),
	IDC Nchar(20),
	IDP NChar(20),
	primary key (CID,IDP),
	foreign key (CID) references Customer(CID),
	foreign key (IDP) references Post(IDP)
)