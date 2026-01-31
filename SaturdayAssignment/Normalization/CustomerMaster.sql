USE [AadhaarDB]
GO

/****** Object:  Table [dbo].[CustomerMaster]    Script Date: 31-01-2026 14:30:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerMaster](
	[CustomerId] [int] NOT NULL,
	[CustomerName] [nvarchar](100) NOT NULL,
	[CustomerPhone] [nvarchar](20) NOT NULL,
	[CustomerCity] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CustomerMaster] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CustomerMaster]  WITH CHECK ADD  CONSTRAINT [FK_CustomerMaster_CustomerMaster] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CustomerMaster] ([CustomerId])
GO

ALTER TABLE [dbo].[CustomerMaster] CHECK CONSTRAINT [FK_CustomerMaster_CustomerMaster]
GO

