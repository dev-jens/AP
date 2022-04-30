CREATE OR ALTER PROCEDURE [dbo].[sp_create_FK]
as
begin
	-- FK product table
	ALTER TABLE [Staging].[CLEANSED].[Product] WITH NOCHECK
		ADD CONSTRAINT FK_Category_ID FOREIGN KEY ([CategoryID])
			REFERENCES [Staging].[CLEANSED].[Categories] ([CategoryID])

	-- FK orders table
	ALTER TABLE [staging].[CLEANSED].[Orders] WITH NOCHECK
		ADD CONSTRAINT FK_Customer_ID FOREIGN KEY (CustomerID)
			REFERENCES [staging].[CLEANSED].[Customers](CustomerID)

	ALTER TABLE [staging].[CLEANSED].[Orders] WITH NOCHECK
		ADD CONSTRAINT FK_ShipVia FOREIGN KEY (ShipVia)
			REFERENCES [staging].[CLEANSED].[Shippers](ShippersID)

	ALTER TABLE [staging].[CLEANSED].[Orders] WITH NOCHECK
		ADD CONSTRAINT FK_Product_ID FOREIGN KEY (ProductID)
			REFERENCES [staging].[CLEANSED].[Product](ProductID) 

	-- FK product details
	ALTER TABLE [staging].[CLEANSED].[Orders Details] WITH NOCHECK
		ADD CONSTRAINT FK_Order_ID FOREIGN KEY (OrderID)
			REFERENCES [staging].[CLEANSED].[Orders](OrderID)
END
GO
EXEC [dbo].sp_create_FK
