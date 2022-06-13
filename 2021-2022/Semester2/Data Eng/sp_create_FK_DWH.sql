CREATE OR ALTER PROCEDURE [dbo].[sp_create_FK_DWH]
as
begin
	-- FK productID in FACT.orders
	ALTER TABLE [SeaShippers_DWH].[FACT].[Orders] WITH NOCHECK
		ADD CONSTRAINT FK_Product_ID FOREIGN KEY ([id])
			REFERENCES [SeaShippers_DWH].[DIM].[Product]([id])

	-- FK productID in FACT.orders
	ALTER TABLE [SeaShippers_DWH].[FACT].[Orders] WITH NOCHECK
		ADD CONSTRAINT FK_Customer_ID FOREIGN KEY ([id])
			REFERENCES [SeaShippers_DWH].[DIM].[Customers]([id])

	-- FK productID in FACT.orders
	ALTER TABLE [SeaShippers_DWH].[FACT].[Orders] WITH NOCHECK
		ADD CONSTRAINT FK_ShipDate_ID FOREIGN KEY ([id])
			REFERENCES [SeaShippers_DWH].[DIM].[ShipDate]([id])

	-- FK productID in FACT.orders
	ALTER TABLE [SeaShippers_DWH].[FACT].[Orders] WITH NOCHECK
		ADD CONSTRAINT FK_shipVia_ID FOREIGN KEY ([id])
			REFERENCES [SeaShippers_DWH].[DIM].[Shippers]([id])

	-- FK productID in FACT.orders
	ALTER TABLE [SeaShippers_DWH].[FACT].[Orders] WITH NOCHECK
		ADD CONSTRAINT FK_GeoID_ID FOREIGN KEY ([Geo_id])
			REFERENCES [SeaShippers_DWH].[DIM].[Location]([Geo_id])

	
END
GO
EXEC [dbo].[sp_create_FK_DWH]