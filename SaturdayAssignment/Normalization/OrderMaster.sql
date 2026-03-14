USE [AadhaarDB]
GO

/****** Object:  Table [dbo].[OrderMaster]    Script Date: 31-01-2026 14:29:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderMaster](
	[OrderId] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[SalesPersonId] [int] NOT NULL,
 CONSTRAINT [PK_OrderMaster] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrderMaster]  WITH CHECK ADD  CONSTRAINT [FK_OrderMaster_CustomerMaster] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CustomerMaster] ([CustomerId])
GO

ALTER TABLE [dbo].[OrderMaster] CHECK CONSTRAINT [FK_OrderMaster_CustomerMaster]
GO

ALTER TABLE [dbo].[OrderMaster]  WITH CHECK ADD  CONSTRAINT [FK_OrderMaster_OrderMaster] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderMaster] ([OrderId])
GO

ALTER TABLE [dbo].[OrderMaster] CHECK CONSTRAINT [FK_OrderMaster_OrderMaster]
GO

