USE [db_petshop]
GO

/****** Object:  Table [dbo].[BiayaLain]    Script Date: 1/10/2022 8:34:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BiayaLain](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
	[bulan] [nvarchar](50) NULL,
	[keterangan] [nvarchar](100) NULL,
	[biaya] [int] NULL
) ON [PRIMARY]
GO

