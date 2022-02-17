CREATE TABLE [ARCHIVED].[Catogories]
(
	CategoryID float,
    CategoryName nvarchar(255),
    Discription nvarchar(255)

);
CREATE TABLE [ARCHIVED].[Customers]
(
	CustomerID nvarchar(50),
	Customer nvarchar(50),
	[ContactName Customer] nvarchar(50),
	Title nvarchar(50),
	Adres nvarchar(50),
	City nvarchar(50),
	PostalCode nvarchar(50),
	Country nvarchar(50),
	Phone nvarchar(50)
);
CREATE TABLE [ARCHIVED].[Orders]
(
	orderID float(50),
	CustomerID nvarchar(255),
	EmployeeID float(50),
	OrderDate datetime,
	RequiredDate datetime,
	ShippedDate datetime,
	ShipVia float,
	Freight float,
	ShipName nvarchar(255),
	ShipAddress nvarchar(255),
	ShipCity nvarchar(255),
	ShipPostalCode nvarchar(255),
	ShipCountry nvarchar(255),
	ProductID float
);
CREATE TABLE [ARCHIVED].[Orders Details]
(
	OrderID float,
	Quantity float,
	Discount varchar(255)
   
);
CREATE TABLE [ARCHIVED].[Suppliers] (
	[SupplierID] NVARCHAR(100),
	[Company] NVARCHAR(250),
	[Contact] NVARCHAR(250),
	[Contact title] NVARCHAR(250),
	[Phone] NVARCHAR(100),
	[Location] NVARCHAR(250))

CREATE TABLE [ARCHIVED].[Shippers] (
	[Name] VARCHAR(50),
	[Phone] VARCHAR(50))

CREATE TABLE [ARCHIVED].[Product] (
	[ProductID] FLOAT,
	[ProductName] NVARCHAR(255),
	[SupplierID] FLOAT,
	[CategoryID] FLOAT,
	[QuantityPerUnit] NVARCHAR(255),
	[UnitPrice] FLOAT,
	[UnitsInStock] FLOAT,
	[UnitsOnOrder] FLOAT,
	[ReorderLevel] FLOAT,
	[Discontinued] BIT
)