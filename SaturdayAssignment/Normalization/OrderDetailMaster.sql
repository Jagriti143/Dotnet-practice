USE [AadhaarDB]
GO

/****** Object:  Table [dbo].[OrderDetailMaster]    Script Date: 31-01-2026 14:30:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderDetailMaster](
	[OrderDetailId] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetailMaster] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrderDetailMaster]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetailMaster_OrderMaster] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderMaster] ([OrderId])
GO

ALTER TABLE [dbo].[OrderDetailMaster] CHECK CONSTRAINT [FK_OrderDetailMaster_OrderMaster]
GO

