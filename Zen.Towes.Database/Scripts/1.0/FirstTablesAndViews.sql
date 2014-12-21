-- Product
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) NOT NULL,
	[ImgSrc] [nvarchar](2000) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[CreatedBy] [nvarchar](100) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[ModifiedBy] [nvarchar](100) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

-- ExpiryDate
CREATE TABLE [dbo].[ExpiryDate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[DueDate] [date] NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[CreatedBy] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ExpiryDate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ExpiryDate]  WITH CHECK ADD  CONSTRAINT [FK_ExpiryDate_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[ExpiryDate] CHECK CONSTRAINT [FK_ExpiryDate_Product]
GO

-- ProductExpiryDate
CREATE VIEW [dbo].[ProductExpiryDate] AS
	SELECT        
		ed.Id AS ExpiryDateId,
		ed.DueDate AS DueDate,
		p.Id AS ProductId,
		p.Name AS ProductName,
		p.ImgSrc AS ProductImgSrc,
		DATEDIFF(d, GETUTCDATE(), ed.DueDate) AS DaysLeft
	FROM            
		dbo.ExpiryDate AS ed 
	JOIN
		dbo.Product AS p ON ed.ProductId = p.Id
GO


