
CREATE OR ALTER PROCEDURE [dbo].[sp_Create_Dim_and_FactTables]
AS
BEGIN 
--- customer en category mogelijk fout geschreven eigen wss wel 
-- ik had tijd te kort want ik heb een tijd te kort ~ gewoon jens man 2960 gang

CREATE TABLE  [SeaShippers_DWH].[DIM].Shippers
	(
		Id int NOT NULL  IDENTITY (1, 1)
      ,[Shipper_id] int NOT NULL 
	  ,[Shipper_name] varchar(50) NOT NULL
	  ,[Phone] varchar(50) NULL
	)ON [PRIMARY];

ALTER TABLE [SeaShippers_DWH].DIM.Shippers ADD CONSTRAINT
	PK_Shippers PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

ALTER TABLE [SeaShippers_DWH].DIM.Shippers SET (LOCK_ESCALATION = TABLE)


CREATE TABLE [SeaShippers_DWH].[DIM].ShipDate
	(	
		Id int NOT NULL IDENTITY (1, 1),
		OrderDate DATE not null,
		RequiredDate DATE,
		ShippedDate DATE 		
	)ON [PRIMARY];

	ALTER TABLE [SeaShippers_DWH].DIM.ShipDate ADD CONSTRAINT
	PK_ShipDate PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


	ALTER TABLE [SeaShippers_DWH].DIM.ShipDate SET (LOCK_ESCALATION = TABLE)

CREATE TABLE [SeaShippers_DWH].[DIM].[Location]
	(	
		GeoId int NOT NULL IDENTITY (1, 1),
		ShipAdress varchar(50) not null,
		ShipCity varchar(50),
		ShipPostalCode varchar(50), 
		ShipCountry varchar(50),
		ShippersName varchar(50),
		ShippersPhoneNr varchar(50)
	)ON [PRIMARY];

	ALTER TABLE [SeaShippers_DWH].[DIM].[Location] ADD CONSTRAINT
	PK_Location PRIMARY KEY CLUSTERED 
	(
	GeoId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

	ALTER TABLE [SeaShippers_DWH].[DIM].[Location] SET (LOCK_ESCALATION = TABLE)


	CREATE TABLE [SeaShippers_DWH].[DIM].[Customers]
	(	
		Id int NOT NULL IDENTITY (1, 1),
		CustomerID varchar(50),
		Customer varchar(50),
		ContactNameCostumer varchar(50),
		Title varchar(50),
		Adress varchar(50),
		City varchar(50),
		PostalCode varchar(50),
		Country varchar(50),
		Phone varchar(50)	
	)ON [PRIMARY];

	ALTER TABLE [SeaShippers_DWH].[DIM].[Customers] ADD CONSTRAINT
	PK_Customers PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

	ALTER TABLE [SeaShippers_DWH].[DIM].[Customers] SET (LOCK_ESCALATION = TABLE)

	CREATE TABLE [SeaShippers_DWH].[DIM].[Product]
	(	
		Id int NOT NULL IDENTITY (1, 1),
		productID varchar(50),
		ProductName varchar(50),
		SupplierID varchar(50),
		CategoryID varchar(50),
		QuantityPerUnit varchar(50),
		Price varchar(50),
		UnitsInStock varchar(50),
		UnitsOnOrder varchar(50),
		RecoderLevel varchar(50),
		Discontinued varchar(50),
		Company varchar(50),
		Contact varchar(50),
		ContactTitle varchar(50),
		Phone varchar(50),
		[Location] varchar(50),
		CategoryName varchar(50),
		Discription varchar(50)

	)ON [PRIMARY];

	ALTER TABLE [SeaShippers_DWH].[DIM].[Product] ADD CONSTRAINT
	PK_Product PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

	ALTER TABLE [SeaShippers_DWH].[DIM].[Product] SET (LOCK_ESCALATION = TABLE)


	CREATE TABLE [SeaShippers_DWH].[Fact].[Orders]
	(	
		Id int NOT NULL IDENTITY (1, 1),
		OrderID varchar(50),
		CustomerID varchar(50),
		EmployeeID varchar(50),
		productID varchar(50),
		Shipvia varchar(50),
		OrderDate varchar(50),
		GeoID varchar(50),
		[Date Difference] DATE,
		Quantity varchar(50),
		Discount varchar(50),
		Freight varchar(50),

	)ON [PRIMARY];

	ALTER TABLE [SeaShippers_DWH].[Fact].[Orders] ADD CONSTRAINT
	PK_Orders PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

	ALTER TABLE [SeaShippers_DWH].[Fact].[Orders] SET (LOCK_ESCALATION = TABLE)

END;