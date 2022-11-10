create database CaseBuilder
go
use CaseBuilder
go

create table [Processor]
(
	[Model] varchar(200),
	[Brand] varchar(100),
	[Cores] int,
	[Threads] int,
	[Socket Type] varchar(100),
	[Memory Type] varchar(100),
	[Memory Speed] varchar(100),
	[Base Speed] varchar(50),
	[Turbo Speed] varchar(50),
	[Max Power Consumption] varchar(10),
	[Price] numeric(10,2),
	constraint PK_Processor primary key(Model)
)
go
create table [Motherboard]
(
	[Model] varchar(200),
	[Brand] varchar(100),
	[Chipset] varchar(100),
	[Form Factor] varchar(50),
	[Socket Type] varchar(50),
	[Memory Slots] varchar(10),
	[Memory Type] varchar(10),
	[Memory Speed] varchar(200),
	[Storage Expansion] varchar(100),
	[Multi-GPU Support] varchar(3),
	[Price] numeric(10,2),
	constraint PK_Motherboard primary key(Model)
);
go
create table [CPU Cooler]
(
	[Model] varchar(200),
	[Brand] varchar(100),
	[Fan RPM] varchar(200),
	[Noise Level] varchar(200),
	[Color] varchar(50),
	[Price] numeric(10,2),
	constraint PK_CPUCooler primary key(Model)
);
go
create table [Case]
(
	[Model] varchar(200),
	[Brand] varchar(100),
	[Side Panel] varchar(200),
	[Carbinet Type] varchar(200),
	[Color] varchar(50),
	[Motherboard Support] varchar(200),
	[Max GPU Length] varchar(50),
	[CPU Cooler Height] varchar(50),
	[Supported PSU Size] varchar(10),
	[Price] numeric(10,2),
	constraint PK_Case primary key(Model)
);
go

create table [Graphic Card]
(
	[Model] varchar(200),
	[Brand] varchar(100),
	[Memory] varchar(200),
	[Memory Interface] varchar(200),
	[Length] varchar(50),
	[Interface] varchar(50),
	[Chipset] varchar(100),
	[Max Power Consumption] varchar(10),
	[Price] numeric(10,2),
	constraint PK_GraphicCard primary key(Model)
);
go
create table [RAM]
(
	[Model] varchar(200),
	[Brand] varchar(100),
	[RAM Size] varchar(200),
	[Quantity] varchar(100),
	[RAM Type] varchar(50),
	[RAM Speed] varchar(100),
	[Price] numeric(10,2),
	constraint PK_RAM primary key(Model)
);
go
create table [Storage]
(
	[Model] varchar(200),
	[Brand] varchar(100),
	[Capacity] varchar(200),
	[Type] varchar(100),
	[RPM] varchar(100),
	[Interface] varchar(50),
	[Cache Memory] varchar(100),
	[Form Factor] varchar(100),
	[Price] numeric(10,2),
	constraint PK_Storage primary key(Model)
);
go
create table [Case Cooler]
(
	[Model] varchar(200),
	[Brand] varchar(100),
	[Fan RPM] varchar(200),
	[Airflow] varchar(100),
	[Noise Level] varchar(50),
	[Price] numeric(10,2),
	constraint PK_CaseCooler primary key(Model)
);
go
create table [Power Supply]
(
	[Model] varchar(200),
	[Brand] varchar(100),
	[Power] varchar(200),
	[Efficiency] varchar(100),
	[Color] varchar(50),
	[Price] numeric(10,2),
	constraint PK_PowerSupply primary key(Model)
);
go
create table [Build List]
(
    [Name] varchar(200),
    [Processor] varchar(200),
    [Case] varchar(200),
    [Motherboard] varchar(200),
    [Case Cooler] varchar(200),
    [CPU Cooler] varchar(200),
    [Graphic Card] varchar(200),
    [RAM] varchar(200),
    [Storage] varchar(200),
    [Power Supply] varchar(200),
	[Date] datetime,
    constraint PK_Build primary key(Name)
); 
go
Insert into Processor values ('Ryzen Threadripper 3990X','AMD',64,128,'sTRX4','DDR4', '3200','2.9','4.3','280',8078)
Insert into Processor values ('Ryzen 9 7950X','AMD',16,32,'AM5','DDR5','5200','4.5','5.7','170',699)
Insert into [Motherboard] values ('TRX40 CREATOR','ASRock','AMD X570','ATX','sTRX4','8','DDR4','2666','SATA III, PCIe 4.0 x4','Yes',1549)
Insert into [Motherboard] values ('TRX40 Aorus Pro WiFi','Gigabyte','AMD TRX40','ATX','sTRX4','8','DDR4','4400','SATA III, PCIe 4.0 x4','Yes',820)
Insert into [CPU Cooler] values ('Hyper 212 EVO','Cooler Master','600 to 2000 rpm','9 to 36 dBA','RGB',42.99)
Insert into [CPU Cooler] values ('Hyper 212 RGB','Cooler Master','650 to 2000 rpm','8 to 30 dBA','RGB',95.99)
Insert into [Case] values ('H510B-W1','NZXT','Tempered Glass, Steel','ATX Mid Tower','White','ATX, Micro-ATK, Mini-ITX','381','165','ATX',89.99)
Insert into [Case] values ('H510B-B1','NZXT','Tempered Glass, Steel','ATX Full Tower','Black','ATX, Micro-ATX, Mini-ITX','381','165','ATX',83.13)
Insert into [Graphic Card] values ('GeForce RTX 3080 Ti Gaming OC 12G','Gigabyte','12 GB','GDDR6X','320','PCIe x16','GeForce RTX 3080 Ti','350',1233.86)
Insert into [Graphic Card] values ('TUF Gaming GeForce RTX 3080 Ti OC Edition','ASUS','12 GB','GDDR6X','300','PCIe x16','GeForce RTX 3080 Ti','350',1159)
Insert into RAM values ('Trident Z5 RGB','G.Skill','32 GB','2 x 16 GB','DDR5','6400',269.99)
Insert into RAM values ('Fury Renegade RGB','Kingston','32 GB','2 x 16 GB','DDR5','6400',307.20)
Insert into Storage values ('970 EVO','Samsung','1 TB','SSD','N/A','PCIe 3.0 x4','1024 MB','M.2-2280',219.99)
Insert into Storage values ('BarraCuda','Seagate','2 TB','HHD','7200 RPM','SATA III','256 MB','3.5"',55.49)
Insert into [Case Cooler] values ('MasterFan MF120R','Cooler Master','650 to 2000 RPM','59 CFM','31 dBA',79)
Insert into [Case Cooler] values ('AER RGB','NZXT','500 to 1500 RPM','17.48 to 52.44 CFM','22 to 33 dBA',24.55)
Insert into [Power Supply] values ('RM750','Corsair','750 W','80+ Gold','Black',169)
Insert into [Power Supply] values ('RM850','Corsair','850 W','80+ Gold','Black',195)
Insert into [Build List] values ('temporary-cache','','','','','','','','','','')
go