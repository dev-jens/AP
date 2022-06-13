
CREATE OR ALTER PROCEDURE [dbo].[sp_Create_Dim_and_FactTables]
AS
BEGIN 
--- customer en category mogelijk fout geschreven eigen wss wel 
-- ik had tijd te kort want ik heb een tijd te kort ~ gewoon jens man 2960 gang

CREATE TABLE [SeaShippers_DWH].[DIM].Shippers
	(
		Id int NOT NULL  IDENTITY (1, 1)
      ,[Shipper_id] tinyint NOT NULL 
	  ,[Shipper_name] varchar(20) NOT NULL
	  ,[Phone] varchar(20) NULL
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
		[Order_date] DATETIME not null,
		[Required_date] DATETIME not null,
		[Shipped_date] DATETIME 		
	)ON [PRIMARY];

	ALTER TABLE [SeaShippers_DWH].DIM.ShipDate ADD CONSTRAINT
	PK_ShipDate PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


	ALTER TABLE [SeaShippers_DWH].DIM.ShipDate SET (LOCK_ESCALATION = TABLE)

CREATE TABLE [SeaShippers_DWH].[DIM].[Location]
	(	
		[Geo_id] int NOT NULL IDENTITY (1, 1),
		[Ship_adress] nvarchar(50) not null,
		[Ship_city] nvarchar(20),
		[Ship_postal_code] nvarchar(10), 
		[Ship_country] nvarchar(15),
		[Shippers_name] nvarchar(50),
		[Shippers_phone_nr] varchar(50)
	)ON [PRIMARY];

	ALTER TABLE [SeaShippers_DWH].[DIM].[Location] ADD CONSTRAINT
	PK_Location PRIMARY KEY CLUSTERED 
	(
	Geo_id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

	ALTER TABLE [SeaShippers_DWH].[DIM].[Location] SET (LOCK_ESCALATION = TABLE)


	CREATE TABLE [SeaShippers_DWH].[DIM].[Customers]
	(	
		Id int NOT NULL IDENTITY (1, 1),
		[Customer_id] char(5) not null,
		[Customer] varchar(50),
		[Contact_name_costumer] varchar(75),
		[Title] varchar(25),
		[Adress] varchar(30),
		[City] varchar(20),
		[Postal_code] varchar(10),
		[Country] varchar(15),
		[Phone] varchar(20)	
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
		[Product_id] tinyint not null,
		[Product_name] nvarchar(40),
		[Supplier_id] tinyint not null,
		[Category_id]  tinyint not null,
		[Quantity_per_unit] nvarchar(35),
		[Price] decimal(5,2),
		[Units_in_stock] int,
		[Units_on_order] int,
		[Recoder_level] int,
		[Discontinued] tinyint,
		[Company] nvarchar(50),
		[Contact] nvarchar(35),
		[Contact_title] nvarchar(35),
		[Phone] nvarchar(20),
		[Location] nvarchar(100),
		[Category_name] nvarchar(20),
		[Discription] nvarchar(50)

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
		[Order_id] int not null,
		[Customer_id] char(5) not null,
		[Employee_id] tinyint,
		[product_id] tinyint not null,
		[Shipvia] tinyint not null,
		[Order_date] datetime not null,
		[Geo_id] int not null,
		[Date_difference] int,
		[Quantity] tinyint not null,
		[Discount] decimal(3,2),
		[Freight] decimal not null,

	)ON [PRIMARY];

	ALTER TABLE [SeaShippers_DWH].[Fact].[Orders] ADD CONSTRAINT
	PK_Orders PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

	ALTER TABLE [SeaShippers_DWH].[Fact].[Orders] SET (LOCK_ESCALATION = TABLE)

END
GO
EXEC [dbo].[sp_Create_Dim_and_FactTables]